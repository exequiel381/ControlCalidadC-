namespace ControlCalidad.Cliente.Presentacion.Vista
{
    partial class nuevaOP
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
            this.cbxModelos = new System.Windows.Forms.ComboBox();
            this.cbxColores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxLineasDisponibles = new System.Windows.Forms.ComboBox();
            this.cbxSupervisoresDisponibles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbObjetivoModelo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxModelos
            // 
            this.cbxModelos.FormattingEnabled = true;
            this.cbxModelos.Location = new System.Drawing.Point(366, 218);
            this.cbxModelos.Margin = new System.Windows.Forms.Padding(4);
            this.cbxModelos.Name = "cbxModelos";
            this.cbxModelos.Size = new System.Drawing.Size(349, 24);
            this.cbxModelos.TabIndex = 0;
            this.cbxModelos.SelectedIndexChanged += new System.EventHandler(this.setObjetivo);
            this.cbxModelos.DisplayMemberChanged += new System.EventHandler(this.setObjetivo);
            // 
            // cbxColores
            // 
            this.cbxColores.FormattingEnabled = true;
            this.cbxColores.Location = new System.Drawing.Point(366, 352);
            this.cbxColores.Margin = new System.Windows.Forms.Padding(4);
            this.cbxColores.Name = "cbxColores";
            this.cbxColores.Size = new System.Drawing.Size(349, 24);
            this.cbxColores.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 360);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Objetivo por hora del modelo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Linea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Supervisor de calidad";
            // 
            // cbxLineasDisponibles
            // 
            this.cbxLineasDisponibles.FormattingEnabled = true;
            this.cbxLineasDisponibles.Location = new System.Drawing.Point(223, 111);
            this.cbxLineasDisponibles.Name = "cbxLineasDisponibles";
            this.cbxLineasDisponibles.Size = new System.Drawing.Size(121, 24);
            this.cbxLineasDisponibles.TabIndex = 7;
            // 
            // cbxSupervisoresDisponibles
            // 
            this.cbxSupervisoresDisponibles.FormattingEnabled = true;
            this.cbxSupervisoresDisponibles.Location = new System.Drawing.Point(757, 111);
            this.cbxSupervisoresDisponibles.Name = "cbxSupervisoresDisponibles";
            this.cbxSupervisoresDisponibles.Size = new System.Drawing.Size(161, 24);
            this.cbxSupervisoresDisponibles.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(35, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Crear Nueva Orden de Produccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(568, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "______________________________________________________________________";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Crear Nueva Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbObjetivoModelo
            // 
            this.lbObjetivoModelo.AutoSize = true;
            this.lbObjetivoModelo.Location = new System.Drawing.Point(498, 290);
            this.lbObjetivoModelo.Name = "lbObjetivoModelo";
            this.lbObjetivoModelo.Size = new System.Drawing.Size(28, 16);
            this.lbObjetivoModelo.TabIndex = 12;
            this.lbObjetivoModelo.Text = "----";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(366, 167);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(152, 22);
            this.txtNumero.TabIndex = 14;
            // 
            // nuevaOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlCalidad.Cliente.Presentacion.Properties.Resources.Freewallpaper99_com;
            this.ClientSize = new System.Drawing.Size(983, 503);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbObjetivoModelo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxSupervisoresDisponibles);
            this.Controls.Add(this.cbxLineasDisponibles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxColores);
            this.Controls.Add(this.cbxModelos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nuevaOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nuevaOP";
            this.Load += new System.EventHandler(this.nuevaOP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxModelos;
        private System.Windows.Forms.ComboBox cbxColores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxLineasDisponibles;
        private System.Windows.Forms.ComboBox cbxSupervisoresDisponibles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbObjetivoModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
    }
}