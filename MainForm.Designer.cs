namespace Assignment_10_3_winforms_sqllite
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewCars = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vINDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            makeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource = new BindingSource(components);
            buttonSave = new Button();
            textBoxVIN = new TextBox();
            textBoxMake = new TextBox();
            textBoxModel = new TextBox();
            textBoxYear = new TextBox();
            buttonAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AllowUserToAddRows = false;
            dataGridViewCars.AllowUserToDeleteRows = false;
            dataGridViewCars.AutoGenerateColumns = false;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, vINDataGridViewTextBoxColumn, makeDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn });
            dataGridViewCars.DataSource = carBindingSource;
            dataGridViewCars.Location = new Point(26, 26);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(614, 152);
            dataGridViewCars.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // vINDataGridViewTextBoxColumn
            // 
            vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            makeDataGridViewTextBoxColumn.HeaderText = "Make";
            makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(446, 195);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(119, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save Changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxVIN
            // 
            textBoxVIN.Location = new Point(29, 289);
            textBoxVIN.Name = "textBoxVIN";
            textBoxVIN.Size = new Size(129, 23);
            textBoxVIN.TabIndex = 2;
            // 
            // textBoxMake
            // 
            textBoxMake.Location = new Point(164, 288);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(98, 23);
            textBoxMake.TabIndex = 3;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(268, 288);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(114, 23);
            textBoxModel.TabIndex = 4;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(388, 288);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(52, 23);
            textBoxYear.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(446, 287);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add New";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 270);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 7;
            label1.Text = "VIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 270);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 270);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 7;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 270);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Year";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(446, 236);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(119, 23);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 325);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxMake);
            Controls.Add(textBoxVIN);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCars);
            Name = "MainForm";
            Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCars;
        private BindingSource carBindingSource;
        private Button buttonSave;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private TextBox textBoxVIN;
        private TextBox textBoxMake;
        private TextBox textBoxModel;
        private TextBox textBoxYear;
        private Button buttonAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonDelete;
    }
}
