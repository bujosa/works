using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }


        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Listar right = new Listar();
            right.Show();
            this.Hide();
          
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar a = new Agregar();
            a.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuEstudiante a = new MenuEstudiante();
            a.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MateriaMenu a = new MateriaMenu();
            a.Show();
            this.Close();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarMaterias a = new ListarMaterias();
            a.Show();
            this.Hide();
        }

       

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE", "Services" +
               "", MessageBoxButtons.OKCancel);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }

        private void agregarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudianteMateria a = new EstudianteMateria();
            a.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MateriaMenu a = new MateriaMenu();
            a.Show();
            this.Close();
        }
    }
}
