using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;

namespace ProyectoFinal
{
    public partial class MenuEstudiante : Form
    {
        public MenuEstudiante()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Agregar a = new Agregar();
            a.Show();
            this.Close();
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Listar a = new Listar();
            a.Show();
            this.Close();
        }

    

        public void agregarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudianteMateria joselo = new EstudianteMateria();
            joselo.Show();
            this.Close();

        }

     

        private void MenuEstudiante2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EstudianteMateria a = new EstudianteMateria();
            a.Show();
            this.Close();
        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar a = new Listar();
            a.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar a = new Agregar();
            a.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MateriaMenu a = new MateriaMenu();
            a.Show();
            this.Close();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarMaterias a = new ListarMaterias();
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
