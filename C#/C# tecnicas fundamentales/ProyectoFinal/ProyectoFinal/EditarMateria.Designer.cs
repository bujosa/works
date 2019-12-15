namespace ProyectoFinal
{
    partial class EditarMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarMateria));
            this.estudiante2DataSet = new ProyectoFinal.Estudiante2DataSet();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new ProyectoFinal.Estudiante2DataSetTableAdapters.MateriaTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.Estudiante2DataSetTableAdapters.TableAdapterManager();
            this.materiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.materiaComboBox = new System.Windows.Forms.ComboBox();
            this.codigo_TextBox = new System.Windows.Forms.TextBox();
            this.profesorTextBox = new System.Windows.Forms.TextBox();
            this.creditoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            materiaLabel = new System.Windows.Forms.Label();
            codigo_Label = new System.Windows.Forms.Label();
            profesorLabel = new System.Windows.Forms.Label();
            creditoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingNavigator)).BeginInit();
            this.materiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materiaLabel
            // 
            materiaLabel.AutoSize = true;
            materiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            materiaLabel.Location = new System.Drawing.Point(204, 83);
            materiaLabel.Name = "materiaLabel";
            materiaLabel.Size = new System.Drawing.Size(70, 20);
            materiaLabel.TabIndex = 1;
            materiaLabel.Text = "materia:";
            // 
            // codigo_Label
            // 
            codigo_Label.AutoSize = true;
            codigo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            codigo_Label.Location = new System.Drawing.Point(204, 129);
            codigo_Label.Name = "codigo_Label";
            codigo_Label.Size = new System.Drawing.Size(68, 20);
            codigo_Label.TabIndex = 3;
            codigo_Label.Text = "codigo :";
            // 
            // profesorLabel
            // 
            profesorLabel.AutoSize = true;
            profesorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            profesorLabel.Location = new System.Drawing.Point(204, 175);
            profesorLabel.Name = "profesorLabel";
            profesorLabel.Size = new System.Drawing.Size(76, 20);
            profesorLabel.TabIndex = 5;
            profesorLabel.Text = "profesor:";
            // 
            // creditoLabel
            // 
            creditoLabel.AutoSize = true;
            creditoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            creditoLabel.Location = new System.Drawing.Point(204, 217);
            creditoLabel.Name = "creditoLabel";
            creditoLabel.Size = new System.Drawing.Size(65, 20);
            creditoLabel.TabIndex = 7;
            creditoLabel.Text = "credito:";
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
            // materiaBindingNavigator
            // 
            this.materiaBindingNavigator.AddNewItem = null;
            this.materiaBindingNavigator.BackColor = System.Drawing.Color.LightGreen;
            this.materiaBindingNavigator.BindingSource = this.materiaBindingSource;
            this.materiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materiaBindingNavigator.DeleteItem = null;
            this.materiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.materiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materiaBindingNavigator.Name = "materiaBindingNavigator";
            this.materiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materiaBindingNavigator.Size = new System.Drawing.Size(747, 25);
            this.materiaBindingNavigator.TabIndex = 0;
            this.materiaBindingNavigator.Text = "bindingNavigator1";
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
            // materiaComboBox
            // 
            this.materiaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaBindingSource, "materia", true));
            this.materiaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.materiaComboBox.FormattingEnabled = true;
            this.materiaComboBox.Location = new System.Drawing.Point(280, 80);
            this.materiaComboBox.Name = "materiaComboBox";
            this.materiaComboBox.Size = new System.Drawing.Size(121, 28);
            this.materiaComboBox.TabIndex = 2;
            // 
            // codigo_TextBox
            // 
            this.codigo_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaBindingSource, "codigo ", true));
            this.codigo_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.codigo_TextBox.Location = new System.Drawing.Point(280, 126);
            this.codigo_TextBox.Name = "codigo_TextBox";
            this.codigo_TextBox.ReadOnly = true;
            this.codigo_TextBox.Size = new System.Drawing.Size(121, 26);
            this.codigo_TextBox.TabIndex = 4;
            // 
            // profesorTextBox
            // 
            this.profesorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaBindingSource, "profesor", true));
            this.profesorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.profesorTextBox.Location = new System.Drawing.Point(280, 172);
            this.profesorTextBox.Name = "profesorTextBox";
            this.profesorTextBox.Size = new System.Drawing.Size(121, 26);
            this.profesorTextBox.TabIndex = 6;
            // 
            // creditoTextBox
            // 
            this.creditoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaBindingSource, "credito", true));
            this.creditoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.creditoTextBox.Location = new System.Drawing.Point(280, 214);
            this.creditoTextBox.Name = "creditoTextBox";
            this.creditoTextBox.ReadOnly = true;
            this.creditoTextBox.Size = new System.Drawing.Size(121, 26);
            this.creditoTextBox.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources._1524764453;
            this.pictureBox3.Location = new System.Drawing.Point(28, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.canceltheapplication_cancelar_2901;
            this.pictureBox1.Location = new System.Drawing.Point(437, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.edit_validated_40458;
            this.pictureBox2.Location = new System.Drawing.Point(584, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(467, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cancelar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(612, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Modificar";
            // 
            // EditarMateria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(materiaLabel);
            this.Controls.Add(this.materiaComboBox);
            this.Controls.Add(codigo_Label);
            this.Controls.Add(this.codigo_TextBox);
            this.Controls.Add(profesorLabel);
            this.Controls.Add(this.profesorTextBox);
            this.Controls.Add(creditoLabel);
            this.Controls.Add(this.creditoTextBox);
            this.Controls.Add(this.materiaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarMateria";
            this.Load += new System.EventHandler(this.EditarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudiante2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingNavigator)).EndInit();
            this.materiaBindingNavigator.ResumeLayout(false);
            this.materiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Estudiante2DataSet estudiante2DataSet;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private Estudiante2DataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private Estudiante2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materiaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ComboBox materiaComboBox;
        private System.Windows.Forms.TextBox codigo_TextBox;
        private System.Windows.Forms.TextBox profesorTextBox;
        private System.Windows.Forms.TextBox creditoTextBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}