using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


/*
 UNED II Cuatrimestre
Proyecto II: Registro de Rentas de Peliculas
Yojhan Espinoza
Fecha: 11/7/2024
 */
namespace DataLayer
{
    public class DataBase
    {
        private string ConnectionString = string.Empty;

        public DataBase()
        {
            this.ConnectionString = ConfigurationManager.ConnectionStrings["DataConnection"].ConnectionString;
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        //Funciones para el menu de encargados
        ///////////////////////////////////////////////////////////////////////////////////////
        /////
        //Insercion de encargados en la DB
        public bool InsertAdmin(BranchAdmin admin)
        {
            bool isSaved = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Verificar si la persona ya existe
                            string checkPersona = "SELECT COUNT(*) FROM dbo.Persona WHERE Identificacion = @Identificacion";
                            using (SqlCommand cmdCheckPersona = new SqlCommand(checkPersona, connection, transaction))
                            {
                                cmdCheckPersona.Parameters.AddWithValue("@Identificacion", admin.Id);
                                int count = (int)cmdCheckPersona.ExecuteScalar();

                                // Si no existe, insertar en la tabla Persona
                                if (count == 0)
                                {
                                    string insertPersona = "INSERT INTO dbo.Persona (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento) " +
                                                           "VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento)";

                                    using (SqlCommand cmdPersona = new SqlCommand(insertPersona, connection, transaction))
                                    {
                                        cmdPersona.Parameters.AddWithValue("@Identificacion", admin.Id);
                                        cmdPersona.Parameters.AddWithValue("@Nombre", admin.Name);
                                        cmdPersona.Parameters.AddWithValue("@PrimerApellido", admin.FirstLastName);
                                        cmdPersona.Parameters.AddWithValue("@SegundoApellido", admin.SecondLastName);
                                        cmdPersona.Parameters.AddWithValue("@FechaNacimiento", admin.BirthDate);
                                        cmdPersona.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Insertar en la tabla Empleado
                            string insertEmpleado = "INSERT INTO dbo.Encargado (IdEncargado, Identificacion, FechaIngreso) " +
                                                    "VALUES (@IdEncargado, @Identificacion, @FechaIngreso)";

                            using (SqlCommand cmdEmpleado = new SqlCommand(insertEmpleado, connection, transaction))
                            {
                                cmdEmpleado.Parameters.AddWithValue("@IdEncargado", admin.SystemId);
                                cmdEmpleado.Parameters.AddWithValue("@Identificacion", admin.Id);
                                cmdEmpleado.Parameters.AddWithValue("@FechaIngreso", admin.EntryDate);
                                cmdEmpleado.ExecuteNonQuery();
                            }

                            
                            transaction.Commit();
                            isSaved = true;
                        }
                        catch (Exception ex)
                        {
                            //Cancelar la transaccion en caso de error
                            transaction.Rollback();
                            Console.WriteLine("Error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return isSaved;
        }

        //verificar si existe un id de encargado
        public bool ExistsAdminId(int Id)
        {
            List<BranchAdmin> adminList = GetAdmins();
            return adminList.Any(admin => admin.SystemId == Id);
        }

        //obtener un objeto encargado por id
        public BranchAdmin searchAdmin(int Id)
        {
            List<BranchAdmin> adminList = GetAdmins();
            foreach (BranchAdmin admin in adminList)
            {
                if (admin.SystemId == Id)
                {
                    return admin;
                }
            }
            return null;
        }
        //obtener lista de encargados
        public List<BranchAdmin> GetAdmins()
        {
            List<BranchAdmin> adminList = new List<BranchAdmin>();
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            using (connection = new SqlConnection(ConnectionString))
            {
                string sentence = "SELECT IdEncargado, A.Identificacion, B.Nombre, B.PrimerApellido, B.SegundoApellido, B.FechaNacimiento, FechaIngreso " +
                             "FROM dbo.Encargado A " +
                             "INNER JOIN dbo.Persona B " +
                             "ON B.Identificacion = A.Identificacion";

                command.CommandType = CommandType.Text;
                command.CommandText = sentence;
                command.Connection = connection;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        adminList.Add(new BranchAdmin
                        {
                            SystemId = reader.GetInt32(0),
                            Id = reader.GetString(1),
                            Name = reader.GetString(2),
                            FirstLastName = reader.GetString(3),
                            SecondLastName = reader.GetString(4),
                            BirthDate = reader.GetDateTime(5),
                            EntryDate = reader.GetDateTime(6),
                        });
                    }
                }

            }
            return adminList;
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        /////Funciones para el menu de Clientes
        ////////////////
        //////////////////////////////////////////////////////////////////////////
        ///Insertar cliente en la DB
        public bool InsertCustomer(Customer customer)
        {
            bool isSaved = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Verificar si la persona ya existe
                            string checkPersona = "SELECT COUNT(*) FROM dbo.Persona WHERE Identificacion = @Identificacion";
                            using (SqlCommand cmdCheckPersona = new SqlCommand(checkPersona, connection, transaction))
                            {
                                cmdCheckPersona.Parameters.AddWithValue("@Identificacion", customer.Id);
                                int count = (int)cmdCheckPersona.ExecuteScalar();

                               
                                if (count == 0)
                                {
                                    string insertPersona = "INSERT INTO dbo.Persona (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento) " +
                                                           "VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento)";

                                    using (SqlCommand cmdPersona = new SqlCommand(insertPersona, connection, transaction))
                                    {
                                        cmdPersona.Parameters.AddWithValue("@Identificacion", customer.Id);
                                        cmdPersona.Parameters.AddWithValue("@Nombre", customer.Name);
                                        cmdPersona.Parameters.AddWithValue("@PrimerApellido", customer.FirstLastName);
                                        cmdPersona.Parameters.AddWithValue("@SegundoApellido", customer.SecondLastName);
                                        cmdPersona.Parameters.AddWithValue("@FechaNacimiento", customer.BirthDate);
                                        cmdPersona.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Insertar en la tabla Empleado
                            string insertEmpleado = "INSERT INTO dbo.Cliente (IdCliente, Identificacion, FechaRegistro, Activo) " +
                                                    "VALUES (@IdCliente, @Identificacion, @FechaRegistro, @Activo)";

                            using (SqlCommand cmdEmpleado = new SqlCommand(insertEmpleado, connection, transaction))
                            {
                                cmdEmpleado.Parameters.AddWithValue("@IdCliente", customer.SystemId);
                                cmdEmpleado.Parameters.AddWithValue("@Identificacion", customer.Id);
                                cmdEmpleado.Parameters.AddWithValue("@FechaRegistro", customer.EntryDate);
                                cmdEmpleado.Parameters.AddWithValue("@Activo", customer.Active);
                                cmdEmpleado.ExecuteNonQuery();
                            }

                            
                            transaction.Commit();
                            isSaved = true;
                        }
                        catch (Exception ex)
                        {
                            //cancelar la transaccion
                            transaction.Rollback();
                            Console.WriteLine("Error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return isSaved;
        }
        //verificar que exista el id cliente
        public bool ExistsCustomerId(int Id)
        {
            List<Customer> customerList = GetCustomers();
            return customerList.Any(customer => customer.SystemId == Id);
        }

        //obtener lista de clientes
        public List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            using (connection = new SqlConnection(ConnectionString))
            {
                string sentence = "SELECT IdCliente, A.Identificacion, B.Nombre, B.PrimerApellido, B.SegundoApellido, B.FechaNacimiento, FechaRegistro, Activo " +
                  "FROM dbo.Cliente A " +
                  "INNER JOIN dbo.Persona B ON B.Identificacion = A.Identificacion";

                command.CommandType = CommandType.Text;
                command.CommandText = sentence;
                command.Connection = connection;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        customerList.Add(new Customer
                        {
                            SystemId = reader.GetInt32(0),
                            Id = reader.GetString(1),
                            Name = reader.GetString(2),
                            FirstLastName = reader.GetString(3),
                            SecondLastName = reader.GetString(4),
                            BirthDate = reader.GetDateTime(5),
                            EntryDate = reader.GetDateTime(6),
                            Active = reader.GetBoolean(7)
                        });
                    }
                }

            }
            return customerList;
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        /////Funciones para el menu de Sucursales
        /////////////////////////
        /////////////////////////////////////////////////////////////////
        ///Insertar sucurcsal
        public bool InsertBranch(Branch branch)
        {
            bool isSaved = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Verificar si la sucursal ya existe
                            string checkBranch = "SELECT COUNT(*) FROM dbo.Sucursal WHERE IdSucursal = @IdSucursal";
                            using (SqlCommand cmdCheckBranch = new SqlCommand(checkBranch, connection, transaction))
                            {
                                cmdCheckBranch.Parameters.AddWithValue("@IdSucursal", branch.Id);
                                int count = (int)cmdCheckBranch.ExecuteScalar();

                             
                                if (count == 0)
                                {
                                    string insertBranch = "INSERT INTO dbo.Sucursal (IdSucursal, IdEncargado, Nombre, Direccion, Telefono, Activo) " +
                                                           "VALUES (@IdSucursal, @IdEncargado, @Nombre, @Direccion, @Telefono, @Activo)";

                                    using (SqlCommand cmd = new SqlCommand(insertBranch, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@IdSucursal", branch.Id);
                                        cmd.Parameters.AddWithValue("@IdEncargado", branch.Admin.SystemId);
                                        cmd.Parameters.AddWithValue("@Nombre", branch.Name);
                                        cmd.Parameters.AddWithValue("@Direccion", branch.Address);
                                        cmd.Parameters.AddWithValue("@Telefono", branch.PhoneNumber);
                                        cmd.Parameters.AddWithValue("@Activo", branch.Active);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                           
                            transaction.Commit();
                            isSaved = true;
                        }
                        catch (Exception ex)
                        {
                            // cancelar la transacción en caso de error
                            transaction.Rollback();
                            Console.WriteLine("Error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return isSaved;
        }
        //verificar si existe una sucursal por id
        public bool ExistsBranchId(int Id)
        {
            List<Branch> branchList = GetBranch();
            return branchList.Any(branch=> branch.Id == Id);
        }

        //obtener lista de sucursales
        public List<Branch> GetBranch()
        {
            List<Branch> branchList = new List<Branch>();
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            using (connection = new SqlConnection(ConnectionString))
            {
                string sentence = "SELECT A.IdSucursal, B.IdEncargado, B.Identificacion, C.Nombre, C.PrimerApellido, C.SegundoApellido, C.FechaNacimiento, B.FechaIngreso, A.Nombre, A.Direccion, A.Telefono, A.Activo " +
                  "FROM dbo.Sucursal A " +
                  "INNER JOIN dbo.Encargado B ON A.IdEncargado = B.IdEncargado " +
                  "INNER JOIN dbo.Persona C ON B.Identificacion = C.Identificacion";

                command.CommandType = CommandType.Text;
                command.CommandText = sentence;
                command.Connection = connection;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        branchList.Add(new Branch
                        {
                            Id  = reader.GetInt32(0),
                            Name = reader.GetString(8),
                            Admin = new BranchAdmin()
                            {
                                SystemId = reader.GetInt32(1),
                                Id = reader.GetString(2),
                                Name = reader.GetString(3),
                                FirstLastName = reader.GetString(4),
                                SecondLastName = reader.GetString(5),
                                BirthDate = reader.GetDateTime(6),
                                EntryDate = reader.GetDateTime(7),
                            },                           
                            Address = reader.GetString(9),
                            PhoneNumber = reader.GetString(10),
                            Active = reader.GetBoolean(11)
                         
                        }); 
                    }
                }

            }
            return branchList;
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        /////Funciones para el menu de Categorias
        ///////////////////////////////////////////////////////////////////////////////////////
        ////Insertar categorias en la DB
        public bool InsertCategory(Category category)
        {
            bool isSaved = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string checkCategory = "SELECT COUNT(*) FROM dbo.CategoriaPelicula WHERE IdCategoria = @IdCategoria";
                            using (SqlCommand cmdCheckCategory = new SqlCommand(checkCategory, connection, transaction))
                            {
                                cmdCheckCategory.Parameters.AddWithValue("@IdCategoria", category.Id);
                                int count = (int)cmdCheckCategory.ExecuteScalar();

                                if (count == 0)
                                {
                                    string insertCategory = "INSERT INTO dbo.CategoriaPelicula (IdCategoria, NombreCategoria, Descripcion) " +
                                                           "VALUES (@IdCategoria, @NombreCategoria, @Descripcion)";

                                    using (SqlCommand cmd = new SqlCommand(insertCategory, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@IdCategoria", category.Id);
                                        cmd.Parameters.AddWithValue("@NombreCategoria", category.Name);
                                        cmd.Parameters.AddWithValue("@Descripcion", category.Description);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                       
                            transaction.Commit();
                            isSaved = true;
                        }
                        catch (Exception ex)
                        {
                           
                            transaction.Rollback();
                            Console.WriteLine("Error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return isSaved;
        }

        //verificar si existe id de categoria
        public bool ExistsCategoryId(int Id)
        {
            List<Category> categoryList = GetCategory();
            return categoryList.Any(category => category.Id == Id);
        }

        //obtener lista de cateogria
        public List<Category> GetCategory()
        {
            List<Category> categoryList = new List<Category>();
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            using (connection = new SqlConnection(ConnectionString))
            {
                string sentence = "SELECT IdCategoria, NombreCategoria, Descripcion " +
                  "FROM dbo.CategoriaPelicula " ;

                command.CommandType = CommandType.Text;
                command.CommandText = sentence;
                command.Connection = connection;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categoryList.Add(new Category
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),  
                            Description = reader.GetString(2)

                        });
                    }
                }

            }
            return categoryList;
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        /////Funciones para el menu de Pelicula
        ///////////////////////////////////////////////////////////////////////////////////////
        ///Insertar pelicula
        public bool InsertMovie(Movie movie)
        {
            bool isSaved = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                     
                            string checkMovie = "SELECT COUNT(*) FROM dbo.Pelicula WHERE IdPelicula = @IdPelicula";
                            using (SqlCommand cmdCheckMovie = new SqlCommand(checkMovie, connection, transaction))
                            {
                                cmdCheckMovie.Parameters.AddWithValue("@IdPelicula", movie.Id);
                                int count = (int)cmdCheckMovie.ExecuteScalar();

                             
                                if (count == 0)
                                {
                                    string insertMovie = "INSERT INTO dbo.Pelicula (IdPelicula, IdCategoria, Titulo, AnioLanzamiento, Idioma) " +
                                                           "VALUES (@IdPelicula, @IdCategoria, @Titulo, @AnioLanzamiento, @Idioma)";

                                    using (SqlCommand cmd = new SqlCommand(insertMovie, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@IdPelicula", movie.Id);
                                        cmd.Parameters.AddWithValue("@IdCategoria", movie.Category.Id);
                                        cmd.Parameters.AddWithValue("@Titulo", movie.Name);
                                        cmd.Parameters.AddWithValue("@AnioLanzamiento", movie.ReleaseYear);
                                        cmd.Parameters.AddWithValue("@Idioma", movie.Language);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        
                            transaction.Commit();
                            isSaved = true;
                        }
                        catch (Exception ex)
                        {
                          
                            transaction.Rollback();
                            Console.WriteLine("Error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return isSaved;
        }


        //verificar si existe un id de pelicula
        public bool ExistsMovieId(int Id)
        {
            List<Movie> movieList = GetMovie();
            return movieList.Any(movie => movie.Id == Id);
        }

        //obtener lista de peliculas
        public List<Movie> GetMovie()
        {
            List<Movie> movieList = new List<Movie>();
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            using (connection = new SqlConnection(ConnectionString))
            {
                string sentence = "SELECT A.IdPelicula, A.Titulo, B.IdCategoria, B.NombreCategoria, B.Descripcion, A.AnioLanzamiento, A.Idioma " +
                  "FROM dbo.Pelicula A " +
                  "INNER JOIN dbo.CategoriaPelicula B ON A.IdCategoria = B.IdCategoria ";

                command.CommandType = CommandType.Text;
                command.CommandText = sentence;
                command.Connection = connection;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movieList.Add(new Movie
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Category = new Category()
                            {
                                Id = reader.GetInt32(2),
                                Name = reader.GetString(3),
                                Description = reader.GetString(4)
                            },
                            ReleaseYear = reader.GetInt32(5),
                            Language = reader.GetString(6),

                        });
                    }
                }

            }
            return movieList;
        }

        //obtener un objeto de categoria por id
        public Category searchCategory(int Id)
        {
            List<Category> categoryList = GetCategory();
            foreach (Category category in categoryList)
            {
                if (category.Id == Id)
                {
                    return category;
                }
            }
            return null;
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        /////Funciones para el menu de Pelicula x Sucursal
        ///////////////////////////////////////////////////////////////////////////////////////
        ///insertar asocie 
        public bool InsertAssociation(MovieByBranch movieByBranch)
        {
            bool isSaved = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                          
                            string insertMovie = "INSERT INTO dbo.PeliculaxSucursal (IdSucursal, IdPelicula,  Cantidad) " +
                                                 "VALUES (@IdSucursal, @IdPelicula, @Cantidad)";

                            using (SqlCommand cmd = new SqlCommand(insertMovie, connection, transaction))
                            {
                                 cmd.Parameters.AddWithValue("@IdSucursal", movieByBranch.Branch.Id);
                                 cmd.Parameters.AddWithValue("@IdPelicula", movieByBranch.Movie.Id);
                                 cmd.Parameters.AddWithValue("@Cantidad", movieByBranch.Quantity);
                                 cmd.ExecuteNonQuery();
                            }
                      
                           
                            transaction.Commit();
                            isSaved = true;



                        }
                        catch (Exception ex)
                        {
                        
                            transaction.Rollback();
                            Console.WriteLine("Error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return isSaved;
        }
        //verificar si existe asocie de peliculas y sucursales
        public bool ExistsAssociation(int IdMovie, int IdBranch)
        {
            List<MovieByBranch> assoList = GetAssociation();
            bool existMovie = false;
            bool existBranch = false;

            foreach (var movieByBranch in assoList)
            {
                if (movieByBranch.Branch.Id == IdBranch)
                {
                    existBranch = true;
                }
                if (movieByBranch.Movie.Id == IdMovie)
                {
                    existMovie = true;
                }
                if (existMovie && existBranch)
                {
                    return true;
                }
            }

            return false;
        }

        //obtener lista de peliculas por sucursal
        public List<MovieByBranch> GetAssociation()
        {
            List<MovieByBranch> associateList = new List<MovieByBranch>();
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            using (connection = new SqlConnection(ConnectionString))
            {
                string sentence = "SELECT A.Cantidad, A.IdSucursal, A.IdPelicula, B.Titulo, D.IdCategoria, D.NombreCategoria, D.Descripcion, B.AnioLanzamiento, B.Idioma, C.Nombre, C.Direccion, C.Telefono, C.Activo, E.IdEncargado, E.Identificacion, E.FechaIngreso, F.Nombre, F.PrimerApellido, F.SegundoApellido, F.FechaNacimiento " +
                  "FROM dbo.PeliculaxSucursal A " +
                  "INNER JOIN dbo.Pelicula B ON A.IdPelicula = B.IdPelicula " +
                  "INNER JOIN dbo.Sucursal C ON C.IdSucursal = A.IdSucursal " +
                  "INNER JOIN dbo.CategoriaPelicula D ON D.IdCategoria = B.IdCategoria " +
                  "INNER JOIN dbo.Encargado E ON E.IdEncargado = C.IdEncargado " +
                  "INNER JOIN dbo.Persona F ON F.Identificacion = E.Identificacion ";

                command.CommandType = CommandType.Text;
                command.CommandText = sentence;
                command.Connection = connection;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        associateList.Add(new MovieByBranch
                        {
                            Quantity = reader.GetInt32(0),

                            Movie = new Movie()
                            {
                                Id = reader.GetInt32(2),
                                Name = reader.GetString(3),
                                ReleaseYear = reader.GetInt32(7),
                                Language = reader.GetString(8),
                                Category = new Category()
                                {
                                    Id = reader.GetInt32(4),
                                    Name = reader.GetString(5),
                                    Description = reader.GetString(6),
                                }
                            },
                            Branch = new Branch()
                            {
                                Id = reader.GetInt32(1),
                                Name = reader.GetString(9),
                                Address = reader.GetString(10),
                                PhoneNumber = reader.GetString(11),
                                Active = reader.GetBoolean(12),
                                Admin = new BranchAdmin()
                                {
                                    SystemId = reader.GetInt32(13),
                                    Id = reader.GetString(14),
                                    Name = reader.GetString(16),
                                    FirstLastName = reader.GetString(17),
                                    SecondLastName = reader.GetString(18),
                                    BirthDate = reader.GetDateTime(19),
                                    EntryDate = reader.GetDateTime(15)
                                }

                            }
                        });
                    }
                }

            }
            return associateList;
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        /////Funciones para el menu de Prestamo
        ///////////////////////////////////////////////////////////////////////////////////////
        ///Insertar prestamo en la DB
        public bool InsertLoan(Loan loan)
        {
            bool isSaved = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                         
                             string insertCategory = "INSERT INTO dbo.Prestamo (IdCliente, IdSucursal, IdPelicula, FechaPrestamo, PendienteDevolucion) " +
                                                     "VALUES (@IdCliente, @IdSucursal, @IdPelicula, @FechaPrestamo, @PendienteDevolucion)";

                              using (SqlCommand cmd = new SqlCommand(insertCategory, connection, transaction))
                              {
                                  cmd.Parameters.AddWithValue("@IdCliente", loan.CustomerId);
                                  cmd.Parameters.AddWithValue("@IdSucursal", loan.BranchId);
                                  cmd.Parameters.AddWithValue("@IdPelicula", loan.MovieId);
                                  cmd.Parameters.AddWithValue("@FechaPrestamo", loan.Date);
                                  cmd.Parameters.AddWithValue("@PendienteDevolucion", loan.Pending);
                                  cmd.ExecuteNonQuery();
                              }
                            
                     
                            transaction.Commit();
                            isSaved = true;
                        }
                        catch (Exception ex)
                        {
                         
                            transaction.Rollback();
                            Console.WriteLine("Error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return isSaved;
        }
        //obtener lista de prestamos
        public List<Loan> GetLoan()
        {
            List<Loan> loanList = new List<Loan>();
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            using (connection = new SqlConnection(ConnectionString))
            {
                string sentence = "SELECT IdPrestamo, IdCliente, IdSucursal, IdPelicula, FechaPrestamo, PendienteDevolucion " +
                  "FROM dbo.Prestamo ";

                command.CommandType = CommandType.Text;
                command.CommandText = sentence;
                command.Connection = connection;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        loanList.Add(new Loan
                        {
                            LoanId = reader.GetInt32(0),
                            CustomerId = reader.GetInt32(1),
                            BranchId = reader.GetInt32(2),
                            MovieId = reader.GetInt32(3),
                            Date = reader.GetDateTime(4),
                            Pending = reader.GetBoolean(5)
                        });
                    }
                }

            }
            return loanList;
        }
        //filtrar lista por cliente
        public List<Loan> GetFiltered(Customer customer)
        {
            List<Loan> loanList = GetLoan();
            List<Loan> filteredList = new List<Loan>();
            foreach (var loan in loanList)
            {
                if (loan.CustomerId == customer.SystemId)
                {
                    filteredList.Add(loan);
                }
            }

            return filteredList;
        }
        //verificar si existe un prestamo activo
        public bool ExistsLoan(int IdMovie, int IdCustomer)
        {
            List<Loan> loanList = GetLoan();
           

            foreach (var loan in loanList)
            {
                if (loan.MovieId == IdMovie && loan.CustomerId == IdCustomer)
                {
                    if (loan.Pending == true)
                    {
                        return true;
                    }
                }
 
            }

            return false;
        }
     
        ///////////////////////////
        ////////////////////////////
        ////Metodos de Pelicula por Sucursal manipulados por los prestamos
        ////////////////////
        //actualizar la cantidad de peliculas disponible en una sucursal
        public void UpdateQty(MovieByBranch movieByBranch)
        {
            int movieId = movieByBranch.Movie.Id;
            int branchId = movieByBranch.Branch.Id;
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            try
            {
                
                using (connection = new SqlConnection(ConnectionString))
                {
                    string sentence = @"UPDATE PeliculaxSucursal
                                   SET Cantidad = Cantidad - 1
                                   WHERE IdSucursal = @branchId AND IdPelicula = @movieId AND Cantidad > 0";

                    command.CommandType = CommandType.Text;
                    command.CommandText = sentence;
                    command.Connection = connection;

                    // Agregar parámetros para evitar inyección SQL
                    command.Parameters.AddWithValue("@branchId", branchId);
                    command.Parameters.AddWithValue("@movieId", movieId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Cantidad actualizada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo actualizar la cantidad. Verifica si existen registros coincidentes con IdSucursal y IdPelicula.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                
            }

        }
        //validar que la cantidad disponible no sea 0
        public bool validateQuantity(MovieByBranch movieByBranch)
        {
            List<MovieByBranch> associateList = GetAssociation();
            try
            {
                foreach (var associate in associateList)
                {
                    if (associate.Movie.Id == movieByBranch.Movie.Id && associate.Branch.Id == movieByBranch.Branch.Id)
                    {
                        if (associate.Quantity > 0)
                        {
                            return true;
                        }

                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }


    }
}
