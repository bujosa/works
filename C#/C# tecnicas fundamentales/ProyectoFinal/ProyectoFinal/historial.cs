using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class historial : Form
    {
        public string nombre;
        public historial(string x)
        {
            nombre = x;
            InitializeComponent();
        }

        private void materia2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materia2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estudiante2DataSet);

        }

        private void historial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiante2DataSet.Materia2' table. You can move, or remove it, as needed.
            this.materia2TableAdapter.FillBy(this.estudiante2DataSet.Materia2 , nombre);

        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("PROXIMAMENTE", "Services" +
                    "", MessageBoxButtons.OKCancel);
            

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EstudianteLogin a = new EstudianteLogin(nombre);
            a.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            materia2TableAdapter.FillBy1(estudiante2DataSet.Materia2, nombre);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EstudianteLogin a = new EstudianteLogin(nombre);
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
