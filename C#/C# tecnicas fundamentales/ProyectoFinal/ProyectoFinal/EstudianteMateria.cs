using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class EstudianteMateria : Form
    {
        public EstudianteMateria()
        {
            InitializeComponent();
        }

        public static int global;
    
        private void EstudianteMateria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Estudiante4' table. You can move, or remove it, as needed.
            this.estudiante4TableAdapter.Fill(this.estudiante2DataSet.Estudiante4);
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.estudiante2DataSet.Materia);
            // TODO: This line of code loads data into the 'estudiante2DataSet.Estudiante3' table. You can move, or remove it, as needed.
            this.estudiante3TableAdapter.Fill(this.estudiante2DataSet.Estudiante3);
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia2' table. You can move, or remove it, as needed.
            this.materia2TableAdapter.Fill(this.estudiante2DataSet.Materia2);
            global = counter(global);
        }


        public bool validarTexto(string texto)
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

        private void notaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (validarTexto(notaTextBox.Text) == true)
            {
                if(notaTextBox.Text == "")
                {
                    
                }
                else
                MessageBox.Show("El id tiene que contener solo numeros", "Error", MessageBoxButtons.OKCancel);
                 notaTextBox.Clear();
            }
            else
            {
                

                if (notaTextBox.Text == "")
                {

                }
                else
                {
                    int numero = Convert.ToInt32(notaTextBox.Text);
                    if (numero < 60)
                    {
                        letraTextBox.Text = "F";
                    }
                    if (numero < 70 & numero > 59)
                    {
                        letraTextBox.Text = "D";
                    }
                    if (numero >= 70 & numero < 75)
                    {
                        letraTextBox.Text = "C";
                    }
                    if (numero >= 75 & numero < 80)
                    {
                        letraTextBox.Text = "C+";
                    }
                    if (numero >= 80 & numero < 85)
                    {
                        letraTextBox.Text = "B";
                    }
                    if (numero >= 85 & numero < 90)
                    {
                        letraTextBox.Text = "B+";
                    }
                    if (numero >= 90 & numero < 101)
                    {
                        letraTextBox.Text = "A";
                    }
                    if (numero >= 101)
                    {
                        letraTextBox.Text = "ERROR";
                        letraTextBox.Clear();
                    }
                }
            }
        }

   
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            global = global + 1;
            Estudiante a = new Estudiante
            {
                EstudianteGE = global,
                EstudianteMateria = materiaComboBox.Text,
                EstudianteCodigo = busqueda(materiaComboBox.Text),
                EstudianteCredito = Convert.ToInt32(creditoComboBox.Text),
                EstudianteId = idbuscado(nombreCompletoComboBox.Text),
                EstudianteNombre = nombreCompletoComboBox.Text,
                EstudianteNota = Convert.ToInt32(notaTextBox.Text),
                EstudianteLetra = letraTextBox.Text
            };
            bool verdad = true, mentira = true;
            string pase;
            string codigo2 = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
            string conexion2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo2 + "; Integrated Security = SSPI";
            SqlConnection con2 = new SqlConnection(conexion2);
            string query2 = "select NombreCompleto from Materia2 where materia = '" + a.EstudianteMateria + "'";
            con2.Open();
            SqlCommand cmda = new SqlCommand(query2, con2);
            SqlDataReader leer = cmda.ExecuteReader();

            if (leer.Read() == true)
            {
                verdad = false;
            }
            else
            {
                verdad = true;
            }

            if (notaTextBox.Text == "" || nombreCompletoComboBox.Text == "" || creditoComboBox.Text == "" || materiaComboBox.Text == "")
            {
                MessageBox.Show("No puede existir ningun campo vacio", " Error ", MessageBoxButtons.OKCancel);
                mentira = false;
            }
            else
            {
                mentira = true;
            }

            if (verdad == false)
            {
                MessageBox.Show("El estudiante ya existe en esta materia, Pruebe con otro", " Error ", MessageBoxButtons.OKCancel);

            }
            if ( verdad == true & mentira == true)
            {
                
             
                string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";
                SqlConnection con = new SqlConnection(conexion);
                string query = "insert into Materia2 (GE, materia, codigo, credito, Id, NombreCompleto, Nota, Letra) values(@ge, @materia, @codigo, @credito, @id, @nombre, @nota, @promedioletra)";
                con.Open();

              

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ge", a.EstudianteGE);
                cmd.Parameters.AddWithValue("@materia", a.EstudianteMateria);
                cmd.Parameters.AddWithValue("@codigo", a.EstudianteCodigo);
                cmd.Parameters.AddWithValue("@credito", a.EstudianteCredito);
                cmd.Parameters.AddWithValue("@id", a.EstudianteId);
                cmd.Parameters.AddWithValue("@nombre", a.EstudianteNombre);
                cmd.Parameters.AddWithValue("@nota", a.EstudianteNota);
                cmd.Parameters.AddWithValue("@promedioletra", a.EstudianteLetra);
                cmd.ExecuteNonQuery();

                materia2TableAdapter.InsertQuery(a.EstudianteGE, a.EstudianteMateria, a.EstudianteCodigo, a.EstudianteCredito, a.EstudianteId, a.EstudianteNombre, a.EstudianteNota, a.EstudianteLetra);
                this.materia2TableAdapter.Fill(this.estudiante2DataSet.Materia2);
                MessageBox.Show("El estudiante ha sido creado. ", "Correcto", MessageBoxButtons.OKCancel);
                notaTextBox.Text = "";
                con.Close();
            }
            else
            {
                MessageBox.Show("Revise todos sus campos.", "Error", MessageBoxButtons.OKCancel);
                con2.Close();
            }
            
        }

        public int idbuscado (string x)
        {
            int y;
            string pase;
            string codigo2 = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
            string conexion2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo2 + "; Integrated Security = SSPI";
            SqlConnection con2 = new SqlConnection(conexion2);
            string query2 = "select Id from Estudiante4 where NombreCompleto = '" + x + "'";
            con2.Open();
            SqlCommand cmda = new SqlCommand(query2, con2);
            SqlDataReader leer = cmda.ExecuteReader();

            if (leer.Read() == true)
            {
                pase = leer["Id"].ToString();
                y = Convert.ToInt32(pase);
                con2.Close();
                return y;
            }
            else
            {
                con2.Close();
                MessageBox.Show("Seleccione un nombre valido", " Error", MessageBoxButtons.OKCancel);
                return y = 0;
                
            }
        }

        public string busqueda(string x)
        {
            string y;
            string codigo2 = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
            string conexion2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo2 + "; Integrated Security = SSPI";
            SqlConnection con2 = new SqlConnection(conexion2);
            string query2 = "select codigo from Materia where materia = '" + x + "'";
            con2.Open();
            SqlCommand cmda = new SqlCommand(query2, con2);
            SqlDataReader leer = cmda.ExecuteReader();

            if (leer.Read() == true)
            {
                y = leer["codigo"].ToString();
                con2.Close();
                return y;
            }
            else
            {
                return y = "Error";
            }

        }

        public static int counter(int x)
        {
            int value = x;
            string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
            string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";
            SqlConnection con = new SqlConnection(conexion);
            string query2 = "select Max(GE) from Materia2 ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query2, con);
            SqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read() == true)
            {
                string counter = leer[""].ToString();
                value = Convert.ToInt32(counter);
                con.Close();
                return value;
            }
            else
            {
                x = 0;
                con.Close();
                return x;
            }
           
        }

        

        private void crearEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar a = new Agregar();
            a.Show();
            this.Close();
        }

        private void listarEstudiantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Listar a = new Listar();
            a.Show();
            this.Close();
        }

        private void volverAMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEstudiante a = new MenuEstudiante();
            a.Show();
            this.Close();
        }

        private void agregarMateriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MateriaMenu a = new MateriaMenu();
            a.Show();
            this.Close();
        }

        private void listarMateriaToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void listarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarMaterias a = new ListarMaterias();
            a.Show();
            this.Close();
        }

    
    }
}
