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
    public partial class InsertAdmin : Form
    {
        public InsertAdmin()
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


        }

        private void SystemIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////
        BranchAdmin admin = null;
        AdminsBL adminsBL = new AdminsBL();

        private BranchAdmin captureData()//Captura los datos de los inputs y los almacena en el objeto de la clase
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




                if (adminsBL.existId(sysId) != true)//invoca la funcion para verificar si existe el id
                {
                    admin = new BranchAdmin(sysId, id, name, fLastname, sLastname, birthDate, entryDate);
                    return admin;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return null;

        }

        private void saveData(BranchAdmin branchAdmin)//recibe el objeto capturado  y lo guarda
        {
            try
            {
                if (branchAdmin != null)
                {
                    adminsBL.insertAdmin(branchAdmin);

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
        //actualiza la tabla de encargados
        private void DisplayAdministrators()
        {

            List<BranchAdmin> adminList = adminsBL.getAdmins();

            dataGridView.Rows.Clear();

            if (adminList != null && adminList.Count > 0)
            {
                foreach (var admin in adminList)
                {
                    int rowIndex = dataGridView.Rows.Add();

                    dataGridView.Rows[rowIndex].Cells["SystemId"].Value = admin.SystemId;
                    dataGridView.Rows[rowIndex].Cells["ID"].Value = admin.Id;
                    dataGridView.Rows[rowIndex].Cells["AdminName"].Value = admin.Name;
                    dataGridView.Rows[rowIndex].Cells["Flastname"].Value = admin.FirstLastName;
                    dataGridView.Rows[rowIndex].Cells["Slastname"].Value = admin.SecondLastName;
                    dataGridView.Rows[rowIndex].Cells["BirthDate"].Value = admin.BirthDate;
                    dataGridView.Rows[rowIndex].Cells["EntryDate"].Value = admin.EntryDate;
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //  DataGridView.Visible = true;
        }

        private bool validateInputs()//valida los formatos ingresados en los inputs
        {
            if (string.IsNullOrWhiteSpace(SystemIdBox.Text))
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //boton para invocar los metodos de registro
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                saveData(captureData());
                DisplayAdministrators();
                clearInputs();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //boton para cargar la tabla
        private void DsiplayButton_Click(object sender, EventArgs e)
        {
            DisplayAdministrators();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackGrounPanel_Paint(object sender, PaintEventArgs e)
        {

        }

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
        //Limitar y bloquear caracteres
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
