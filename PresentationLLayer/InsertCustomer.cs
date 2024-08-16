using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;

namespace PresentationLLayer
{
    public partial class InsertCustomer : Form
    {
        public InsertCustomer()
        {
            InitializeComponent();
            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Abrir en el centro del escritorio
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void clearInputs()//limpia los imputs
        {
            this.SystemIdBox.Clear();
            this.IdentificationBox.Clear();
            this.NameBox.Clear();
            this.FlastnameBox.Clear();
            this.SlastnameBox.Clear();
            this.ActiveComboBox.SelectedItem = null;

        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        Customer customer;
        CustomersBL customersBL = new CustomersBL();

        private Customer captureData()//Captura los datos de los inputs y los almacena en el objeto de la clase
        {
            try
            {
                int sysId = int.Parse(SystemIdBox.Text);
                string id = IdentificationBox.Text;
                string name = NameBox.Text;
                string fLastname = FlastnameBox.Text;
                string sLastname = SlastnameBox.Text;
                DateTime birthDate = BirthTimePicker.Value.Date;
                DateTime entryDate = EntryTimePicker.Value.Date;
                string getActive = (string)ActiveComboBox.SelectedItem;




                if (customersBL.existId(sysId) != true)//invoca la funcion para verificar si existe el id
                {
                    customer = new Customer(sysId, id, name, fLastname, sLastname, birthDate, entryDate, active(getActive));
                    return customer;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return null;

        }

        private void saveData(Customer customer)//recibe el objeto capturado  y lo guarda
        {
            try
            {
                if (customer != null)
                {
                    customersBL.insertCustomer(customer);

                }
                else
                {
                    MessageBox.Show("Ya existe un registro con este ID!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //cargar tabla de clientes
        private void DisplayCustomers()
        {



            List<Customer> customerList = customersBL.GetCustomers();

            dataGridView.Rows.Clear();

            if (customerList != null && customerList.Count > 0)
            {
                foreach (var customer in customerList)
                {
                    int rowIndex = dataGridView.Rows.Add();

                    dataGridView.Rows[rowIndex].Cells["SystemId"].Value = customer.SystemId;
                    dataGridView.Rows[rowIndex].Cells["ID"].Value = customer.Id;
                    dataGridView.Rows[rowIndex].Cells["AdminName"].Value = customer.Name;
                    dataGridView.Rows[rowIndex].Cells["Flastname"].Value = customer.FirstLastName;
                    dataGridView.Rows[rowIndex].Cells["Slastname"].Value = customer.SecondLastName;
                    dataGridView.Rows[rowIndex].Cells["BirthDate"].Value = customer.BirthDate;
                    dataGridView.Rows[rowIndex].Cells["EntryDate"].Value = customer.EntryDate;
                    dataGridView.Rows[rowIndex].Cells["Active"].Value = customer.Active;
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //  DataGridView.Visible = true;
        }



        private bool active(string getActive)//Esta funcion es para interpretar si el cliente esta activo de acuerdo a la seleccion en la UI
        {
            if (getActive == "SI")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validateInputs()//valida los formatos ingresados en los inputs
        {
            if (string.IsNullOrWhiteSpace(SystemIdBox.Text))//Validaciones de text box en blanco
            {
                MessageBox.Show("Ingrese el ID en Sistema!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(IdentificationBox.Text))
            {
                MessageBox.Show("Ingrese la Identificacion!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Ingrese el Nombre!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(FlastnameBox.Text))
            {
                MessageBox.Show("Ingrese el Primer Apellido!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(SlastnameBox.Text))
            {
                MessageBox.Show("Ingrese el Segundo Apellido!");
                return false;
            }

            if (ActiveComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el Estado de Activo");
                return false;
            }

            /////////////////////////////////
            //Validar que la fecha de ingreso sea 18 años despues que la de nacimiento
            //Idea tomada de la guia de Microsoft: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings

            // Obtener las fechas seleccionadas
            DateTime birthDate = BirthTimePicker.Value;
            DateTime entryDate = EntryTimePicker.Value;

            // Calcular la diferencia de edad
            TimeSpan difference = entryDate - birthDate;//calcula los años y los convierte a texto
            int age = (int)(difference.TotalDays / 365.25); // Asumiendo un año de 365.25 días para considerar años bisiestos

            // Verificar si la edad es menor de 18 años
            if (age < 18)
            {
                MessageBox.Show("La Fecha de Ingreso debe ser 18 Annos Despues de la fecha de Nacimiento!");
                // Devolver el foco al DateTimePicker de entrada si es necesario
                EntryTimePicker.Focus();//Resalta el time picker en la interfaz
                return false;
            }


            if (IdentificationBox.Text.Length < 9)//valida el tamaño del string
            {
                MessageBox.Show("La Identificacion Debe Ser de 9 Digitos!");
                return false;
            }



            return true;
        }
        //boton para registrar
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                saveData(captureData());
                DisplayCustomers();
                clearInputs();
            }
        }
        //boton para cargar la tabla
        private void DsiplayButton_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackGrounPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        //bloqueo y limitacion de caracteres
        private void SystemIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= 6 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IdentificationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBox.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }
    }
   
}
