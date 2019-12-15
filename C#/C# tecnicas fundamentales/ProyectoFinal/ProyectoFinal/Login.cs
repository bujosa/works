using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        string usuario = "ADMIN";
        string Contraseña = "12345";

        public Login()
        {
          
            InitializeComponent();
            
        }


        public int validarTexto(string texto)
        {
            foreach (char c in texto)
            {
                if (!Char.IsLetter(c))
                {
                    return 1;
                }
            }
            return 0;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

            string usuario2 = textBox1.Text.ToUpper();
            string contraseña2 = textBox2.Text.ToUpper();
            string pase2;
            int id;
            try
            {
                id = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                id = 0;
            }
            
            string pase;
            string codigo2 = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
            string conexion2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo2 + "; Integrated Security = SSPI";
            SqlConnection con2 = new SqlConnection(conexion2);
            string query2 = "select Password, NombreCompleto from Estudiante4 where Id = '" + id + "'";
            con2.Open();
            SqlCommand cmda = new SqlCommand(query2, con2);
            SqlDataReader leer = cmda.ExecuteReader();

            if (leer.Read() == true)
            {
                pase = leer["Password"].ToString();
                pase2 = leer["NombreCompleto"].ToString();

                con2.Close();
                if (pase.CompareTo(textBox2.Text) == 0)
                {
                    MessageBox.Show("Bievenid@ " + pase2 + " ", "Login", MessageBoxButtons.OKCancel);
                    EstudianteLogin a = new EstudianteLogin(pase2);
                    a.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("La contraseña o el usuario es incorrecto!!", "Error de inicio de Seccion", MessageBoxButtons.OKCancel);
                    textBox1.Clear();
                    label4.Visible = true;
                    radioButton1.Visible = false;
                    textBox2.Clear();
                }

            }

            else
            { 

            if (usuario2 == usuario && contraseña2 == Contraseña)
                {
                    MessageBox.Show("Bievenido Administrador ", "Login", MessageBoxButtons.OKCancel);
                    Form1 a = new Form1();
                    a.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("La contraseña o el usuario es incorrecto!!", "Error de inicio de Sesion", MessageBoxButtons.OKCancel);
                    textBox1.Clear();
                    textBox2.Clear();
                    label4.Visible = true;
                    radioButton1.Visible = false;
                }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesita Tener un usuario Administrador o usar el usuario Administrador", "Servicios", MessageBoxButtons.OKCancel);
            label4.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            textBox2.UseSystemPasswordChar = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
          
            textBox2.UseSystemPasswordChar = false;
            radioButton1.Visible = false;
            radioButton1.Checked = false;
            textBox2.Focus();
            
           
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesita Tener un usuario Administrador o usar el usuario Estudiante.\nPara usuarios tipo Estudiantes es necesario que el sistema te haya acreditado como un estudiante.\nSi es su primera vez usando esta aplicacion use el usuario:\n1. Usuario: id(7 digitos), password:(puesta en el sistema)\n2. Usuario: admin, password: 12345  ", "Servicios", MessageBoxButtons.OKCancel);
            
        }
    }
}
