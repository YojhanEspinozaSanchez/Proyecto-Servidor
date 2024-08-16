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
//interfaz para registrar encargado
namespace PresentationLLayer
{
    public partial class AddBranch : Form
    {

        public AddBranch()
        {
            InitializeComponent();
            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Abrir en el centro del escritorio
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //limpiar entradas
        private void clearInputs()//limpia los imputs
        {
            this.BranchIdBox.Clear();
            this.AdminIdBox.Clear();
            this.NameBox.Clear();
            this.AddressBox.Clear();
            this.PhoneNumberBox.Clear();

            this.ActiveComboBox.SelectedItem = null;

        }

        private void SystemIdBox_TextChanged(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////////////////////////////////////
       //variables globales
        Branch branch;
        BranchAdmin admin;
        BranchBL branchBL = new BranchBL();
        AdminsBL adminsBL = new AdminsBL();


        //capturar datos de las entradas
        private Branch captureData()//Captura los datos de los inputs y los almacena en el objeto de la clase
        {
            try
            {
                int branchId = int.Parse(BranchIdBox.Text);
                int adminId = int.Parse(AdminIdBox.Text);
                string name = NameBox.Text;
                string address = AddressBox.Text;
                string phoneNumber = PhoneNumberBox.Text;

                string getActive = (string)ActiveComboBox.SelectedItem;

                if (branchBL.existId(branchId) != true)//invoca la funcion para verificar si existe el id
                {
                    admin = adminsBL.searchAdmin(adminId);
                    if (admin != null)
                    {
                        branch = new Branch(branchId, name, admin, address, phoneNumber, active(getActive));
                    }
                    else
                    {
                        MessageBox.Show("No Existe un Encargado con Este ID");
                    }

                    return branch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return null;
        }
        //guardar datos en la base
        private void saveData(Branch branch)//recibe el objeto capturado  y lo guarda
        {
            try
            {
                if (branch != null)
                {
                    branchBL.insertBranch(branch);

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
        //actualizar tabla de encargados
        private void DisplayBranch()
        {
            List<Branch> branchList = branchBL.GetBranch();

            dataGridView.Rows.Clear();

            if (branchList != null && branchList.Count > 0)
            {
                foreach (var branch in branchList)
                {
                    int rowIndex = dataGridView.Rows.Add();

                    dataGridView.Rows[rowIndex].Cells["IdBranch"].Value = branch.Id;
                    dataGridView.Rows[rowIndex].Cells["NameBranch"].Value = branch.Name;
                    dataGridView.Rows[rowIndex].Cells["IdAdmin"].Value = branch.Admin.SystemId;
                    dataGridView.Rows[rowIndex].Cells["NameAdmin"].Value = branch.Admin.Name;
                    dataGridView.Rows[rowIndex].Cells["bAddress"].Value = branch.Address;
                    dataGridView.Rows[rowIndex].Cells["bPhoneNumber"].Value = branch.PhoneNumber;
                    dataGridView.Rows[rowIndex].Cells["bActive"].Value = branch.Active;
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //  DataGridView.Visible = true;
        }
        
        private bool active(string getActive)//Esta funcion es para interpretar si la sucursal esta activa de acuerdo a la seleccion en la UI
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
        //validad formato de entradas
        private bool validateInputs()//valida los formatos ingresados en los inputs
        {
            if (string.IsNullOrWhiteSpace(BranchIdBox.Text))//Validaciones de text box en blanco
            {
                MessageBox.Show("Ingrese el ID de la Sucursal!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(AdminIdBox.Text))
            {
                MessageBox.Show("Ingrese el ID del Administrador!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Ingrese el Nombre de la Sucursal!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(AddressBox.Text))
            {
                MessageBox.Show("Ingrese la Direccion!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PhoneNumberBox.Text))
            {
                MessageBox.Show("Ingrese el Numero de Telefono!");
                return false;
            }

            if (ActiveComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el Estado de Activo");
                return false;
            }

            return true;
        }

        private void BackGrounPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        //boton de registrar
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                saveData(captureData());
                DisplayBranch();
                clearInputs();
            }
        }
        //boton para mostrar tabla
        private void DsiplayButton_Click(object sender, EventArgs e)
        {
            DisplayBranch();
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //limitar y bloquear caracteres
        private void BranchIdBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AdminIdBox_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
