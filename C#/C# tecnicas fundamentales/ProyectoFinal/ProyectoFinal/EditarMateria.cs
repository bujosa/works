using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class EditarMateria : Form
    {
        public EditarMateria()
        {
            InitializeComponent();
        }

        private void materiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estudiante2DataSet);

        }

        private void EditarMateria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.estudiante2DataSet.Materia);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListarMaterias a = new ListarMaterias();
            a.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (profesorTextBox.Text == "" || materiaComboBox.Text == "")
            {
                MessageBox.Show("Error ningun campo vacio puede a ver ");

            }
            else
            {

                materia a = new materia()
                {
                    asignatura = materiaComboBox.Text,
                    codigo = codigo_TextBox.Text,
                    credito = Convert.ToInt32(creditoTextBox.Text),
                    profesor = profesorTextBox.Text

                };

                string codigo = System.IO.Path.GetFullPath(@"..\..\") + "Estudiante2.mdf";
                string conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + codigo + "; Integrated Security = SSPI";

                SqlConnection con = new SqlConnection(conexion);
                string query = "update Materia set materia = @materia, profesor = @profesor, credito = @credito where codigo = @codigo";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@codigo", a.codigo);
                cmd.Parameters.AddWithValue("@credito",a.credito );
                cmd.Parameters.AddWithValue("@profesor", a.profesor );
                cmd.Parameters.AddWithValue("@materia", a.asignatura);
                cmd.ExecuteNonQuery();
                con.Close();
                materiaTableAdapter.UpdateQuery(a.asignatura, a.profesor, a.credito, a.codigo);
                materiaTableAdapter.Fill(this.estudiante2DataSet.Materia);
                MessageBox.Show("La Materia ha sido Modificado sastifactoriamente", "Correcto", MessageBoxButtons.OKCancel);
                ListarMaterias b = new ListarMaterias();
                b.Show();
                this.Close();

            }

        }
    }
}
