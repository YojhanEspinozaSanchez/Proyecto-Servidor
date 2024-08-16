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
    public partial class InsertMovie : Form
    {
        public InsertMovie()
        {
            InitializeComponent();
            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Abrir en el centro del escritorio
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void clearInputs()//limpia los imputs
        {
            this.MovieIdBox.Clear();
            this.NameBox.Clear();
            this.CategoryIdBox.Clear();
            this.YearBox.Clear();
            this.LanguageBox.Clear();
        }

        private bool validateInputs()//valida los formatos ingresados en los inputs
        {
            if (string.IsNullOrWhiteSpace(MovieIdBox.Text))//Validaciones de text box en blanco
            {
                MessageBox.Show("Ingrese el ID de la Pelicula!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(CategoryIdBox.Text))
            {
                MessageBox.Show("Ingrese el ID de la Categoria!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Ingrese el Nombre de la Sucursal!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(YearBox.Text))
            {
                MessageBox.Show("Ingrese el Año de Lanzamiento!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(LanguageBox.Text))
            {
                MessageBox.Show("Ingrese el Lenguage de la Pelicula!");
                return false;
            }

            return true;
        }

        private void BackGrounPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        Movie movie;
        Category category;
        MovieBL movieBL = new MovieBL();
        CategoryBL categoryBL = new CategoryBL();

        private Movie captureData()//Captura los datos de los inputs y los almacena en el objeto de la clase
        {
            try
            {
                int movieId = int.Parse(MovieIdBox.Text);
                int categoryId = int.Parse(CategoryIdBox.Text);
                string name = NameBox.Text;
                int release = int.Parse(YearBox.Text);
                string language = LanguageBox.Text;


                if (movieBL.existId(movieId) != true)//invoca la funcion para verificar si existe el id
                {
                    category = categoryBL.SearchCategory(categoryId);
                    if (category != null)
                    {
                        movie = new Movie(movieId, name, category, release, language);
                    }
                    else
                    {
                        MessageBox.Show("No Existe una Categoria con Este ID");
                    }

                    return movie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return null;
        }
        
        private void saveData(Movie movie)//recibe el objeto capturado  y lo guarda
        {
            try
            {
                if (movie != null)
                {
                    movieBL.insertMovie(movie);

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
        //cargar la tabla de peliculas
        private void DisplayMovie()
        {
            List<Movie> movieList = movieBL.GetMovie();

            dataGridView.Rows.Clear();

            if (movieList != null && movieList.Count > 0)
            {
                foreach (var movie in movieList)
                {
                    int rowIndex = dataGridView.Rows.Add();

                    dataGridView.Rows[rowIndex].Cells["MovieId"].Value = movie.Id;
                    dataGridView.Rows[rowIndex].Cells["MovieName"].Value = movie.Name;
                    dataGridView.Rows[rowIndex].Cells["CategoryId"].Value = movie.Category.Id;
                    dataGridView.Rows[rowIndex].Cells["MovieCategory"].Value = movie.Category.Name;
                    dataGridView.Rows[rowIndex].Cells["Description"].Value = movie.Category.Description;
                    dataGridView.Rows[rowIndex].Cells["ReleaseYear"].Value = movie.ReleaseYear;
                    dataGridView.Rows[rowIndex].Cells["MovieLanguage"].Value = movie.Language;

                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //  DataGridView.Visible = true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                saveData(captureData());
                DisplayMovie();
                clearInputs();
            }
        }

        private void DsiplayButton_Click(object sender, EventArgs e)
        {
            DisplayMovie();
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MovieIdBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= 4 && !char.IsControl(e.KeyChar))
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
