namespace Notas_Unidad_4
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
            this.button1 = new System.Windows.Forms.Button();
            this.text_nombre = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Saludo = new System.Windows.Forms.Label();
            this.FormFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelOcupation = new System.Windows.Forms.Label();
            this.BtnPerfil = new System.Windows.Forms.Button();
            this.rbtnLider = new System.Windows.Forms.RadioButton();
            this.rbtnTester = new System.Windows.Forms.RadioButton();
            this.rbtnDeveloper = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_nombre
            // 
            this.text_nombre.AccessibleName = "Text_Nombre";
            this.text_nombre.Location = new System.Drawing.Point(411, 25);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(129, 20);
            this.text_nombre.TabIndex = 2;
            this.text_nombre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Saludo
            // 
            this.Label_Saludo.AutoSize = true;
            this.Label_Saludo.Location = new System.Drawing.Point(300, 262);
            this.Label_Saludo.Name = "Label_Saludo";
            this.Label_Saludo.Size = new System.Drawing.Size(0, 13);
            this.Label_Saludo.TabIndex = 4;
            this.Label_Saludo.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormFecha
            // 
            this.FormFecha.Location = new System.Drawing.Point(411, 56);
            this.FormFecha.Name = "FormFecha";
            this.FormFecha.Size = new System.Drawing.Size(200, 20);
            this.FormFecha.TabIndex = 10;
            this.FormFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de Ingreso:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LabelOcupation
            // 
            this.LabelOcupation.AutoSize = true;
            this.LabelOcupation.Location = new System.Drawing.Point(300, 296);
            this.LabelOcupation.Name = "LabelOcupation";
            this.LabelOcupation.Size = new System.Drawing.Size(0, 13);
            this.LabelOcupation.TabIndex = 12;
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.Location = new System.Drawing.Point(430, 225);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnPerfil.TabIndex = 13;
            this.BtnPerfil.Text = "Ver Perfil";
            this.BtnPerfil.UseVisualStyleBackColor = true;
            this.BtnPerfil.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtnLider
            // 
            this.rbtnLider.AutoSize = true;
            this.rbtnLider.Location = new System.Drawing.Point(7, 43);
            this.rbtnLider.Name = "rbtnLider";
            this.rbtnLider.Size = new System.Drawing.Size(48, 17);
            this.rbtnLider.TabIndex = 14;
            this.rbtnLider.TabStop = true;
            this.rbtnLider.Text = "Lider";
            this.rbtnLider.UseVisualStyleBackColor = true;
            // 
            // rbtnTester
            // 
            this.rbtnTester.AutoSize = true;
            this.rbtnTester.Location = new System.Drawing.Point(136, 43);
            this.rbtnTester.Name = "rbtnTester";
            this.rbtnTester.Size = new System.Drawing.Size(55, 17);
            this.rbtnTester.TabIndex = 15;
            this.rbtnTester.TabStop = true;
            this.rbtnTester.Text = "Tester";
            this.rbtnTester.UseVisualStyleBackColor = true;
            this.rbtnTester.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnDeveloper
            // 
            this.rbtnDeveloper.AutoSize = true;
            this.rbtnDeveloper.Location = new System.Drawing.Point(246, 43);
            this.rbtnDeveloper.Name = "rbtnDeveloper";
            this.rbtnDeveloper.Size = new System.Drawing.Size(74, 17);
            this.rbtnDeveloper.TabIndex = 16;
            this.rbtnDeveloper.TabStop = true;
            this.rbtnDeveloper.Text = "Developer";
            this.rbtnDeveloper.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDeveloper);
            this.groupBox1.Controls.Add(this.rbtnLider);
            this.groupBox1.Controls.Add(this.rbtnTester);
            this.groupBox1.Location = new System.Drawing.Point(303, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 85);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puesto que desempeña:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelOcupation);
            this.Controls.Add(this.BtnPerfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormFecha);
            this.Controls.Add(this.Label_Saludo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox text_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Saludo;
        private System.Windows.Forms.DateTimePicker FormFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelOcupation;
        private System.Windows.Forms.Button BtnPerfil;
        private System.Windows.Forms.RadioButton rbtnLider;
        private System.Windows.Forms.RadioButton rbtnTester;
        private System.Windows.Forms.RadioButton rbtnDeveloper;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

