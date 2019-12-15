namespace ProyectoFinal
{
    partial class ModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiante2DataSet = new ProyectoFinal.Estudiante2DataSet();
            this.estudiante3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiante3TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Estudiante3TableAdapter();
            this.tableAdapterManager = new ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.estudiante4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiante4TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Estudiante4TableAdapter();
            this.carreraComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            carreraLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            idLabel.Location = new System.Drawing.Point(165, 82);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nombreCompletoLabel.Location = new System.Drawing.Point(165, 125);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(149, 20);
            nombreCompletoLabel.TabIndex = 13;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            passwordLabel.Location = new System.Drawing.Point(165, 204);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(88, 20);
            passwordLabel.TabIndex = 15;
            passwordLabel.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            label1.Location = new System.Drawing.Point(166, 241);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 20);
            label1.TabIndex = 22;
            label1.Text = "Confirmar:";
            // 
            // carreraLabel
            // 
            carreraLabel.AutoSize = true;
            carreraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            carreraLabel.Location = new System.Drawing.Point(165, 166);
            carreraLabel.Name = "carreraLabel";
            carreraLabel.Size = new System.Drawing.Size(71, 20);
            carreraLabel.TabIndex = 25;
            carreraLabel.Text = "Carrera:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEstudianteToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.cerrarSeccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuEstudianteToolStripMenuItem
            // 
            this.menuEstudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.agregarToolStripMenuItem1,
            this.listarToolStripMenuItem});
            this.menuEstudianteToolStripMenuItem.Name = "menuEstudianteToolStripMenuItem";
            this.menuEstudianteToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuEstudianteToolStripMenuItem.Text = "Menu";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.agregarToolStripMenuItem1.Text = "Historial ";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.listarToolStripMenuItem.Text = "Cerrar Seccion";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // cerrarSeccionToolStripMenuItem
            // 
            this.cerrarSeccionToolStripMenuItem.Name = "cerrarSeccionToolStripMenuItem";
            this.cerrarSeccionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSeccionToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSeccionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeccionToolStripMenuItem_Click);
            // 
            // estudiante2DataSet
            // 
            this.estudiante2DataSet.DataSetName = "Estudiante2DataSet";
            this.estudiante2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiante3BindingSource
            // 
            this.estudiante3BindingSource.DataMember = "Estudiante3";
            this.estudiante3BindingSource.DataSource = this.estudiante2DataSet;
            // 
            // estudiante3TableAdapter
            // 
            this.estudiante3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Estudiante2TableAdapter = null;
            this.tableAdapterManager.Estudiante3TableAdapter = this.estudiante3TableAdapter;
            this.tableAdapterManager.Estudiante4TableAdapter = null;
            this.tableAdapterManager.EstudianteTableAdapter = null;
            this.tableAdapterManager.Materia2TableAdapter = null;
            this.tableAdapterManager.MateriaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idTextBox.Location = new System.Drawing.Point(315, 79);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(251, 26);
            this.idTextBox.TabIndex = 12;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiante3BindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(315, 122);
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.ReadOnly = true;
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(251, 26);
            this.nombreCompletoTextBox.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.passwordTextBox.Location = new System.Drawing.Point(315, 201);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(251, 26);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(315, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(251, 26);
            this.textBox1.TabIndex = 23;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources._64508;
            this.pictureBox3.Location = new System.Drawing.Point(12, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources._1881;
            this.pictureBox1.Location = new System.Drawing.Point(571, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.canceltheapplication_cancelar_2901;
            this.pictureBox2.Location = new System.Drawing.Point(721, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.carreraComboBox.Location = new System.Drawing.Point(314, 163);
            this.carreraComboBox.Name = "carreraComboBox";
            this.carreraComboBox.Size = new System.Drawing.Size(251, 28);
            this.carreraComboBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(596, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Modificar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(752, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cancelar";
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(carreraLabel);
            this.Controls.Add(this.carreraComboBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreCompletoLabel);
            this.Controls.Add(this.nombreCompletoTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarUsuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private Estudiante2DataSet estudiante2DataSet;
        private System.Windows.Forms.BindingSource estudiante3BindingSource;
        private Estudiante2DataSetTableAdapters.Estudiante3TableAdapter estudiante3TableAdapter;
        private Estudiante2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource estudiante4BindingSource;
        private Estudiante2DataSetTableAdapters.Estudiante4TableAdapter estudiante4TableAdapter;
        private System.Windows.Forms.ComboBox carreraComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeccionToolStripMenuItem;
    }
}