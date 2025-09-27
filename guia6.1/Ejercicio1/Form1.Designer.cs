namespace Ejercicio1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            tbPatente = new TextBox();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            label3 = new Label();
            label2 = new Label();
            DNI = new Label();
            btnVer = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(tbPatente);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DNI);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta registros";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(306, 26);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(108, 88);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(110, 87);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(176, 27);
            tbPatente.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(110, 56);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(176, 27);
            tbNombre.TabIndex = 4;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(110, 26);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(176, 27);
            tbDNI.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 95);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 64);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Location = new Point(26, 34);
            DNI.Name = "DNI";
            DNI.Size = new Size(35, 20);
            DNI.TabIndex = 0;
            DNI.Text = "DNI";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(170, 156);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(128, 47);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver registros";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 211);
            Controls.Add(btnVer);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrar;
        private TextBox tbPatente;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private Label label3;
        private Label label2;
        private Label DNI;
        private Button btnVer;
    }
}
