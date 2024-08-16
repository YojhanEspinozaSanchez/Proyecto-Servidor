using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using System.Threading;
using System.Collections.Generic;
using DataLayer;
using EntityLayer;
using System.IO;
using System.Windows.Forms;


/*
 UNED II Cuatrimestre
Proyecto II: Registro de Rentas de Peliculas
Yojhan Espinoza
Fecha: 11/7/2024
 */

namespace BusinessLayer
{
    //se inicializa la funcion sacado de: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
    public delegate void LogEventDelegate(string message);
    public class Server
    {
        //variables para comunicacion
        private SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
        private TcpListener listener;
        public LogEventDelegate LogEvent { get; set; }
        private bool running;
        private string ipAddress;
        private int port;

        
        private AdminsBL adminBL;

        //constructor
        public Server(string ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;
            adminBL = new AdminsBL();
        }

        //metodo para iniciar el servidor
        public void Start()
        {
            listener = new TcpListener(IPAddress.Parse(ipAddress), port);
            listener.Start();
            running = true;
           

            while (running)
            {
                if (listener.Pending())
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ThreadPool.QueueUserWorkItem(HandleClient, client);
                    if(LogEvent != null)
                    {
                        LogEvent($"Cliente conectado: {client.Client.RemoteEndPoint}");
                    }
                }
                Thread.Sleep(100); 
            }
        }


        //detener el servidor
        public void Stop()
        {
            running = false;
            listener.Stop();
           
        }


        //Metodo para controlar los request del cliente
        private void HandleClient(object clientObj)
        {
          

            TcpClient client = (TcpClient)clientObj;
            NetworkStream stream = client.GetStream();
            Customer connectedCustomer = null;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        // El cliente ha cerrado la conexión
                        break;
                    }

                    string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                   
                    //le envia la lista de sucursales al cliente
                    if (request.StartsWith("GET_BRANCH"))
                    {
                        HandleGetBranch(stream);
                       
                    }

                    //valida el cliente ingresado
                    if (request.StartsWith("VALIDATE_CLIENT"))
                    {
                        connectedCustomer = HandleValidateClient(stream, request);
                    }

                    //le envia la lista de peliculas al cliente
                    if (request.StartsWith("GET_MOVIE"))
                    {
                        HandleGetMovie(stream, request);
                    }

                    //hace la transicion de datos y guarda el prestamo
                    if (request.StartsWith("INSERT_LOAN"))
                    {
                        
                        HandleInsertLoan(stream, request, connectedCustomer);
                    }

                    //envia la lista de prestamos al cliente
                    if (request.StartsWith("GET_LOAN"))
                    {
                        HandleGetList(stream, connectedCustomer);
                    }
                
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                stream.Close();
                client.Close();
           
            }
        }
        //le envia la lista de sucursales al cliente
        private void HandleGetBranch(NetworkStream stream)
        {
            try
            {
                // Llamar a la capa de acceso a datos para obtener la lista de administradores
                BranchBL branchBL = new BranchBL();
                List<Branch> branchList = branchBL.GetBranch();
                string jsonData = JsonConvert.SerializeObject(branchList);

                // Enviar la respuesta al cliente con un encabezado  y la lista
                string response = "GET_BRANCH_RESPONSE" + jsonData;
                byte[] data = Encoding.UTF8.GetBytes(response);
                stream.Write(data, 0, data.Length);
                if (LogEvent != null)
                {
                    LogEvent($"Mensaje enviado: {response}");
                }
                
            }
            catch (Exception ex)
            {
                string errorResponse = JsonConvert.SerializeObject(null);
                byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                stream.Write(errorData, 0, errorData.Length);
                if (LogEvent != null)
                {
                    LogEvent($"Mensaje enviado: {errorResponse}");
                }
            }
        }
        //le envia la lista de peliculas al cliente
        private void HandleGetMovie(NetworkStream stream, string message)
        {
            try
            {
                //divide el mensaje recibido para separar la variable por parametro
                string[] parts = message.Split('|');
                if (parts.Length != 2)
                {
                    // Mensaje no válido, enviar respuesta de error
                    string errorResponse = JsonConvert.SerializeObject(null);
                    byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                    stream.Write(errorData, 0, errorData.Length);
                    return;
                }

                string branchJson = parts[1];
                Branch branch = JsonConvert.DeserializeObject<Branch>(branchJson);

                // Validar el objeto Branch
                if (branch == null)
                {
                    // Objeto Branch inválido, envia respuesta de error
                    string errorResponse = JsonConvert.SerializeObject(null);
                    byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                    stream.Write(errorData, 0, errorData.Length);
                    return;
                }

                // Llamar a la capa de acceso a datos para obtener la lista de películas asociadas con la sucursal
                MovieByBranchBL movieByBranchBL = new MovieByBranchBL();
                List<MovieByBranch> associateList = movieByBranchBL.GetAssociation();
                List<Movie> movieList = new List<Movie>();

                foreach (var associate in associateList)
                {
                    if (associate.Branch.Id == branch.Id)
                    {
                        movieList.Add(associate.Movie);
                    }
                }

                // Serializar la lista de películas a JSON
                string jsonData = JsonConvert.SerializeObject(movieList);

                // Enviar la respuesta al cliente con la lista
                string response = "GET_MOVIE_RESPONSE" + jsonData;
                byte[] data = Encoding.UTF8.GetBytes(response);
                stream.Write(data, 0, data.Length);
                if (LogEvent != null)
                {
                    LogEvent($"Mensaje enviado: {response}");
                }
            }
            catch (Exception ex)
            {
                
                string errorResponse = JsonConvert.SerializeObject(null);
                byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                stream.Write(errorData, 0, errorData.Length);
                if (LogEvent != null)
                {
                    LogEvent($"Mensaje enviado: {errorResponse}");
                }
                return;
            }
        }


        //Valida el cliente y lo retorna
        private Customer HandleValidateClient(NetworkStream stream, string message)
        {
            try
            {
                
                string[] parts = message.Split('|');
                if (parts.Length != 2)
                {
                    
                    string errorResponse = JsonConvert.SerializeObject(null);
                    byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                    stream.Write(errorData, 0, errorData.Length);
                    if (LogEvent != null)
                    {
                        LogEvent($"Mensaje enviado: {errorResponse}");
                    }
                    return null;
                }

                string idString = parts[1];
                int id;
                if (!int.TryParse(idString, out id))
                {
                    
                    string errorResponse = JsonConvert.SerializeObject(null);
                    byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                    stream.Write(errorData, 0, errorData.Length);
                    return null;
                }

                // Obtener la lista de clientes
                CustomersBL customersBL = new CustomersBL();
                List<Customer> customerList = customersBL.GetCustomers();
                Customer nCustomer = null;

                // Buscar el cliente con el ID 
                bool clientExists = false;
                foreach (var customer in customerList)
                {
                    if (customer.SystemId == id && customer.Active == true)
                    {
                        clientExists = true;
                        nCustomer = customer;
                        break;
                    }
                }

                if (clientExists == true)
                {
                    // Envia la respuesta al cliente (true o false)
                    string response = JsonConvert.SerializeObject(nCustomer);
                    byte[] responseData = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseData, 0, responseData.Length);
                    if (LogEvent != null)
                    {
                        LogEvent($"Mensaje enviado: {response}");
                    }
                    return nCustomer;
                }
                else
                {
                    string response = JsonConvert.SerializeObject(null);
                    byte[] responseData = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseData, 0, responseData.Length);
                    if (LogEvent != null)
                    {
                        LogEvent($"Mensaje enviado: {response}");
                    }
                    return null;
                }

            }
            catch (Exception ex)
            {

                string errorResponse = JsonConvert.SerializeObject(null);
                byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                stream.Write(errorData, 0, errorData.Length);
                if (LogEvent != null)
                {
                    LogEvent($"Mensaje enviado: {errorResponse}");
                }
                return null;
            }

        }
        //guarda el prestamo en la base de datos
        private void HandleInsertLoan(NetworkStream stream, string message, Customer connectedCustomer)
        {

            //activa el semaforo
            semaphore.Wait();
            try
            {
               //separa el mensaje del objeto
                string[] parts = message.Split('|');
                if (parts.Length != 2)
                {
                    // envia respuesta de error
                    string errorResponse = JsonConvert.SerializeObject(null);
                    byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                    stream.Write(errorData, 0, errorData.Length);
                    if (LogEvent != null)
                    {
                        LogEvent($"Mensaje enviado: {errorResponse}");
                    }
                    return;
                }

                string Json = parts[1];
                MovieByBranch movieByBranch = JsonConvert.DeserializeObject<MovieByBranch>(Json);

                // Valida el objeto que no sea nulo
                if (movieByBranch == null)
                {
                    // Objeto Branch inválido, enviar respuesta de error
                    string errorResponse = JsonConvert.SerializeObject(null);
                    byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                    stream.Write(errorData, 0, errorData.Length);
                    return;
                }


                LoanBL loanBL = new LoanBL();
                MovieByBranchBL movieByBranchBL = new MovieByBranchBL();
                // Valida que no existan prestamos activos de la misma pelicula
                if (!loanBL.existId(movieByBranch.Movie.Id, connectedCustomer.SystemId))
                {
                    //valida la cantidad disponible de peliculas
                    if (movieByBranchBL.validateQty(movieByBranch))
                    {
                        int customerId = connectedCustomer.SystemId;
                        int branchId = movieByBranch.Branch.Id;
                        int movieId = movieByBranch.Movie.Id;
                        DateTime Date = DateTime.Now;
                        bool Pending = true;

                        Loan loan = new Loan(0, customerId, branchId, movieId, Date, Pending);
                        loanBL.insertLoan(loan);
                        movieByBranchBL.updateQty(movieByBranch);


                        
                        
                        // Serializar la lista de películas 
                        string jsonData = JsonConvert.SerializeObject(1);

                        // Enviar la respuesta al cliente  
                        string response = "GET_INSERT_RESPONSE" + jsonData;
                        byte[] data = Encoding.UTF8.GetBytes(response);
                        stream.Write(data, 0, data.Length);
                        if (LogEvent != null)
                        {
                            LogEvent($"Mensaje enviado: {response}");
                        }

                    }
                    else
                    {
                       
                        string jsonData = JsonConvert.SerializeObject(2);

                         
                        string response = "GET_INSERT_RESPONSE" + jsonData;
                        byte[] data = Encoding.UTF8.GetBytes(response);
                        stream.Write(data, 0, data.Length);
                        if (LogEvent != null)
                        {
                            LogEvent($"Mensaje enviado: {response}");
                        }
                    }
                }
                else
                {
                    string jsonData = JsonConvert.SerializeObject(3);

                  
                    string response = "GET_INSERT_RESPONSE" + jsonData;
                    byte[] data = Encoding.UTF8.GetBytes(response);
                    stream.Write(data, 0, data.Length);
                    if (LogEvent != null)
                    {
                        LogEvent($"Mensaje enviado: {response}");
                    }
                }


            }
            catch (Exception ex)
            {
               
                string errorResponse = JsonConvert.SerializeObject(null);
                byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                stream.Write(errorData, 0, errorData.Length);
                if (LogEvent != null)
                {
                    LogEvent($"Mensaje enviado: {errorResponse}");
                }
            }
            finally
            {
                //librea el semaforo para que otro cliente pueda realizar un un prestamo
               semaphore.Release();
            }

        }
        ////le envia la lista de prestamoss al cliente
        private void HandleGetList(NetworkStream stream, Customer connectedCustomer)
        {
            try
            {
                LoanBL loanBL = new LoanBL();
                // Obtener la lista filtrada de préstamos del cliente conectado
                List<Loan> filteredList = loanBL.getFiltered(connectedCustomer);

               
                string jsonData = JsonConvert.SerializeObject(filteredList);

               //envia la respuesta con la lista
                string response = "GET_LIST_RESPONSE" + jsonData;
                byte[] data = Encoding.UTF8.GetBytes(response);
                stream.Write(data, 0, data.Length);
                if (LogEvent != null)
                {
                    LogEvent($"Mensaje enviado: {response}");
                }

            }
            catch (Exception ex)
            {
                
                string errorResponse = JsonConvert.SerializeObject(null);
                byte[] errorData = Encoding.UTF8.GetBytes(errorResponse);
                stream.Write(errorData, 0, errorData.Length);
                if (LogEvent != null)
                {
                    LogEvent($"Mensaje enviado: {errorResponse}");
                }
            }
        }

    }


}


