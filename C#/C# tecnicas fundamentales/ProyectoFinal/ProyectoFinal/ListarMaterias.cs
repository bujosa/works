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
    public partial class ListarMaterias : Form
    {
        public ListarMaterias()
        {
            InitializeComponent();
        }

        private void materiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estudiante2DataSet);

        }

        private void ListarMaterias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.estudiante2DataSet.Materia);

        }

        

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriaMenu a = new MateriaMenu();
            a.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar a = new Agregar();
            a.Show();
            this.Close();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar a = new Listar();
            a.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            materiaTableAdapter.FillBy1(estudiante2DataSet.Materia, materiaComboBox.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.materiaTableAdapter.Fill(this.estudiante2DataSet.Materia);
            materiaComboBox.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (materiaComboBox.Text == "")
            {
                MessageBox.Show("Error ningun campo vacio puede a ver ");

            }
            else
            {

                string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";
                // TODO: This line of code loads data into the 'estudianteNotasDataSet.Estudiante' table. You can move, or remove it, as needed.
                SqlConnection con = new SqlConnection(conexion);
                string query = ("Delete from Materia where materia = '" + materiaComboBox.Text + "'");
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Materia Eliminada Correctamente!!");
                materiaTableAdapter.DeleteQuery(materiaComboBox.Text);
                this.materiaTableAdapter.Fill(this.estudiante2DataSet.Materia);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EditarMateria a = new EditarMateria();
            a.Show();
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }
    }
}
