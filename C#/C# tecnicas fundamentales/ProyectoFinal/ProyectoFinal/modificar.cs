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
    public partial class modificar : Form

    {
     
        public modificar()
        {
            InitializeComponent();
        }

        private void estudiante2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materia2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estudiante2DataSet);

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (creditoComboBox.Text == "" || notaTextBox.Text == "" || materiaComboBox.Text == "" )
            {
                MessageBox.Show("Error ningun campo vacio puede a ver ");

            }
            else
            {

                
               
                int id = Convert.ToInt32(idTextBox.Text);
                int credito = Convert.ToInt32(creditoComboBox.Text);
                MessageBox.Show("" + gETextBox.Text);
                int generado = Convert.ToInt32(gETextBox.Text);
                int nota = Convert.ToInt32(notaTextBox.Text);
                string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";

                SqlConnection con = new SqlConnection(conexion);
                string query = "update Materia2 set materia = @materia, codigo = @codigo, credito = @credito, Id = @id, NombreCompleto = @nombre, Nota = @nota, Letra = @letra where GE = @ge";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@materia", materiaComboBox.Text);
                cmd.Parameters.AddWithValue("@codigo", busqueda(materiaComboBox.Text));
                cmd.Parameters.AddWithValue("@credito", credito);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombreCompletoTextBox.Text);
                cmd.Parameters.AddWithValue("@nota", nota);
                cmd.Parameters.AddWithValue("@letra", letraTextBox.Text);
                cmd.Parameters.AddWithValue("@ge", generado);
               
                cmd.ExecuteNonQuery();
                materia2TableAdapter.UpdateQuery(materiaComboBox.Text, codigo_TextBox.Text, credito, id, nombreCompletoTextBox.Text, nota, letraTextBox.Text, generado);
                materia2TableAdapter.Fill(this.estudiante2DataSet.Materia2);
                MessageBox.Show("El estudiantre ha sido Modificado sastifactoriamente", "Correcto", MessageBoxButtons.OKCancel);
                con.Close();
                Listar a = new Listar();
                a.Show();
                this.Close();


            }


        }

        public string busqueda(string x)
        {
            string y;

            int id2 = Convert.ToInt32(idTextBox.Text);
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

        private void modificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.estudiante2DataSet.Materia);
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia2' table. You can move, or remove it, as needed.
            this.materia2TableAdapter.Fill(this.estudiante2DataSet.Materia2);
            // TODO: This line of code loads data into the 'estudiante2DataSet.Estudiante3' table. You can move, or remove it, as needed.

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Listar a = new Listar();
            a.Show();
            this.Close();
        }

        private void notaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (notaTextBox.Text == "")
            {

            }
            else
            {
                int numero = Convert.ToInt32(notaTextBox.Text);
                if (numero < 70)
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
}
