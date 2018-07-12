namespace VistaForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cursoAnio = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.cursoIngreso = new System.Windows.Forms.DateTimePicker();
            this.cursoDiv = new System.Windows.Forms.ComboBox();
            this.cursoDni = new System.Windows.Forms.TextBox();
            this.cursoApellido = new System.Windows.Forms.TextBox();
            this.cursoNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.alumnoDiv = new System.Windows.Forms.ComboBox();
            this.alumnoAnio = new System.Windows.Forms.NumericUpDown();
            this.alumnoLegajo = new System.Windows.Forms.TextBox();
            this.alumnoApellido = new System.Windows.Forms.TextBox();
            this.alumnoNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoAnio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cursoAnio);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cursoIngreso);
            this.groupBox1.Controls.Add(this.cursoDiv);
            this.groupBox1.Controls.Add(this.cursoDni);
            this.groupBox1.Controls.Add(this.cursoApellido);
            this.groupBox1.Controls.Add(this.cursoNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Año);
            this.groupBox1.Location = new System.Drawing.Point(32, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 656);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Curso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 97);
            this.button1.TabIndex = 15;
            this.button1.Text = "Crear Curso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCrearCurso_Click);
            // 
            // cursoAnio
            // 
            this.cursoAnio.Location = new System.Drawing.Point(257, 64);
            this.cursoAnio.Name = "cursoAnio";
            this.cursoAnio.Size = new System.Drawing.Size(120, 38);
            this.cursoAnio.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 97);
            this.button2.TabIndex = 16;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // cursoIngreso
            // 
            this.cursoIngreso.Location = new System.Drawing.Point(257, 436);
            this.cursoIngreso.Name = "cursoIngreso";
            this.cursoIngreso.Size = new System.Drawing.Size(513, 38);
            this.cursoIngreso.TabIndex = 10;
            // 
            // cursoDiv
            // 
            this.cursoDiv.FormattingEnabled = true;
            this.cursoDiv.Location = new System.Drawing.Point(257, 134);
            this.cursoDiv.Name = "cursoDiv";
            this.cursoDiv.Size = new System.Drawing.Size(121, 39);
            this.cursoDiv.TabIndex = 9;
            // 
            // cursoDni
            // 
            this.cursoDni.Location = new System.Drawing.Point(257, 348);
            this.cursoDni.Name = "cursoDni";
            this.cursoDni.Size = new System.Drawing.Size(331, 38);
            this.cursoDni.TabIndex = 8;
            // 
            // cursoApellido
            // 
            this.cursoApellido.Location = new System.Drawing.Point(257, 277);
            this.cursoApellido.Name = "cursoApellido";
            this.cursoApellido.Size = new System.Drawing.Size(331, 38);
            this.cursoApellido.TabIndex = 7;
            // 
            // cursoNombre
            // 
            this.cursoNombre.Location = new System.Drawing.Point(257, 207);
            this.cursoNombre.Name = "cursoNombre";
            this.cursoNombre.Size = new System.Drawing.Size(331, 38);
            this.cursoNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Division";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(18, 73);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(66, 32);
            this.Año.TabIndex = 0;
            this.Año.Text = "Año";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.alumnoDiv);
            this.groupBox2.Controls.Add(this.alumnoAnio);
            this.groupBox2.Controls.Add(this.alumnoLegajo);
            this.groupBox2.Controls.Add(this.alumnoApellido);
            this.groupBox2.Controls.Add(this.alumnoNombre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(926, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 656);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Alumno";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-870, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 66);
            this.button4.TabIndex = 15;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 97);
            this.button3.TabIndex = 17;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // alumnoDiv
            // 
            this.alumnoDiv.FormattingEnabled = true;
            this.alumnoDiv.Location = new System.Drawing.Point(257, 345);
            this.alumnoDiv.Name = "alumnoDiv";
            this.alumnoDiv.Size = new System.Drawing.Size(121, 39);
            this.alumnoDiv.TabIndex = 11;
            // 
            // alumnoAnio
            // 
            this.alumnoAnio.Location = new System.Drawing.Point(258, 270);
            this.alumnoAnio.Name = "alumnoAnio";
            this.alumnoAnio.Size = new System.Drawing.Size(120, 38);
            this.alumnoAnio.TabIndex = 13;
            // 
            // alumnoLegajo
            // 
            this.alumnoLegajo.Location = new System.Drawing.Point(248, 205);
            this.alumnoLegajo.Name = "alumnoLegajo";
            this.alumnoLegajo.Size = new System.Drawing.Size(331, 38);
            this.alumnoLegajo.TabIndex = 12;
            // 
            // alumnoApellido
            // 
            this.alumnoApellido.Location = new System.Drawing.Point(248, 134);
            this.alumnoApellido.Name = "alumnoApellido";
            this.alumnoApellido.Size = new System.Drawing.Size(331, 38);
            this.alumnoApellido.TabIndex = 11;
            // 
            // alumnoNombre
            // 
            this.alumnoNombre.Location = new System.Drawing.Point(248, 64);
            this.alumnoNombre.Name = "alumnoNombre";
            this.alumnoNombre.Size = new System.Drawing.Size(331, 38);
            this.alumnoNombre.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 32);
            this.label11.TabIndex = 9;
            this.label11.Text = "Division";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 32);
            this.label12.TabIndex = 8;
            this.label12.Text = "Año";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 32);
            this.label13.TabIndex = 7;
            this.label13.Text = "Legajo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 32);
            this.label14.TabIndex = 6;
            this.label14.Text = "Apellido";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 32);
            this.label15.TabIndex = 5;
            this.label15.Text = "Nombre";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 731);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1770, 464);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1224);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoAnio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker cursoIngreso;
        private System.Windows.Forms.ComboBox cursoDiv;
        private System.Windows.Forms.TextBox cursoDni;
        private System.Windows.Forms.TextBox cursoApellido;
        private System.Windows.Forms.TextBox cursoNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown alumnoAnio;
        private System.Windows.Forms.TextBox alumnoLegajo;
        private System.Windows.Forms.TextBox alumnoApellido;
        private System.Windows.Forms.TextBox alumnoNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown cursoAnio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox alumnoDiv;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

