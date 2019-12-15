using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProyectoFinal
{
    public partial class ModificarUsuario : Form
    {
        public string y;
        public ModificarUsuario(string x)
        {
            y = x;
            InitializeComponent();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Estudiante4' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'estudiante2DataSet.Estudiante3' table. You can move, or remove it, as needed.
            this.estudiante4TableAdapter.FillBy(this.estudiante2DataSet.Estudiante4, y );

            string codigo2 = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
            string conexion2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo2 + "; Integrated Security = SSPI";
            string query2 = "SELECT Id, NombreCompleto, Carrera, Password FROM Estudiante4 where NombreCompleto = '" + y + "'";

            SqlConnection con = new SqlConnection(conexion2);
            SqlCommand cmd = new SqlCommand(query2, con);
            con.Open();
            SqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read() == true)
            {
               nombreCompletoTextBox.Text = leer["NombreCompleto"].ToString();
                idTextBox.Text = leer["Id"].ToString();
                carreraComboBox.Text = leer["Carrera"].ToString();
            }
            con.Close();




        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EstudianteLogin a = new EstudianteLogin(y);
            a.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "" || textBox1.Text == "" || carreraComboBox.Text == "")
            {
                MessageBox.Show("No pueden existir campos vacios.", "Autentificacion", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (passwordTextBox.Text.CompareTo(textBox1.Text) == 0)
                {


                    int id = Convert.ToInt32(idTextBox.Text);
                    string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                    string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";

                    SqlConnection con = new SqlConnection(conexion);
                    string query = "update Estudiante4 set Id = @id, NombreCompleto = @nombre, Carrera = @carrera, Password = @password where NombreCompleto = '" + y + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombreCompletoTextBox.Text);
                    cmd.Parameters.AddWithValue("@carrera", carreraComboBox.Text);
                    cmd.Parameters.AddWithValue("password", passwordTextBox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    estudiante4TableAdapter.UpdateQuery(nombreCompletoTextBox.Text, carreraComboBox.Text, passwordTextBox.Text, id);
                    estudiante4TableAdapter.Fill(this.estudiante2DataSet.Estudiante4);
                    MessageBox.Show("El estudiantre ha sido Modificado sastifactoriamente", "Correcto", MessageBoxButtons.OKCancel);
                    EstudianteLogin a = new EstudianteLogin(y);
                    a.Show();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OKCancel);
                    passwordTextBox.Clear();
                    textBox1.Clear();

                }
            }
           
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudianteLogin a = new EstudianteLogin(y);
            a.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            historial a = new historial(y);
            a.Show();
            this.Close();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE", "Services" +
               "", MessageBoxButtons.OKCancel);
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }
    }
}
