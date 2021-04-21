
namespace Calculadora {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.botonDel = new System.Windows.Forms.Button();
            this.botonAc = new System.Windows.Forms.Button();
            this.botonDividir = new System.Windows.Forms.Button();
            this.botonMultiplicar = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.botonRestar = new System.Windows.Forms.Button();
            this.botonSumar = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.botonCerrarParentesis = new System.Windows.Forms.Button();
            this.botonAbrirParentesis = new System.Windows.Forms.Button();
            this.botonIgual = new System.Windows.Forms.Button();
            this.botonPunto = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boton7
            // 
            this.boton7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton7.Location = new System.Drawing.Point(23, 136);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(45, 45);
            this.boton7.TabIndex = 1;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = false;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // boton8
            // 
            this.boton8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton8.Location = new System.Drawing.Point(74, 136);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(45, 45);
            this.boton8.TabIndex = 2;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = false;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton9.Location = new System.Drawing.Point(125, 136);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(45, 45);
            this.boton9.TabIndex = 3;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = false;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // botonDel
            // 
            this.botonDel.BackColor = System.Drawing.Color.IndianRed;
            this.botonDel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonDel.Location = new System.Drawing.Point(125, 289);
            this.botonDel.Name = "botonDel";
            this.botonDel.Size = new System.Drawing.Size(45, 45);
            this.botonDel.TabIndex = 4;
            this.botonDel.Text = "←";
            this.botonDel.UseVisualStyleBackColor = false;
            this.botonDel.Click += new System.EventHandler(this.botonDel_Click);
            // 
            // botonAc
            // 
            this.botonAc.BackColor = System.Drawing.Color.IndianRed;
            this.botonAc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAc.Location = new System.Drawing.Point(23, 85);
            this.botonAc.Name = "botonAc";
            this.botonAc.Size = new System.Drawing.Size(45, 45);
            this.botonAc.TabIndex = 5;
            this.botonAc.Text = "AC";
            this.botonAc.UseVisualStyleBackColor = false;
            this.botonAc.Click += new System.EventHandler(this.botonAc_Click);
            // 
            // botonDividir
            // 
            this.botonDividir.BackColor = System.Drawing.Color.OliveDrab;
            this.botonDividir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDividir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonDividir.Location = new System.Drawing.Point(176, 187);
            this.botonDividir.Name = "botonDividir";
            this.botonDividir.Size = new System.Drawing.Size(45, 45);
            this.botonDividir.TabIndex = 10;
            this.botonDividir.Text = "/";
            this.botonDividir.UseVisualStyleBackColor = false;
            this.botonDividir.Click += new System.EventHandler(this.botonDividir_Click);
            // 
            // botonMultiplicar
            // 
            this.botonMultiplicar.BackColor = System.Drawing.Color.OliveDrab;
            this.botonMultiplicar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMultiplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonMultiplicar.Location = new System.Drawing.Point(176, 85);
            this.botonMultiplicar.Name = "botonMultiplicar";
            this.botonMultiplicar.Size = new System.Drawing.Size(45, 45);
            this.botonMultiplicar.TabIndex = 9;
            this.botonMultiplicar.Text = "*";
            this.botonMultiplicar.UseVisualStyleBackColor = false;
            this.botonMultiplicar.Click += new System.EventHandler(this.botonMultiplicar_Click);
            // 
            // boton6
            // 
            this.boton6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton6.Location = new System.Drawing.Point(125, 187);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(45, 45);
            this.boton6.TabIndex = 8;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = false;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton5.Location = new System.Drawing.Point(74, 187);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(45, 45);
            this.boton5.TabIndex = 7;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton4
            // 
            this.boton4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton4.Location = new System.Drawing.Point(23, 187);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(45, 45);
            this.boton4.TabIndex = 6;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // botonRestar
            // 
            this.botonRestar.BackColor = System.Drawing.Color.OliveDrab;
            this.botonRestar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRestar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonRestar.Location = new System.Drawing.Point(176, 136);
            this.botonRestar.Name = "botonRestar";
            this.botonRestar.Size = new System.Drawing.Size(45, 45);
            this.botonRestar.TabIndex = 15;
            this.botonRestar.Text = "-";
            this.botonRestar.UseVisualStyleBackColor = false;
            this.botonRestar.Click += new System.EventHandler(this.botonRestar_Click);
            // 
            // botonSumar
            // 
            this.botonSumar.BackColor = System.Drawing.Color.OliveDrab;
            this.botonSumar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSumar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonSumar.Location = new System.Drawing.Point(176, 238);
            this.botonSumar.Name = "botonSumar";
            this.botonSumar.Size = new System.Drawing.Size(45, 45);
            this.botonSumar.TabIndex = 14;
            this.botonSumar.Text = "+";
            this.botonSumar.UseVisualStyleBackColor = false;
            this.botonSumar.Click += new System.EventHandler(this.botonSumar_Click);
            // 
            // boton3
            // 
            this.boton3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton3.Location = new System.Drawing.Point(125, 238);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(45, 45);
            this.boton3.TabIndex = 13;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton2.Location = new System.Drawing.Point(74, 238);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(45, 45);
            this.boton2.TabIndex = 12;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton1.Location = new System.Drawing.Point(23, 238);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(45, 45);
            this.boton1.TabIndex = 11;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // botonCerrarParentesis
            // 
            this.botonCerrarParentesis.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.botonCerrarParentesis.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarParentesis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonCerrarParentesis.Location = new System.Drawing.Point(125, 85);
            this.botonCerrarParentesis.Name = "botonCerrarParentesis";
            this.botonCerrarParentesis.Size = new System.Drawing.Size(45, 45);
            this.botonCerrarParentesis.TabIndex = 20;
            this.botonCerrarParentesis.Text = ")";
            this.botonCerrarParentesis.UseVisualStyleBackColor = false;
            this.botonCerrarParentesis.Click += new System.EventHandler(this.botonCerrarParentesis_Click);
            // 
            // botonAbrirParentesis
            // 
            this.botonAbrirParentesis.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.botonAbrirParentesis.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAbrirParentesis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAbrirParentesis.Location = new System.Drawing.Point(74, 85);
            this.botonAbrirParentesis.Name = "botonAbrirParentesis";
            this.botonAbrirParentesis.Size = new System.Drawing.Size(45, 45);
            this.botonAbrirParentesis.TabIndex = 19;
            this.botonAbrirParentesis.Text = "(";
            this.botonAbrirParentesis.UseVisualStyleBackColor = false;
            this.botonAbrirParentesis.Click += new System.EventHandler(this.botonAbrirParentesis_Click);
            // 
            // botonIgual
            // 
            this.botonIgual.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonIgual.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIgual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonIgual.Location = new System.Drawing.Point(176, 289);
            this.botonIgual.Name = "botonIgual";
            this.botonIgual.Size = new System.Drawing.Size(45, 45);
            this.botonIgual.TabIndex = 18;
            this.botonIgual.Text = "=";
            this.botonIgual.UseVisualStyleBackColor = false;
            this.botonIgual.Click += new System.EventHandler(this.botonIgual_Click);
            // 
            // botonPunto
            // 
            this.botonPunto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.botonPunto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonPunto.Location = new System.Drawing.Point(23, 289);
            this.botonPunto.Name = "botonPunto";
            this.botonPunto.Size = new System.Drawing.Size(45, 45);
            this.botonPunto.TabIndex = 17;
            this.botonPunto.Text = ".";
            this.botonPunto.UseVisualStyleBackColor = false;
            this.botonPunto.Click += new System.EventHandler(this.botonPunto_Click);
            // 
            // boton0
            // 
            this.boton0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boton0.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton0.Location = new System.Drawing.Point(74, 289);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(45, 45);
            this.boton0.TabIndex = 16;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = false;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(246, 349);
            this.Controls.Add(this.botonCerrarParentesis);
            this.Controls.Add(this.botonAbrirParentesis);
            this.Controls.Add(this.botonIgual);
            this.Controls.Add(this.botonPunto);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.botonRestar);
            this.Controls.Add(this.botonSumar);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.botonDividir);
            this.Controls.Add(this.botonMultiplicar);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.botonAc);
            this.Controls.Add(this.botonDel);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculadora INF328";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button botonDel;
        private System.Windows.Forms.Button botonAc;
        private System.Windows.Forms.Button botonDividir;
        private System.Windows.Forms.Button botonMultiplicar;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button botonRestar;
        private System.Windows.Forms.Button botonSumar;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button botonCerrarParentesis;
        private System.Windows.Forms.Button botonAbrirParentesis;
        private System.Windows.Forms.Button botonIgual;
        private System.Windows.Forms.Button botonPunto;
        private System.Windows.Forms.Button boton0;
    }
}

