using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProyectoFinal
{
    public partial class EstudianteLogin : Form
    {
        public string hola { get; set; }

        
        public EstudianteLogin(string x)
        {
            hola = x;
            InitializeComponent();
        }

        private void EstudianteLogin_Load(object sender, EventArgs e)
        {
            textBox1.Text = hola;
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia2' table. You can move, or remove it, as needed.
            this.materia2TableAdapter.Fill(this.estudiante2DataSet.Materia2);

            string pase, carrera;
            int suma, contador, promedio, credito;
            //double puntuacion;
            string codigo2 = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
            string conexion2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo2 + "; Integrated Security = SSPI";
            SqlConnection con2 = new SqlConnection(conexion2);
            SqlConnection con3 = new SqlConnection(conexion2);
            SqlConnection con4 = new SqlConnection(conexion2);
            SqlConnection con5 = new SqlConnection(conexion2);
            string query2 = "select SUM(Nota) from Materia2 where NombreCompleto = '" + hola + "'";
            string query3 = "select count(Id) from Materia2 where NombreCompleto = '" + hola + "'";
            string query4 = "select SUM(credito) from Materia2 where NombreCompleto = '" + hola + "'";
            string query5 = "select Carrera from Estudiante4 where NombreCompleto = '" + hola + "'";
            con2.Open();
            con3.Open();
            con4.Open();
            con5.Open();
            SqlCommand cmda = new SqlCommand(query2, con2);
            SqlCommand cmd = new SqlCommand(query3, con3);
            SqlCommand cmd1 = new SqlCommand(query4, con4);
            SqlCommand cmd2 = new SqlCommand(query5, con5);
            SqlDataReader leer = cmda.ExecuteReader();
            SqlDataReader leer2 = cmd.ExecuteReader();
            SqlDataReader leer3 = cmd1.ExecuteReader();
            SqlDataReader leer4 = cmd2.ExecuteReader();
            if (leer.Read() == true && leer2.Read() == true && leer3.Read() == true && leer4.Read() == true) 
            {
                pase = leer[""].ToString();
                suma = Convert.ToInt32(pase);
                pase = leer2[""].ToString();
                contador = Convert.ToInt32(pase);
                pase = leer3[""].ToString();
                credito = Convert.ToInt32(pase);
                promedio = suma / contador;
                carrera = leer4["Carrera"].ToString();

                maskedTextBox3.Text = "" + contador;
                maskedTextBox2.Text = "" + credito;
                textBox3.Text = carrera;
                if (promedio > 89)
                {
                    maskedTextBox1.Text = "A";
                    maskedTextBox4.Text = "" + 4;
                    textBox2.Text = "Summa Cum Laude";
                }
                else if (promedio > 84 && promedio < 90)
                {
                    maskedTextBox1.Text = "B+";
                    maskedTextBox4.Text = "" + 3.5;
                    textBox2.Text = "Magna Cum Laude";
                }
                else if (promedio > 79 && promedio < 85)
                {
                    maskedTextBox1.Text = "B";
                    maskedTextBox4.Text = "" + 3;
                    textBox2.Text = "Cum Laude";
                }
                else if (promedio > 74 && promedio < 80)
                {
                    maskedTextBox1.Text = "C+";
                    maskedTextBox4.Text = "" + 2.5;
                }
                else if (promedio > 69 && promedio < 75)
                {
                    maskedTextBox1.Text = "C";
                    maskedTextBox4.Text = "" + 2;
                }
                else if (promedio > 59 && promedio < 70)
                {
                    maskedTextBox1.Text = "D";
                    maskedTextBox4.Text = "" + 1;

                }
                else if ( promedio < 60)
                {
                    maskedTextBox1.Text = "F";
                    maskedTextBox4.Text = "" + 0;

                }

               // puntuacion = (credito * Convert.ToInt32(maskedTextBox1.Text));
                
                //if (puntuacion > )
                

                /*
                 * Summa Cum Laude      3.8 a 4.0

                   Magna  Cum Laude     3.5 a 3.7

                   Cum Laude     3.2 a 3.4
                 * */
            }
            else
            {
                suma = 0;
                contador = 0;
                promedio = 0;
            }
            con2.Close();
            con3.Close();
            con4.Close();
            con5.Close();
        }

        private void materia2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materia2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estudiante2DataSet);

        }

      

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE", "Services" +
                "", MessageBoxButtons.OKCancel);
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            historial a = new historial(hola);
            a.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            historial a = new historial(hola);
            a.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            historial a = new historial(hola);
            a.Show();
            this.Close();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ModificarUsuario a = new ModificarUsuario(hola);
            a.Show();
            this.Close();
        }

        private void ajusteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuario a = new ModificarUsuario(textBox1.Text);
            a.Show();
            this.Close();
        }
    }
}
