namespace ProyectoFinal
{
    partial class EstudianteMateria
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
            System.Windows.Forms.Label gELabel;
            System.Windows.Forms.Label materiaLabel;
            System.Windows.Forms.Label codigo_Label;
            System.Windows.Forms.Label creditoLabel;
            System.Windows.Forms.Label notaLabel;
            System.Windows.Forms.Label letraLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudianteMateria));
            this.estudiante2DataSet = new ProyectoFinal.Estudiante2DataSet();
            this.materia2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materia2TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Materia2TableAdapter();
            this.tableAdapterManager = new ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager();
            this.gETextBox = new System.Windows.Forms.TextBox();
            this.materiaComboBox = new System.Windows.Forms.ComboBox();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigo_TextBox = new System.Windows.Forms.TextBox();
            this.creditoComboBox = new System.Windows.Forms.ComboBox();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.letraTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombreCompletoComboBox = new System.Windows.Forms.ComboBox();
            this.estudiante4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiante3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.estudiante3TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Estudiante3TableAdapter();
            this.materiaTableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.MateriaTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiante4TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Estudiante4TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            gELabel = new System.Windows.Forms.Label();
            materiaLabel = new System.Windows.Forms.Label();
            codigo_Label = new System.Windows.Forms.Label();
            creditoLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            letraLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materia2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gELabel
            // 
            gELabel.AutoSize = true;
            gELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            gELabel.Location = new System.Drawing.Point(324, 421);
            gELabel.Name = "gELabel";
            gELabel.Size = new System.Drawing.Size(38, 20);
            gELabel.TabIndex = 0;
            gELabel.Text = "GE:";
            gELabel.Visible = false;
            // 
            // materiaLabel
            // 
            materiaLabel.AutoSize = true;
            materiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            materiaLabel.Location = new System.Drawing.Point(251, 94);
            materiaLabel.Name = "materiaLabel";
            materiaLabel.Size = new System.Drawing.Size(70, 20);
            materiaLabel.TabIndex = 2;
            materiaLabel.Text = "Materia:";
            // 
            // codigo_Label
            // 
            codigo_Label.AutoSize = true;
            codigo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            codigo_Label.Location = new System.Drawing.Point(22, 421);
            codigo_Label.Name = "codigo_Label";
            codigo_Label.Size = new System.Drawing.Size(68, 20);
            codigo_Label.TabIndex = 4;
            codigo_Label.Text = "codigo :";
            codigo_Label.Visible = false;
            // 
            // creditoLabel
            // 
            creditoLabel.AutoSize = true;
            creditoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            creditoLabel.Location = new System.Drawing.Point(251, 139);
            creditoLabel.Name = "creditoLabel";
            creditoLabel.Size = new System.Drawing.Size(68, 20);
            creditoLabel.TabIndex = 6;
            creditoLabel.Text = "Credito:";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            notaLabel.Location = new System.Drawing.Point(251, 225);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(49, 20);
            notaLabel.TabIndex = 12;
            notaLabel.Text = "Nota:";
            // 
            // letraLabel
            // 
            letraLabel.AutoSize = true;
            letraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            letraLabel.Location = new System.Drawing.Point(251, 267);
            letraLabel.Name = "letraLabel";
            letraLabel.Size = new System.Drawing.Size(53, 20);
            letraLabel.TabIndex = 14;
            letraLabel.Text = "Letra:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nombreCompletoLabel.Location = new System.Drawing.Point(251, 186);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(149, 20);
            nombreCompletoLabel.TabIndex = 17;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(589, 427);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 18;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // estudiante2DataSet
            // 
            this.estudiante2DataSet.DataSetName = "Estudiante2DataSet";
            this.estudiante2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materia2BindingSource
            // 
            this.materia2BindingSource.DataMember = "Materia2";
            this.materia2BindingSource.DataSource = this.estudiante2DataSet;
            // 
            // materia2TableAdapter
            // 
            this.materia2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Estudiante2TableAdapter = null;
            this.tableAdapterManager.Estudiante3TableAdapter = null;
            this.tableAdapterManager.Estudiante4TableAdapter = null;
            this.tableAdapterManager.EstudianteTableAdapter = null;
            this.tableAdapterManager.Materia2TableAdapter = this.materia2TableAdapter;
            this.tableAdapterManager.MateriaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gETextBox
            // 
            this.gETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "GE", true));
            this.gETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gETextBox.Location = new System.Drawing.Point(391, 418);
            this.gETextBox.Name = "gETextBox";
            this.gETextBox.Size = new System.Drawing.Size(121, 26);
            this.gETextBox.TabIndex = 1;
            this.gETextBox.Visible = false;
            // 
            // materiaComboBox
            // 
            this.materiaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "materia", true));
            this.materiaComboBox.DataSource = this.materiaBindingSource;
            this.materiaComboBox.DisplayMember = "materia";
            this.materiaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.materiaComboBox.FormattingEnabled = true;
            this.materiaComboBox.Location = new System.Drawing.Point(406, 94);
            this.materiaComboBox.Name = "materiaComboBox";
            this.materiaComboBox.Size = new System.Drawing.Size(157, 28);
            this.materiaComboBox.TabIndex = 3;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.estudiante2DataSet;
            // 
            // codigo_TextBox
            // 
            this.codigo_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "codigo ", true));
            this.codigo_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.codigo_TextBox.Location = new System.Drawing.Point(133, 418);
            this.codigo_TextBox.Name = "codigo_TextBox";
            this.codigo_TextBox.Size = new System.Drawing.Size(121, 26);
            this.codigo_TextBox.TabIndex = 5;
            this.codigo_TextBox.Visible = false;
            // 
            // creditoComboBox
            // 
            this.creditoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "credito", true));
            this.creditoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.creditoComboBox.FormattingEnabled = true;
            this.creditoComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.creditoComboBox.Location = new System.Drawing.Point(406, 139);
            this.creditoComboBox.Name = "creditoComboBox";
            this.creditoComboBox.Size = new System.Drawing.Size(157, 28);
            this.creditoComboBox.TabIndex = 7;
            // 
            // notaTextBox
            // 
            this.notaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.notaTextBox.Location = new System.Drawing.Point(406, 225);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(157, 26);
            this.notaTextBox.TabIndex = 13;
            this.notaTextBox.TextChanged += new System.EventHandler(this.notaTextBox_TextChanged);
            // 
            // letraTextBox
            // 
            this.letraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.letraTextBox.Location = new System.Drawing.Point(406, 267);
            this.letraTextBox.Name = "letraTextBox";
            this.letraTextBox.ReadOnly = true;
            this.letraTextBox.Size = new System.Drawing.Size(157, 26);
            this.letraTextBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.UserEdit_40958;
            this.pictureBox1.Location = new System.Drawing.Point(30, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // nombreCompletoComboBox
            // 
            this.nombreCompletoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "NombreCompleto", true));
            this.nombreCompletoComboBox.DataSource = this.estudiante4BindingSource;
            this.nombreCompletoComboBox.DisplayMember = "NombreCompleto";
            this.nombreCompletoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreCompletoComboBox.FormattingEnabled = true;
            this.nombreCompletoComboBox.Location = new System.Drawing.Point(406, 183);
            this.nombreCompletoComboBox.Name = "nombreCompletoComboBox";
            this.nombreCompletoComboBox.Size = new System.Drawing.Size(157, 28);
            this.nombreCompletoComboBox.TabIndex = 18;
            // 
            // estudiante4BindingSource
            // 
            this.estudiante4BindingSource.DataMember = "Estudiante4";
            this.estudiante4BindingSource.DataSource = this.estudiante2DataSet;
            // 
            // estudiante3BindingSource
            // 
            this.estudiante3BindingSource.DataMember = "Estudiante3";
            this.estudiante3BindingSource.DataSource = this.estudiante2DataSet;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(614, 424);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 19;
            this.idTextBox.Visible = false;
            // 
            // estudiante3TableAdapter
            // 
            this.estudiante3TableAdapter.ClearBeforeFill = true;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.canceltheapplication_cancelar_2901;
            this.pictureBox2.Location = new System.Drawing.Point(629, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources._1881;
            this.pictureBox3.Location = new System.Drawing.Point(629, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEstudiantesToolStripMenuItem,
            this.menuMateriaToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuEstudiantesToolStripMenuItem
            // 
            this.menuEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEstudianteToolStripMenuItem,
            this.listarEstudiantesToolStripMenuItem,
            this.volverAMenuToolStripMenuItem});
            this.menuEstudiantesToolStripMenuItem.Name = "menuEstudiantesToolStripMenuItem";
            this.menuEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.menuEstudiantesToolStripMenuItem.Text = "Menu Estudiantes";
            // 
            // crearEstudianteToolStripMenuItem
            // 
            this.crearEstudianteToolStripMenuItem.Name = "crearEstudianteToolStripMenuItem";
            this.crearEstudianteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.crearEstudianteToolStripMenuItem.Text = "Crear Estudiante";
            this.crearEstudianteToolStripMenuItem.Click += new System.EventHandler(this.crearEstudianteToolStripMenuItem_Click);
            // 
            // listarEstudiantesToolStripMenuItem
            // 
            this.listarEstudiantesToolStripMenuItem.Name = "listarEstudiantesToolStripMenuItem";
            this.listarEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listarEstudiantesToolStripMenuItem.Text = "Listar Estudiantes";
            this.listarEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.listarEstudiantesToolStripMenuItem_Click_1);
            // 
            // volverAMenuToolStripMenuItem
            // 
            this.volverAMenuToolStripMenuItem.Name = "volverAMenuToolStripMenuItem";
            this.volverAMenuToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.volverAMenuToolStripMenuItem.Text = "Volver a Menu";
            this.volverAMenuToolStripMenuItem.Click += new System.EventHandler(this.volverAMenuToolStripMenuItem_Click);
            // 
            // menuMateriaToolStripMenuItem
            // 
            this.menuMateriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMateriaToolStripMenuItem,
            this.listarMateriaToolStripMenuItem});
            this.menuMateriaToolStripMenuItem.Name = "menuMateriaToolStripMenuItem";
            this.menuMateriaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.menuMateriaToolStripMenuItem.Text = "Menu Materia";
            // 
            // agregarMateriaToolStripMenuItem
            // 
            this.agregarMateriaToolStripMenuItem.Name = "agregarMateriaToolStripMenuItem";
            this.agregarMateriaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarMateriaToolStripMenuItem.Text = "Agregar Materia";
            this.agregarMateriaToolStripMenuItem.Click += new System.EventHandler(this.agregarMateriaToolStripMenuItem_Click_1);
            // 
            // listarMateriaToolStripMenuItem
            // 
            this.listarMateriaToolStripMenuItem.Name = "listarMateriaToolStripMenuItem";
            this.listarMateriaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listarMateriaToolStripMenuItem.Text = "Listar Materia";
            this.listarMateriaToolStripMenuItem.Click += new System.EventHandler(this.listarMateriaToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // estudiante4TableAdapter
            // 
            this.estudiante4TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(655, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cancelar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(657, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Agregar";
            // 
            // EstudianteMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreCompletoLabel);
            this.Controls.Add(this.nombreCompletoComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(gELabel);
            this.Controls.Add(this.gETextBox);
            this.Controls.Add(materiaLabel);
            this.Controls.Add(this.materiaComboBox);
            this.Controls.Add(codigo_Label);
            this.Controls.Add(this.codigo_TextBox);
            this.Controls.Add(creditoLabel);
            this.Controls.Add(this.creditoComboBox);
            this.Controls.Add(notaLabel);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(letraLabel);
            this.Controls.Add(this.letraTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EstudianteMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante Materia";
            this.Load += new System.EventHandler(this.EstudianteMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materia2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Estudiante2DataSet estudiante2DataSet;
        private System.Windows.Forms.BindingSource materia2BindingSource;
        private Estudiante2DataSetTableAdapters.Materia2TableAdapter materia2TableAdapter;
        private Estudiante2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox gETextBox;
        private System.Windows.Forms.ComboBox materiaComboBox;
        private System.Windows.Forms.TextBox codigo_TextBox;
        private System.Windows.Forms.ComboBox creditoComboBox;
        private System.Windows.Forms.TextBox notaTextBox;
        private System.Windows.Forms.TextBox letraTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox nombreCompletoComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource estudiante3BindingSource;
        private Estudiante2DataSetTableAdapters.Estudiante3TableAdapter estudiante3TableAdapter;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private Estudiante2DataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.BindingSource estudiante4BindingSource;
        private Estudiante2DataSetTableAdapters.Estudiante4TableAdapter estudiante4TableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}