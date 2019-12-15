namespace ProyectoFinal
{
    partial class MateriaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label materiaLabel;
            System.Windows.Forms.Label codigo_Label;
            System.Windows.Forms.Label profesorLabel;
            System.Windows.Forms.Label creditoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaMenu));
            this.materiaTextBox = new System.Windows.Forms.TextBox();
            this.codigo_TextBox = new System.Windows.Forms.TextBox();
            this.profesorTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creditoTextBox = new System.Windows.Forms.ComboBox();
            this.estudiante2DataSet = new ProyectoFinal.Estudiante2DataSet();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.MateriaTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            materiaLabel = new System.Windows.Forms.Label();
            codigo_Label = new System.Windows.Forms.Label();
            profesorLabel = new System.Windows.Forms.Label();
            creditoLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materiaLabel
            // 
            materiaLabel.AutoSize = true;
            materiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            materiaLabel.Location = new System.Drawing.Point(198, 87);
            materiaLabel.Name = "materiaLabel";
            materiaLabel.Size = new System.Drawing.Size(70, 20);
            materiaLabel.TabIndex = 0;
            materiaLabel.Text = "Materia:";
            // 
            // codigo_Label
            // 
            codigo_Label.AutoSize = true;
            codigo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            codigo_Label.Location = new System.Drawing.Point(198, 119);
            codigo_Label.Name = "codigo_Label";
            codigo_Label.Size = new System.Drawing.Size(71, 20);
            codigo_Label.TabIndex = 2;
            codigo_Label.Text = "Codigo :";
            // 
            // profesorLabel
            // 
            profesorLabel.AutoSize = true;
            profesorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            profesorLabel.Location = new System.Drawing.Point(198, 156);
            profesorLabel.Name = "profesorLabel";
            profesorLabel.Size = new System.Drawing.Size(78, 20);
            profesorLabel.TabIndex = 4;
            profesorLabel.Text = "Profesor:";
            // 
            // creditoLabel
            // 
            creditoLabel.AutoSize = true;
            creditoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            creditoLabel.Location = new System.Drawing.Point(198, 195);
            creditoLabel.Name = "creditoLabel";
            creditoLabel.Size = new System.Drawing.Size(68, 20);
            creditoLabel.TabIndex = 6;
            creditoLabel.Text = "Credito:";
            // 
            // materiaTextBox
            // 
            this.materiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.materiaTextBox.Location = new System.Drawing.Point(283, 84);
            this.materiaTextBox.Name = "materiaTextBox";
            this.materiaTextBox.Size = new System.Drawing.Size(184, 26);
            this.materiaTextBox.TabIndex = 1;
            // 
            // codigo_TextBox
            // 
            this.codigo_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.codigo_TextBox.Location = new System.Drawing.Point(283, 119);
            this.codigo_TextBox.Name = "codigo_TextBox";
            this.codigo_TextBox.Size = new System.Drawing.Size(184, 26);
            this.codigo_TextBox.TabIndex = 3;
            // 
            // profesorTextBox
            // 
            this.profesorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.profesorTextBox.Location = new System.Drawing.Point(283, 156);
            this.profesorTextBox.Name = "profesorTextBox";
            this.profesorTextBox.Size = new System.Drawing.Size(184, 26);
            this.profesorTextBox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEstudianteToolStripMenuItem,
            this.menuMateriaToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuEstudianteToolStripMenuItem
            // 
            this.menuEstudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.notaEstudianteToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.menuEstudianteToolStripMenuItem.Name = "menuEstudianteToolStripMenuItem";
            this.menuEstudianteToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.menuEstudianteToolStripMenuItem.Text = "Menu Estudiante";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Crear";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // notaEstudianteToolStripMenuItem
            // 
            this.notaEstudianteToolStripMenuItem.Name = "notaEstudianteToolStripMenuItem";
            this.notaEstudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notaEstudianteToolStripMenuItem.Text = "Nota Estudiante";
            this.notaEstudianteToolStripMenuItem.Click += new System.EventHandler(this.notaEstudianteToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // menuMateriaToolStripMenuItem
            // 
            this.menuMateriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.menuMateriaToolStripMenuItem.Name = "menuMateriaToolStripMenuItem";
            this.menuMateriaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.menuMateriaToolStripMenuItem.Text = "Menu Materia";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios ";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources._1524764453;
            this.pictureBox3.Location = new System.Drawing.Point(22, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.canceltheapplication_cancelar_2901;
            this.pictureBox2.Location = new System.Drawing.Point(642, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources._1881;
            this.pictureBox1.Location = new System.Drawing.Point(496, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // creditoTextBox
            // 
            this.creditoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.creditoTextBox.FormattingEnabled = true;
            this.creditoTextBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.creditoTextBox.Location = new System.Drawing.Point(283, 193);
            this.creditoTextBox.Name = "creditoTextBox";
            this.creditoTextBox.Size = new System.Drawing.Size(184, 28);
            this.creditoTextBox.TabIndex = 13;
            this.creditoTextBox.Text = "1";
            // 
            // estudiante2DataSet
            // 
            this.estudiante2DataSet.DataSetName = "Estudiante2DataSet";
            this.estudiante2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.estudiante2DataSet;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Estudiante2TableAdapter = null;
            this.tableAdapterManager.Estudiante3TableAdapter = null;
            this.tableAdapterManager.Estudiante4TableAdapter = null;
            this.tableAdapterManager.EstudianteTableAdapter = null;
            this.tableAdapterManager.Materia2TableAdapter = null;
            this.tableAdapterManager.MateriaTableAdapter = this.materiaTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(526, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Agregar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(670, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cancelar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MateriaMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditoTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(materiaLabel);
            this.Controls.Add(this.materiaTextBox);
            this.Controls.Add(codigo_Label);
            this.Controls.Add(this.codigo_TextBox);
            this.Controls.Add(profesorLabel);
            this.Controls.Add(this.profesorTextBox);
            this.Controls.Add(creditoLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MateriaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MateriaMenu";
            this.Load += new System.EventHandler(this.MateriaMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Estudiante2DataSet estudiante2DataSet;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private Estudiante2DataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private Estudiante2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox materiaTextBox;
        private System.Windows.Forms.TextBox codigo_TextBox;
        private System.Windows.Forms.TextBox profesorTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox creditoTextBox;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notaEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}