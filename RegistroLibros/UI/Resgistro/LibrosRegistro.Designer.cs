namespace RegistroLibros
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.SiglatextBox = new System.Windows.Forms.TextBox();
            this.TipotextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Siglas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(79, 81);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.IDnumericUpDown.TabIndex = 5;
            // 
            // NombretextBox
            // 
            this.NombretextBox.BackColor = System.Drawing.SystemColors.Info;
            this.errorProvider1.SetIconAlignment(this.NombretextBox, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.NombretextBox.Location = new System.Drawing.Point(79, 137);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(302, 20);
            this.NombretextBox.TabIndex = 6;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(79, 182);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(302, 20);
            this.DescripciontextBox.TabIndex = 7;
            // 
            // SiglatextBox
            // 
            this.SiglatextBox.Location = new System.Drawing.Point(79, 227);
            this.SiglatextBox.Name = "SiglatextBox";
            this.SiglatextBox.Size = new System.Drawing.Size(100, 20);
            this.SiglatextBox.TabIndex = 8;
            // 
            // TipotextBox
            // 
            this.TipotextBox.Location = new System.Drawing.Point(226, 227);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(155, 20);
            this.TipotextBox.TabIndex = 9;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroLibros.Properties.Resources.document_new2;
            this.Nuevobutton.Location = new System.Drawing.Point(28, 281);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 54);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::RegistroLibros.Properties.Resources.save;
            this.Guardarbutton.Location = new System.Drawing.Point(155, 281);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 54);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroLibros.Properties.Resources.delete;
            this.Eliminarbutton.Location = new System.Drawing.Point(291, 281);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 54);
            this.Eliminarbutton.TabIndex = 12;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroLibros.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(155, 53);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 60);
            this.Buscarbutton.TabIndex = 13;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroLibros.Properties.Resources.libros_XxXx80;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 348);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.TipotextBox);
            this.Controls.Add(this.SiglatextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox SiglatextBox;
        private System.Windows.Forms.TextBox TipotextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}