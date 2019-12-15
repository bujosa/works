using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoFinal
{
    public partial class Listar : Form

    {
        public Listar()
        {
            InitializeComponent();
        
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
            Form1 da = new Form1();
            da.Show();
            this.Close();

        }

     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Error ningun campo vacio puede a ver ");

            }
            else
            {

                string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";

                // TODO: This line of code loads data into the 'estudianteNotasDataSet.Estudiante' table. You can move, or remove it, as needed.
                SqlConnection con = new SqlConnection(conexion);
                string query = ("Delete Top(1) from Materia2 where NombreCompleto = '" + textBox1.Text + "'");
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Estudiante Eliminado Correctamente!!");
                textBox1.Clear();
                this.materia2TableAdapter.DeleteQuery( textBox1.Text);
                this.materia2TableAdapter.Fill(this.estudiante2DataSet.Materia2);
               

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            modificar a = new modificar();
            a.Show();
            this.Close(); 
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            this.materia2TableAdapter.FillBy(this.estudiante2DataSet.Materia2, textBox1.Text);
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

        public void Listar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia2' table. You can move, or remove it, as needed.
            this.materia2TableAdapter.FillBy3(this.estudiante2DataSet.Materia2);
            // TODO: This line of code loads data into the 'estudiante2DataSet.Estudiante2' table. You can move, or remove it, as needed.
          
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            materia2TableAdapter.FillBy2(estudiante2DataSet.Materia2);

        }

       
    }
}
