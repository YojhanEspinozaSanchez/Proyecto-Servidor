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
    public partial class InsertMovieByBranch : Form
    {
        public InsertMovieByBranch()
        {
            InitializeComponent();
            updateComboBox();
            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Abrir en el centro del escritorio
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        BranchBL branchBL = new BranchBL();
        MovieBL movieBL = new MovieBL();
        MovieByBranchBL movieByBranchBL = new MovieByBranchBL();
        private void updateComboBox()
        {
            try
            {
                // Limpiar el ComboBox
                BranchComboBox.Items.Clear();

                // Obtener las sucursales
                List<Branch> branchList = branchBL.GetBranch().Where(branch => branch.Active == true).ToList();

                // Asignar la lista filtrada al ComboBox
                BranchComboBox.DataSource = branchList;
                BranchComboBox.DisplayMember = "Name";
                BranchComboBox.ValueMember = "Id";

              
                BranchComboBox.SelectedIndexChanged += BranchComboBox_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }
        }


        private bool validateInputs()//valida los formatos ingresados en los inputs
        {
           

            if (BranchComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la Sucursal");
                return false;
            }

            if(dataGridViewMovie.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione la Pelicula");
                return false;
            }

            return true;
        }

        private void clearInputs()//limpia los imputs
        {
            this.BranchComboBox.SelectedItem = null;

            
        }
        //obtener la pelicula seleccionada
        private Movie GetSelectedMovie()
        {
            if (dataGridViewMovie.SelectedRows.Count > 0) 
            {
                DataGridViewRow row = dataGridViewMovie.SelectedRows[0]; // Obtiene la primera fila seleccionada
                Movie movie = new Movie
                {
                    Id = (int)row.Cells["MovieId"].Value,
                    Name = (string)row.Cells["MovieName"].Value,
                    Category = new Category
                    {
                        Id = (int)row.Cells["CategoryId"].Value,
                        Name = (string)row.Cells["MovieCategory"].Value,
                        Description = (string)row.Cells["Description"].Value
                    },
                    ReleaseYear = (int)row.Cells["ReleaseYear"].Value,
                    Language = (string)row.Cells["MovieLanguage"].Value
                };

                return movie;
            }

            return null; // Retorna null si no se seleccionó ninguna fila
        }

        //cargar tabla de peliculas
        private void DisplayMovie()
        {
            dataGridViewAssociate.Visible = false;
            List<Movie> movieList = movieBL.GetMovie();

            dataGridViewMovie.Rows.Clear();

            if (movieList != null && movieList.Count > 0)
            {
                foreach (var movie in movieList)
                {
                    int rowIndex = dataGridViewMovie.Rows.Add();

                    dataGridViewMovie.Rows[rowIndex].Cells["MovieId"].Value = movie.Id;
                    dataGridViewMovie.Rows[rowIndex].Cells["MovieName"].Value = movie.Name;
                    dataGridViewMovie.Rows[rowIndex].Cells["CategoryId"].Value = movie.Category.Id;
                    dataGridViewMovie.Rows[rowIndex].Cells["MovieCategory"].Value = movie.Category.Name;
                    dataGridViewMovie.Rows[rowIndex].Cells["Description"].Value = movie.Category.Description;
                    dataGridViewMovie.Rows[rowIndex].Cells["ReleaseYear"].Value = movie.ReleaseYear;
                    dataGridViewMovie.Rows[rowIndex].Cells["MovieLanguage"].Value = movie.Language;

                }
            }

            dataGridViewMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovie.Visible = true;
        }
        //cargar tablas de asocie
        private void DisplayAssociate() 
        {
            dataGridViewMovie.Visible = false;
            List<MovieByBranch> assoList = movieByBranchBL.GetAssociation();

            dataGridViewAssociate.Rows.Clear();

            if (assoList != null && assoList.Count > 0)
            {
                foreach (var movieByBranch in assoList)
                {
                    int rowIndex = dataGridViewAssociate.Rows.Add();
                    dataGridViewAssociate.Rows[rowIndex].Cells["Qty"].Value = movieByBranch.Quantity;
                    dataGridViewAssociate.Rows[rowIndex].Cells["IdMovie"].Value = movieByBranch.Movie.Id;
                    dataGridViewAssociate.Rows[rowIndex].Cells["NameMovie"].Value = movieByBranch.Movie.Name;
                    dataGridViewAssociate.Rows[rowIndex].Cells["IdCategory"].Value = movieByBranch.Movie.Category.Id;
                    dataGridViewAssociate.Rows[rowIndex].Cells["NameCategory"].Value = movieByBranch.Movie.Category.Name;
                    dataGridViewAssociate.Rows[rowIndex].Cells["DescriptionCategory"].Value = movieByBranch.Movie.Category.Description;
                    dataGridViewAssociate.Rows[rowIndex].Cells["MovieYear"].Value = movieByBranch.Movie.ReleaseYear;
                    dataGridViewAssociate.Rows[rowIndex].Cells["LanguageMovie"].Value = movieByBranch.Movie.Language;

                    dataGridViewAssociate.Rows[rowIndex].Cells["BranchId"].Value = movieByBranch.Branch.Id;
                    dataGridViewAssociate.Rows[rowIndex].Cells["NameBranch"].Value = movieByBranch.Branch.Name;
                    dataGridViewAssociate.Rows[rowIndex].Cells["AddressBranch"].Value = movieByBranch.Branch.Address;
                    dataGridViewAssociate.Rows[rowIndex].Cells["NumberBranch"].Value = movieByBranch.Branch.PhoneNumber;
                    dataGridViewAssociate.Rows[rowIndex].Cells["ActiveBranch"].Value = movieByBranch.Branch.Active;

                    dataGridViewAssociate.Rows[rowIndex].Cells["IdAdmin"].Value = movieByBranch.Branch.Admin.SystemId;
                    dataGridViewAssociate.Rows[rowIndex].Cells["IdentAdmin"].Value = movieByBranch.Branch.Admin.Id;
                    dataGridViewAssociate.Rows[rowIndex].Cells["NameAdmin"].Value = movieByBranch.Branch.Admin.Name;
                    dataGridViewAssociate.Rows[rowIndex].Cells["FlastName"].Value = movieByBranch.Branch.Admin.FirstLastName;
                    dataGridViewAssociate.Rows[rowIndex].Cells["SlastName"].Value = movieByBranch.Branch.Admin.SecondLastName;
                    dataGridViewAssociate.Rows[rowIndex].Cells["DateBirth"].Value = movieByBranch.Branch.Admin.BirthDate;
                    dataGridViewAssociate.Rows[rowIndex].Cells["DateEntry"].Value = movieByBranch.Branch.Admin.EntryDate;

                }
            }

           // dataGridViewAssociate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAssociate.Visible = true;

        }

        private MovieByBranch captureData()//Captura los datos de los inputs y los almacena en el objeto de la clase
        {
            try
            {
                Movie movie = GetSelectedMovie();
                Branch branch = BranchComboBox.SelectedItem as Branch;
                int Qty = int.Parse(QtyBox.Text);

                if (movieByBranchBL.existAssociation(movie.Id, branch.Id) != true)//invoca la funcion para verificar si existe el id
                {
                    
                    if (movie != null && branch != null)
                    {
                        MovieByBranch movieByBranch = new MovieByBranch(branch, movie, Qty);
                        return movieByBranch;
                    }
                    else
                    {
                        MessageBox.Show("Se Estan Recibiendo Objetos Nulos");
                        return null;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return null;
        }

        private void saveData(MovieByBranch movieByBranch)//recibe el objeto capturado  y lo guarda
        {
            try
            {
                if (movieByBranch != null)
                {
                    movieByBranchBL.insertAssociation(movieByBranch);

                }
                else
                {
                    MessageBox.Show("Ya Existe Esta Asociacion!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LanguageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackGrounPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //cargar tabla
        private void DsiplayAssoButton_Click(object sender, EventArgs e)
        {
            DisplayAssociate();
        }

        private void DisplayMoviesButton_Click(object sender, EventArgs e)
        {
            DisplayMovie();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                saveData(captureData());
                DisplayAssociate();
                clearInputs();
            }
        }

        private void QtyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }



          
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
