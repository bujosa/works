namespace ProyectoFinal
{
    partial class modificar
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
            System.Windows.Forms.Label creditoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label notaLabel;
            System.Windows.Forms.Label letraLabel;
            System.Windows.Forms.Label gELabel;
            System.Windows.Forms.Label codigo_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificar));
            this.estudiante2DataSet = new ProyectoFinal.Estudiante2DataSet();
            this.estudiante2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiante2TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Estudiante2TableAdapter();
            this.tableAdapterManager = new ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.materia2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.materia2TableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.Materia2TableAdapter();
            this.materiaComboBox = new System.Windows.Forms.ComboBox();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditoComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.letraTextBox = new System.Windows.Forms.TextBox();
            this.materiaTableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.MateriaTableAdapter();
            this.gETextBox = new System.Windows.Forms.TextBox();
            this.codigo_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            materiaLabel = new System.Windows.Forms.Label();
            creditoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            letraLabel = new System.Windows.Forms.Label();
            gELabel = new System.Windows.Forms.Label();
            codigo_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materia2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materiaLabel
            // 
            materiaLabel.AutoSize = true;
            materiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            materiaLabel.Location = new System.Drawing.Point(258, 86);
            materiaLabel.Name = "materiaLabel";
            materiaLabel.Size = new System.Drawing.Size(70, 20);
            materiaLabel.TabIndex = 18;
            materiaLabel.Text = "materia:";
            // 
            // creditoLabel
            // 
            creditoLabel.AutoSize = true;
            creditoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            creditoLabel.Location = new System.Drawing.Point(258, 130);
            creditoLabel.Name = "creditoLabel";
            creditoLabel.Size = new System.Drawing.Size(65, 20);
            creditoLabel.TabIndex = 22;
            creditoLabel.Text = "credito:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            idLabel.Location = new System.Drawing.Point(258, 171);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 24;
            idLabel.Text = "Id:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nombreCompletoLabel.Location = new System.Drawing.Point(258, 204);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(149, 20);
            nombreCompletoLabel.TabIndex = 26;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            notaLabel.Location = new System.Drawing.Point(258, 244);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(49, 20);
            notaLabel.TabIndex = 28;
            notaLabel.Text = "Nota:";
            // 
            // letraLabel
            // 
            letraLabel.AutoSize = true;
            letraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            letraLabel.Location = new System.Drawing.Point(257, 285);
            letraLabel.Name = "letraLabel";
            letraLabel.Size = new System.Drawing.Size(53, 20);
            letraLabel.TabIndex = 30;
            letraLabel.Text = "Letra:";
            // 
            // gELabel
            // 
            gELabel.AutoSize = true;
            gELabel.Location = new System.Drawing.Point(398, 417);
            gELabel.Name = "gELabel";
            gELabel.Size = new System.Drawing.Size(25, 13);
            gELabel.TabIndex = 31;
            gELabel.Text = "GE:";
            // 
            // codigo_Label
            // 
            codigo_Label.AutoSize = true;
            codigo_Label.Location = new System.Drawing.Point(198, 425);
            codigo_Label.Name = "codigo_Label";
            codigo_Label.Size = new System.Drawing.Size(45, 13);
            codigo_Label.TabIndex = 32;
            codigo_Label.Text = "codigo :";
            codigo_Label.Visible = false;
            // 
            // estudiante2DataSet
            // 
            this.estudiante2DataSet.DataSetName = "Estudiante2DataSet";
            this.estudiante2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiante2BindingSource
            // 
            this.estudiante2BindingSource.DataMember = "Estudiante2";
            this.estudiante2BindingSource.DataSource = this.estudiante2DataSet;
            // 
            // estudiante2TableAdapter
            // 
            this.estudiante2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Estudiante2TableAdapter = this.estudiante2TableAdapter;
            this.tableAdapterManager.Estudiante3TableAdapter = null;
            this.tableAdapterManager.Estudiante4TableAdapter = null;
            this.tableAdapterManager.EstudianteTableAdapter = null;
            this.tableAdapterManager.Materia2TableAdapter = null;
            this.tableAdapterManager.MateriaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.edit_validated_40458;
            this.pictureBox2.Location = new System.Drawing.Point(589, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.UserEdit_40958;
            this.pictureBox1.Location = new System.Drawing.Point(46, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources.canceltheapplication_cancelar_2901;
            this.pictureBox3.Location = new System.Drawing.Point(594, 219);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.LightGreen;
            this.bindingNavigator1.BindingSource = this.materia2BindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(802, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // materia2BindingSource
            // 
            this.materia2BindingSource.DataMember = "Materia2";
            this.materia2BindingSource.DataSource = this.estudiante2DataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // materia2TableAdapter
            // 
            this.materia2TableAdapter.ClearBeforeFill = true;
            // 
            // materiaComboBox
            // 
            this.materiaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "materia", true));
            this.materiaComboBox.DataSource = this.materiaBindingSource;
            this.materiaComboBox.DisplayMember = "materia";
            this.materiaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.materiaComboBox.FormattingEnabled = true;
            this.materiaComboBox.Location = new System.Drawing.Point(408, 86);
            this.materiaComboBox.Name = "materiaComboBox";
            this.materiaComboBox.Size = new System.Drawing.Size(121, 28);
            this.materiaComboBox.TabIndex = 19;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.estudiante2DataSet;
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
            this.creditoComboBox.Location = new System.Drawing.Point(408, 130);
            this.creditoComboBox.Name = "creditoComboBox";
            this.creditoComboBox.Size = new System.Drawing.Size(121, 28);
            this.creditoComboBox.TabIndex = 23;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idTextBox.Location = new System.Drawing.Point(408, 165);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(121, 26);
            this.idTextBox.TabIndex = 25;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(408, 204);
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.ReadOnly = true;
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(121, 26);
            this.nombreCompletoTextBox.TabIndex = 27;
            // 
            // notaTextBox
            // 
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "Nota", true));
            this.notaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.notaTextBox.Location = new System.Drawing.Point(408, 244);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(121, 26);
            this.notaTextBox.TabIndex = 29;
            this.notaTextBox.TextChanged += new System.EventHandler(this.notaTextBox_TextChanged);
            // 
            // letraTextBox
            // 
            this.letraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "Letra", true));
            this.letraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.letraTextBox.Location = new System.Drawing.Point(407, 285);
            this.letraTextBox.Name = "letraTextBox";
            this.letraTextBox.ReadOnly = true;
            this.letraTextBox.Size = new System.Drawing.Size(121, 26);
            this.letraTextBox.TabIndex = 31;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // gETextBox
            // 
            this.gETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "GE", true));
            this.gETextBox.Location = new System.Drawing.Point(429, 414);
            this.gETextBox.Name = "gETextBox";
            this.gETextBox.Size = new System.Drawing.Size(100, 20);
            this.gETextBox.TabIndex = 32;
            // 
            // codigo_TextBox
            // 
            this.codigo_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materia2BindingSource, "codigo ", true));
            this.codigo_TextBox.Location = new System.Drawing.Point(249, 422);
            this.codigo_TextBox.Name = "codigo_TextBox";
            this.codigo_TextBox.Size = new System.Drawing.Size(100, 20);
            this.codigo_TextBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(617, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(621, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cancelar";
            // 
            // modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(codigo_Label);
            this.Controls.Add(this.codigo_TextBox);
            this.Controls.Add(gELabel);
            this.Controls.Add(this.gETextBox);
            this.Controls.Add(materiaLabel);
            this.Controls.Add(this.materiaComboBox);
            this.Controls.Add(creditoLabel);
            this.Controls.Add(this.creditoComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreCompletoLabel);
            this.Controls.Add(this.nombreCompletoTextBox);
            this.Controls.Add(notaLabel);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(letraLabel);
            this.Controls.Add(this.letraTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modificar";
            this.Text = "modificar";
            this.Load += new System.EventHandler(this.modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materia2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Estudiante2DataSet estudiante2DataSet;
        private System.Windows.Forms.BindingSource estudiante2BindingSource;
        private Estudiante2DataSetTableAdapters.Estudiante2TableAdapter estudiante2TableAdapter;
        private Estudiante2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource materia2BindingSource;
        private Estudiante2DataSetTableAdapters.Materia2TableAdapter materia2TableAdapter;
        private System.Windows.Forms.ComboBox materiaComboBox;
        private System.Windows.Forms.ComboBox creditoComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.TextBox notaTextBox;
        private System.Windows.Forms.TextBox letraTextBox;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private Estudiante2DataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.TextBox gETextBox;
        private System.Windows.Forms.TextBox codigo_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}