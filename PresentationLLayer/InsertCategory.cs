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
    public partial class InsertCategory : Form
    {
        public InsertCategory()
        {
            InitializeComponent();
            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Abrir en el centro del escritorio
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void clearInputs()//limpia los inputs
        {
            this.IdBox.Clear();
            this.NameBox.Clear();
            this.DescriptionBox.Clear();

        }

        private bool validateInputs()//valida los formatos ingresados en los inputs
        {
            if (string.IsNullOrWhiteSpace(IdBox.Text))//Validaciones de text box en blanco
            {
                MessageBox.Show("Ingrese el ID de la Categoria!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(DescriptionBox.Text))
            {
                MessageBox.Show("Ingrese la Descripcion!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Ingrese el Nombre de la Categoria!");
                return false;
            }

            return true;
        }



        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackGrounPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        Category category;
        CategoryBL categoryBL = new CategoryBL();

        private Category captureData()//Captura los datos de los inputs y los almacena en el objeto de la clase
        {
            try
            {
                int id = int.Parse(IdBox.Text);
                string name = NameBox.Text;
                string description = DescriptionBox.Text;


                if (categoryBL.existId(id) != true)//invoca la funcion para verificar si existe el id
                {
                    
                    category = new Category(id, name, description);
                    

                    return category;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return null;
        }

        private void saveData(Category category)//recibe el objeto capturado  y lo guarda
        {
            try
            {
                if (category != null)
                {
                    categoryBL.InsertCategory(category);

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
        //cargar la tabla de categorias
        private void DisplayCategory()
        {
            List<Category> categoryList = categoryBL.GetCategory();

            dataGridView.Rows.Clear();

            if (categoryList != null && categoryList.Count > 0)
            {
                foreach (var category in categoryList)
                {
                    int rowIndex = dataGridView.Rows.Add();

                    dataGridView.Rows[rowIndex].Cells["CategoryId"].Value = category.Id;
                    dataGridView.Rows[rowIndex].Cells["CategoryName"].Value = category.Name;
                    dataGridView.Rows[rowIndex].Cells["Description"].Value = category.Description;
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //  DataGridView.Visible = true;
        }
        //boton de registrar
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                saveData(captureData());
                DisplayCategory();
                clearInputs();
            }
        }
        //boton para cargar la tabla
        private void DsiplayButton_Click(object sender, EventArgs e)
        {
            DisplayCategory();
        }
        //Bloqueo y limitacion de caracteres
        private void IdBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
