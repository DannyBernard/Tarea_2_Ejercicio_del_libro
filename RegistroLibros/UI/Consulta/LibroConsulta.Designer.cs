namespace RegistroLibros.UI.Consulta
{
    partial class LibroConsulta
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
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(12, 62);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(165, 63);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(330, 20);
            this.CriteriotextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Criterio";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(77, 116);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.DesdedateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(265, 116);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.HastadateTimePicker.TabIndex = 6;
            // 
            // Consultabutton
            // 
            this.Consultabutton.Location = new System.Drawing.Point(512, 61);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(75, 23);
            this.Consultabutton.TabIndex = 8;
            this.Consultabutton.Text = "Consulta";
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 280);
            this.dataGridView1.TabIndex = 9;
            // 
            // LibroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrocomboBox);
            this.Name = "LibroConsulta";
            this.Text = "LibroConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}