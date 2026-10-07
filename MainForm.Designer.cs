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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AutoGenerateColumns = false;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, vINDataGridViewTextBoxColumn, makeDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn });
            dataGridViewCars.DataSource = carBindingSource;
            dataGridViewCars.Location = new Point(42, 31);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(557, 150);
            dataGridViewCars.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // vINDataGridViewTextBoxColumn
            // 
            vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            vINDataGridViewTextBoxColumn.MinimumWidth = 200;
            vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            vINDataGridViewTextBoxColumn.Width = 200;
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
            buttonSave.Location = new Point(524, 187);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 227);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCars);
            Name = "MainForm";
            Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCars;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private BindingSource carBindingSource;
        private Button buttonSave;
    }
}
