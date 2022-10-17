namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btninsertar1 = new System.Windows.Forms.Button();
            this.btneliminar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btninsertar2 = new System.Windows.Forms.Button();
            this.btneliminar2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btninsertar1
            // 
            this.btninsertar1.Location = new System.Drawing.Point(52, 89);
            this.btninsertar1.Name = "btninsertar1";
            this.btninsertar1.Size = new System.Drawing.Size(96, 23);
            this.btninsertar1.TabIndex = 0;
            this.btninsertar1.Text = "insertar detras";
            this.btninsertar1.UseVisualStyleBackColor = true;
            this.btninsertar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar1
            // 
            this.btneliminar1.Location = new System.Drawing.Point(276, 146);
            this.btneliminar1.Name = "btneliminar1";
            this.btneliminar1.Size = new System.Drawing.Size(96, 23);
            this.btneliminar1.TabIndex = 1;
            this.btneliminar1.Text = "eliminar delante";
            this.btneliminar1.UseVisualStyleBackColor = true;
            this.btneliminar1.Click += new System.EventHandler(this.btneliminar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bicola";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "introduzca elemento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btninsertar2
            // 
            this.btninsertar2.Location = new System.Drawing.Point(277, 88);
            this.btninsertar2.Name = "btninsertar2";
            this.btninsertar2.Size = new System.Drawing.Size(95, 23);
            this.btninsertar2.TabIndex = 5;
            this.btninsertar2.Text = "insertar delante";
            this.btninsertar2.UseVisualStyleBackColor = true;
            this.btninsertar2.Click += new System.EventHandler(this.btninsertar2_Click);
            // 
            // btneliminar2
            // 
            this.btneliminar2.Location = new System.Drawing.Point(60, 146);
            this.btneliminar2.Name = "btneliminar2";
            this.btneliminar2.Size = new System.Drawing.Size(88, 23);
            this.btneliminar2.TabIndex = 6;
            this.btneliminar2.Text = "eliminar detras";
            this.btneliminar2.UseVisualStyleBackColor = true;
            this.btneliminar2.Click += new System.EventHandler(this.btneliminar2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(129, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btneliminar2);
            this.Controls.Add(this.btninsertar2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar1);
            this.Controls.Add(this.btninsertar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsertar1;
        private System.Windows.Forms.Button btneliminar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btninsertar2;
        private System.Windows.Forms.Button btneliminar2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

