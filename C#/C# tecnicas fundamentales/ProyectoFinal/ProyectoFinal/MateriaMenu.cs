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
    public partial class MateriaMenu : Form
    {
        public MateriaMenu()
        {
            InitializeComponent();
        }

        private void materiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estudiante2DataSet);

        }

        private void MateriaMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.estudiante2DataSet.Materia);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           string hola = "";
           hola = prueba(codigo_TextBox.Text);
            if (materiaTextBox.Text ==  "" || codigo_TextBox.Text == "" || profesorTextBox.Text == "")
            {
                MessageBox.Show("No pueden existir campos vacios ", "Error", MessageBoxButtons.OKCancel);

            }
            else if (hola.CompareTo(codigo_TextBox.Text) == 1)
            {
                MessageBox.Show("Ya existe este codigo favor de usar otro", "Error", MessageBoxButtons.OKCancel);
                codigo_TextBox.Clear();
            }
            else 
            {
                materia a = new materia()
                {
                    asignatura = materiaTextBox.Text,
                    codigo = codigo_TextBox.Text,
                    credito = Convert.ToInt32(creditoTextBox.Text),
                    profesor = profesorTextBox.Text,

                };
                materiaTableAdapter.InsertQuery(a.asignatura, a.codigo, a.profesor, a.credito);
                materiaTableAdapter.Fill(estudiante2DataSet.Materia);
                // parte en sql comandos
                string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";
                SqlConnection con = new SqlConnection(conexion);
                string query = "insert into Materia(materia, codigo, profesor, credito) values(@id, @nombre, @promedio, @promedioletra)";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", a.asignatura);
                cmd.Parameters.AddWithValue("@nombre", a.codigo);
                cmd.Parameters.AddWithValue("@promedio", a.profesor);
                cmd.Parameters.AddWithValue("@promedioletra", a.credito);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La materia se agrego correctamente", "Success", MessageBoxButtons.OKCancel);
                materiaTextBox.Clear();
                codigo_TextBox.Clear();
                profesorTextBox.Clear();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar a = new Agregar();
            a.Show();
            this.Close();
        }

        public string prueba(string x)
        {
            string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
            string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";
            string y;
            string z = "";
            SqlConnection con = new SqlConnection(conexion);
            string query2 = "select codigo  from Materia where [codigo ] = '" + x + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query2, con);
            SqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read() == true)
            {
                y = leer["codigo"].ToString();
                con.Close();
                return y;
            }
            else
            {
                con.Close();
                return z;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            materiaTextBox.Clear();
            codigo_TextBox.Clear();
            profesorTextBox.Clear();
            Form1 a = new Form1();
            a.Show();
            this.Close();
           
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarMaterias a = new ListarMaterias();
            a.Show();
            this.Close();
        }

        private void notaEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudianteMateria a = new EstudianteMateria();
            a.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar a = new Listar();
            a.Show();
            this.Close();
        }
    }
}
