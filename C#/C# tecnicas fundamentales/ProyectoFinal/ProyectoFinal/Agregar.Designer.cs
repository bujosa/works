namespace ProyectoFinal
{
    partial class Agregar
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label carreraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiante2DataSet = new ProyectoFinal.Estudiante2DataSet();
            this.estudiante2DataSet1 = new ProyectoFinal.Estudiante2DataSet1();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager = new ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager();
            this.estudianteTableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.EstudianteTableAdapter();
            this.estudiante3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.MateriaTableAdapter();
            this.estudiante2TableAdapter1 = new ProyectoFinal.Estudiante2DataSetTableAdapters.Estudiante2TableAdapter();
            this.estudiante3TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Estudiante3TableAdapter();
            this.estudiante4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiante4TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Estudiante4TableAdapter();
            this.carreraComboBox = new System.Windows.Forms.ComboBox();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            carreraLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            idLabel.Location = new System.Drawing.Point(165, 67);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 12;
            idLabel.Text = "Id:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nombreCompletoLabel.Location = new System.Drawing.Point(165, 96);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(149, 20);
            nombreCompletoLabel.TabIndex = 14;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            passwordLabel.Location = new System.Drawing.Point(165, 160);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(88, 20);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            label1.Location = new System.Drawing.Point(165, 192);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 20);
            label1.TabIndex = 18;
            label1.Text = "Confirmar:";
            // 
            // carreraLabel
            // 
            carreraLabel.AutoSize = true;
            carreraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            carreraLabel.Location = new System.Drawing.Point(165, 129);
            carreraLabel.Name = "carreraLabel";
            carreraLabel.Size = new System.Drawing.Size(71, 20);
            carreraLabel.TabIndex = 19;
            carreraLabel.Text = "Carrera:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.menuMateriaToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAMenuToolStripMenuItem});
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.mToolStripMenuItem.Text = "Menu Estudiante";
            // 
            // volverAMenuToolStripMenuItem
            // 
            this.volverAMenuToolStripMenuItem.Name = "volverAMenuToolStripMenuItem";
            this.volverAMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.volverAMenuToolStripMenuItem.Text = "Volver a Menu";
            this.volverAMenuToolStripMenuItem.Click += new System.EventHandler(this.volverAMenuToolStripMenuItem_Click);
            // 
            // menuMateriaToolStripMenuItem
            // 
            this.menuMateriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.menuMateriaToolStripMenuItem.Name = "menuMateriaToolStripMenuItem";
            this.menuMateriaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.menuMateriaToolStripMenuItem.Text = "Menu Materia";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = this.materiaBindingSource1;
            // 
            // materiaBindingSource1
            // 
            this.materiaBindingSource1.DataMember = "Materia";
            this.materiaBindingSource1.DataSource = this.estudianteBindingSource;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = this.estudiante2DataSet;
            this.estudianteBindingSource.Position = 0;
            // 
            // estudiante2DataSet
            // 
            this.estudiante2DataSet.DataSetName = "Estudiante2DataSet";
            this.estudiante2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiante2DataSet1
            // 
            this.estudiante2DataSet1.DataSetName = "Estudiante2DataSet1";
            this.estudiante2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idTextBox.Location = new System.Drawing.Point(314, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(267, 26);
            this.idTextBox.TabIndex = 13;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(314, 95);
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(267, 26);
            this.nombreCompletoTextBox.TabIndex = 15;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.passwordTextBox.Location = new System.Drawing.Point(314, 159);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(267, 26);
            this.passwordTextBox.TabIndex = 17;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(314, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 26);
            this.textBox1.TabIndex = 19;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources._64508;
            this.pictureBox3.Location = new System.Drawing.Point(12, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.canceltheapplication_cancelar_2901;
            this.pictureBox2.Location = new System.Drawing.Point(741, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources._1881;
            this.pictureBox1.Location = new System.Drawing.Point(597, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Estudiante2TableAdapter = null;
            this.tableAdapterManager.Estudiante3TableAdapter = null;
            this.tableAdapterManager.Estudiante4TableAdapter = null;
            this.tableAdapterManager.EstudianteTableAdapter = this.estudianteTableAdapter;
            this.tableAdapterManager.Materia2TableAdapter = null;
            this.tableAdapterManager.MateriaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // estudiante3BindingSource
            // 
            this.estudiante3BindingSource.DataMember = "Estudiante3";
            this.estudiante3BindingSource.DataSource = this.estudiante2DataSet;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // estudiante2TableAdapter1
            // 
            this.estudiante2TableAdapter1.ClearBeforeFill = true;
            // 
            // estudiante3TableAdapter
            // 
            this.estudiante3TableAdapter.ClearBeforeFill = true;
            // 
            // estudiante4BindingSource
            // 
            this.estudiante4BindingSource.DataMember = "Estudiante4";
            this.estudiante4BindingSource.DataSource = this.estudiante2DataSet;
            // 
            // estudiante4TableAdapter
            // 
            this.estudiante4TableAdapter.ClearBeforeFill = true;
            // 
            // carreraComboBox
            // 
            this.carreraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiante4BindingSource, "Carrera", true));
            this.carreraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.carreraComboBox.FormattingEnabled = true;
            this.carreraComboBox.Items.AddRange(new object[] {
            "Licenciatura en Biotecnología (LBT)",
            "Licenciatura en Matemáticas con concentración en Estadísticas y Ciencias Actuaria" +
                "les (MAT)",
            "Área de Ciencias de la Salud",
            "Doctor en Medicina (MED)",
            "Doctor en Odontología",
            "Licenciatura en Cine y Comunicación Audiovisual (LCC)",
            "Licenciatura en Comunicación Social y Medios Digitales",
            "Licenciatura en Psicología (PSI)",
            "Diseño Industrial (DIN)",
            "Ingeniería Civil (CIV)",
            "Ingeniería de Sistemas (SIS)",
            "Ingeniería de Software (IDS)",
            "Ingeniería Eléctrica (ELE)",
            "Ingeniería Electrónica y de Comunicaciones (INL)",
            "Ingeniería en Ciberseguridad",
            "Ingeniería Industrial (IND)",
            "Ingeniería Mecánica (MEC)",
            "Ingeniería Mecatrónica (IMC)",
            "Administración y Gestión de Negocios (AGN)",
            "Contabilidad y Auditoría Empresarial (CAE)",
            "Economía (ECO)",
            "Licenciatura en Ingeniería Comercial (LIC)",
            "Mercadeo y Negocios Electrónicos (MNE)",
            "Negocios Internacionales (LNI)",
            " "});
            this.carreraComboBox.Location = new System.Drawing.Point(314, 128);
            this.carreraComboBox.Name = "carreraComboBox";
            this.carreraComboBox.Size = new System.Drawing.Size(267, 28);
            this.carreraComboBox.TabIndex = 20;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(770, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cancelar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(628, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Agregar";
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(carreraLabel);
            this.Controls.Add(this.carreraComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreCompletoLabel);
            this.Controls.Add(this.nombreCompletoTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Agregar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAMenuToolStripMenuItem;
        private Estudiante2DataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private Estudiante2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private Estudiante2DataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem menuMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private Estudiante2DataSet estudiante2DataSet;
        private Estudiante2DataSetTableAdapters.Estudiante2TableAdapter estudiante2TableAdapter1;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private Estudiante2DataSet1 estudiante2DataSet1;
        private System.Windows.Forms.BindingSource materiaBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.BindingSource estudiante3BindingSource;
        private Estudiante2DataSetTableAdapters.Estudiante3TableAdapter estudiante3TableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource estudiante4BindingSource;
        private Estudiante2DataSetTableAdapters.Estudiante4TableAdapter estudiante4TableAdapter;
        private System.Windows.Forms.ComboBox carreraComboBox;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}