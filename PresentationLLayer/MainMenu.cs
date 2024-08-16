using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLLayer
{
    public partial class MainMenu : Form
    {

        private Thread serverThread;
        private Server server;
        private bool isConnected = false;
        public MainMenu()
        {
            InitializeComponent();
            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Abrir en el centro del escritorio
            this.StartPosition = FormStartPosition.CenterScreen;
           
            RedLight.Visible = true;
            server = new Server("127.0.0.1", 15500); // Inicialización del servidor con IP y puerto
        }

        


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        //boton para registrar encargado
        private void RegisterAdminButton_Click(object sender, EventArgs e)
        {
            InsertAdmin window = new InsertAdmin();
            window.Show();
        }
        //boton para iniciar el servidor
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                InitializeServer();
            }
            
        }
        //iniciar servidor
        private void InitializeServer()
        {
            try
            {
                serverThread = new Thread(server.Start);
                serverThread.Start();
                server.LogEvent = LogEvent;
                RedLight.Visible = false;
                GreenLigth.Visible = true;
                isConnected = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        
        }
        //obtener e imprimr los logs de la aplicacion
        public void LogEvent(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(LogEvent), message);
            }
            else
            {
                listBoxLog.Items.Add($"{DateTime.Now}: {message}");
                listBoxLog.TopIndex = listBoxLog.Items.Count - 1; // Scroll al final
            }
        }
        //boton para detener servidor
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                DisconnectServer();
            }
        }
        //desconectar servidor
        private void DisconnectServer()
        {
            try
            {
                server.Stop();
                serverThread?.Join();
                RedLight.Visible = true;
                GreenLigth.Visible = false;
                isConnected = false;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
           
        }

        private void OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        //boton para salir
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                DisconnectServer();
                this.Close();
            }
            else
            {
                this.Close();
            }
           
        }
        //boton para registrar cliente
        private void RegisterCustomerButton_Click(object sender, EventArgs e)
        {
            InsertCustomer window = new InsertCustomer();
            window.Show();
        }
        //boton para registrar sucursal
        private void RegisterBranchButton_Click(object sender, EventArgs e)
        {
            AddBranch window = new AddBranch();
            window.Show();
        }
        //boton para registrar categoria
        private void RegisterCategoryButton_Click(object sender, EventArgs e)
        {
            InsertCategory window = new InsertCategory();
            window.Show();
        }
        //boton para registrar pelicula
        private void RegisterMovieButton_Click(object sender, EventArgs e)
        {
            InsertMovie window = new InsertMovie();
            window.Show();
        }
        //boton para asociar
        private void AssociateButton_Click(object sender, EventArgs e)
        {
            InsertMovieByBranch window = new InsertMovieByBranch();
            window.Show();
        }

        private void ServerControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterAdminButton_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
