namespace ControlCalidad.Cliente.Presentacion.Vista
{
    partial class VistaSupCalidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNOP = new System.Windows.Forms.Label();
            this.lbLineaOP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.btnInspeccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usted Tiene una orden de produccion asignada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(197, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NºOP : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(200, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Linea : ";
            // 
            // lbNOP
            // 
            this.lbNOP.AutoSize = true;
            this.lbNOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNOP.Location = new System.Drawing.Point(272, 145);
            this.lbNOP.Name = "lbNOP";
            this.lbNOP.Size = new System.Drawing.Size(51, 16);
            this.lbNOP.TabIndex = 3;
            this.lbNOP.Text = "label4";
            // 
            // lbLineaOP
            // 
            this.lbLineaOP.AutoSize = true;
            this.lbLineaOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineaOP.Location = new System.Drawing.Point(272, 213);
            this.lbLineaOP.Name = "lbLineaOP";
            this.lbLineaOP.Size = new System.Drawing.Size(51, 16);
            this.lbLineaOP.TabIndex = 4;
            this.lbLineaOP.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(465, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado : ";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(534, 145);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(51, 16);
            this.lbEstado.TabIndex = 6;
            this.lbEstado.Text = "label7";
            // 
            // btnInspeccionar
            // 
            this.btnInspeccionar.Location = new System.Drawing.Point(349, 281);
            this.btnInspeccionar.Name = "btnInspeccionar";
            this.btnInspeccionar.Size = new System.Drawing.Size(134, 37);
            this.btnInspeccionar.TabIndex = 7;
            this.btnInspeccionar.Text = "Inspeccionar";
            this.btnInspeccionar.UseVisualStyleBackColor = true;
            this.btnInspeccionar.Click += new System.EventHandler(this.btnInspeccionar_Click);
            // 
            // VistaSupCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::ControlCalidad.Cliente.Presentacion.Properties.Resources.Freewallpaper99_com;
            this.ClientSize = new System.Drawing.Size(822, 459);
            this.Controls.Add(this.btnInspeccionar);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbLineaOP);
            this.Controls.Add(this.lbNOP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VistaSupCalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lineas";
            this.Load += new System.EventHandler(this.VistaSupCalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNOP;
        private System.Windows.Forms.Label lbLineaOP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Button btnInspeccionar;
    }
}