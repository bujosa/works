using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{


    public partial class Agregar : Form
    {

        public Agregar()
        {
            InitializeComponent();
        }


        public static bool validarTexto(string texto)
        {
            foreach (char c in texto)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void volverAMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
            textBox1.Clear();
            idTextBox.Clear();
            passwordTextBox.Clear();
            nombreCompletoTextBox.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (validarTexto(idTextBox.Text) == true)
            {
                MessageBox.Show("El id tiene que contener solo numeros", "Error", MessageBoxButtons.OKCancel);
                idTextBox.Clear();
            }
            else
            {
                int id2 = Convert.ToInt32(idTextBox.Text);
                string codigo2 = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                string conexion2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo2 + "; Integrated Security = SSPI";
                SqlConnection con2 = new SqlConnection(conexion2);
                string query2 = "select Id from Estudiante4 where Id = " + id2;
                con2.Open();
                SqlCommand cmda = new SqlCommand(query2, con2);
                SqlDataReader leer = cmda.ExecuteReader();

                if (leer.Read() == true)
                {
                    MessageBox.Show("El Id ya existe, cree otro.", "Error", MessageBoxButtons.OKCancel);
                    con2.Close();
                    idTextBox.Clear();
                }
                else if (Convert.ToInt32(idTextBox.Text) < 1000000 || Convert.ToInt32(idTextBox.Text) > 9999999)
                {
                    MessageBox.Show("El id Tiene que tener solo 7 digitos.", "Error", MessageBoxButtons.OKCancel);
                    
                    idTextBox.Clear();
                }
                else if (idTextBox.Text == "" || passwordTextBox.Text == "" || nombreCompletoTextBox.Text == "" || carreraComboBox.Text == "")
                {
                    MessageBox.Show("No puede a ver ningun campo vacio. ", "Error", MessageBoxButtons.OKCancel);

                }
                else if (textBox1.Text.CompareTo(passwordTextBox.Text) == 1)
                {
                    MessageBox.Show("La Contraseña tiene que se la misma. ", "Error", MessageBoxButtons.OKCancel);
                    textBox1.Clear();
                    passwordTextBox.Clear();
                }
                else
                {

                    int id = Convert.ToInt32(idTextBox.Text);
                    string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                    string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";
                    SqlConnection con = new SqlConnection(conexion);
                    string query = "insert into Estudiante4 (Id, NombreCompleto, Carrera, Password) values(@id, @nombre, @carrera, @promedio)";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombreCompletoTextBox.Text);
                    cmd.Parameters.AddWithValue("@promedio", passwordTextBox.Text);
                    cmd.Parameters.AddWithValue("@carrera", carreraComboBox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    usuario a = new usuario()
                    {
                        id = id,
                        nombre = nombreCompletoTextBox.Text,
                        carrera = carreraComboBox.Text,
                        password = passwordTextBox.Text
                    };
                    estudiante4TableAdapter.InsertQuery(a.id, a.nombre, a.carrera, a.password );
                    estudiante4TableAdapter.Fill(this.estudiante2DataSet.Estudiante4);
                    MessageBox.Show("El estudiantre ha sido agregado sastifactoriamente");
                    textBox1.Clear();
                    passwordTextBox.Clear();
                    nombreCompletoTextBox.Clear();
                    idTextBox.Clear();
                    con2.Close();
                }
            }
          
           
            
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            passwordTextBox.Clear();
            nombreCompletoTextBox.Clear();
            idTextBox.Clear();

            Form1 a = new Form1();
            a.Show();
            this.Close();
         
        }


        private void Agregar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Estudiante4' table. You can move, or remove it, as needed.
            this.estudiante4TableAdapter.Fill(this.estudiante2DataSet.Estudiante4);
            // TODO: This line of code loads data into the 'estudiante2DataSet.Estudiante3' table. You can move, or remove it, as needed.
            this.estudiante3TableAdapter.Fill(this.estudiante2DataSet.Estudiante3);
        }


    
        
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriaMenu a = new MateriaMenu();
            a.Show();
            this.Close();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListarMaterias a = new ListarMaterias();
            a.Show();
            this.Close();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE", "Services" +
              "", MessageBoxButtons.OKCancel);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }
    }   
}
