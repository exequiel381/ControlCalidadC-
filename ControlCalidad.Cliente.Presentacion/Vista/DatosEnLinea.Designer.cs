﻿namespace ControlCalidad.Cliente.Presentacion.Vista
{
    partial class DatosEnLinea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosEnLinea));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DerReproceso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DerObservado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IzqReproceso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzqObservado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbLinea = new System.Windows.Forms.Label();
            this.lbNOP = new System.Windows.Forms.Label();
            this.lbTurno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbParesDePrimera = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.lbObj = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DerReproceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DerObservado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzqReproceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzqObservado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.DarkRed;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizar.Location = new System.Drawing.Point(1077, 43);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(175, 50);
            this.btnFinalizar.TabIndex = 32;
            this.btnFinalizar.Text = "Finalizar Revision";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.DerReproceso);
            this.panel2.Controls.Add(this.DerObservado);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(641, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 476);
            this.panel2.TabIndex = 31;
            // 
            // DerReproceso
            // 
            this.DerReproceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DerReproceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.DerReproceso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DerReproceso.Location = new System.Drawing.Point(345, 61);
            this.DerReproceso.MultiSelect = false;
            this.DerReproceso.Name = "DerReproceso";
            this.DerReproceso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DerReproceso.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DerReproceso.RowTemplate.Height = 40;
            this.DerReproceso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DerReproceso.Size = new System.Drawing.Size(240, 412);
            this.DerReproceso.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // DerObservado
            // 
            this.DerObservado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DerObservado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DerObservado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DerObservado.Location = new System.Drawing.Point(16, 61);
            this.DerObservado.MultiSelect = false;
            this.DerObservado.Name = "DerObservado";
            this.DerObservado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DerObservado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DerObservado.RowTemplate.Height = 40;
            this.DerObservado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DerObservado.Size = new System.Drawing.Size(240, 412);
            this.DerObservado.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(412, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "REPROCESO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(70, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "OBSERVADO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(219, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "PIE DERECHO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.IzqReproceso);
            this.panel1.Controls.Add(this.IzqObservado);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(16, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 476);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // IzqReproceso
            // 
            this.IzqReproceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IzqReproceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.IzqReproceso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.IzqReproceso.Location = new System.Drawing.Point(311, 61);
            this.IzqReproceso.MultiSelect = false;
            this.IzqReproceso.Name = "IzqReproceso";
            this.IzqReproceso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzqReproceso.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.IzqReproceso.RowTemplate.Height = 40;
            this.IzqReproceso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IzqReproceso.Size = new System.Drawing.Size(240, 412);
            this.IzqReproceso.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // IzqObservado
            // 
            this.IzqObservado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IzqObservado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Detalle,
            this.Cantidad});
            this.IzqObservado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.IzqObservado.Location = new System.Drawing.Point(19, 61);
            this.IzqObservado.MultiSelect = false;
            this.IzqObservado.Name = "IzqObservado";
            this.IzqObservado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzqObservado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.IzqObservado.RowTemplate.Height = 40;
            this.IzqObservado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IzqObservado.Size = new System.Drawing.Size(240, 412);
            this.IzqObservado.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(356, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "REPROCESO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(79, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "OBSERVADO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(193, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "PIE IZQUIERDO";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(673, 46);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(67, 20);
            this.lbUsuario.TabIndex = 27;
            this.lbUsuario.Text = "label10";
            // 
            // lbLinea
            // 
            this.lbLinea.AutoSize = true;
            this.lbLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinea.Location = new System.Drawing.Point(873, 106);
            this.lbLinea.Name = "lbLinea";
            this.lbLinea.Size = new System.Drawing.Size(57, 20);
            this.lbLinea.TabIndex = 26;
            this.lbLinea.Text = "label9";
            // 
            // lbNOP
            // 
            this.lbNOP.AutoSize = true;
            this.lbNOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNOP.Location = new System.Drawing.Point(380, 107);
            this.lbNOP.Name = "lbNOP";
            this.lbNOP.Size = new System.Drawing.Size(57, 20);
            this.lbNOP.TabIndex = 25;
            this.lbNOP.Text = "label8";
            // 
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurno.Location = new System.Drawing.Point(631, 107);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(57, 20);
            this.lbTurno.TabIndex = 24;
            this.lbTurno.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(798, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Linea :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(544, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Turno :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(302, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nº OP : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(598, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Usuario : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Datos en Linea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "_________________________________________________________";
            // 
            // lbParesDePrimera
            // 
            this.lbParesDePrimera.AutoSize = true;
            this.lbParesDePrimera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParesDePrimera.Location = new System.Drawing.Point(693, 660);
            this.lbParesDePrimera.Name = "lbParesDePrimera";
            this.lbParesDePrimera.Size = new System.Drawing.Size(77, 24);
            this.lbParesDePrimera.TabIndex = 33;
            this.lbParesDePrimera.Text = "label14";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(467, 660);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Pares de primera :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(224, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 41);
            this.button1.TabIndex = 35;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromedio.Location = new System.Drawing.Point(1118, 697);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(57, 20);
            this.lbPromedio.TabIndex = 39;
            this.lbPromedio.Text = "label7";
            // 
            // lbObj
            // 
            this.lbObj.AutoSize = true;
            this.lbObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObj.Location = new System.Drawing.Point(1118, 675);
            this.lbObj.Name = "lbObj";
            this.lbObj.Size = new System.Drawing.Size(57, 20);
            this.lbObj.TabIndex = 38;
            this.lbObj.Text = "label7";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(911, 697);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(201, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "Promedio real por hora :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(911, 675);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Objetivo por hora :";
            // 
            // DatosEnLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 744);
            this.Controls.Add(this.lbPromedio);
            this.Controls.Add(this.lbObj);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbParesDePrimera);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbLinea);
            this.Controls.Add(this.lbNOP);
            this.Controls.Add(this.lbTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DatosEnLinea";
            this.Text = "DatosEnLinea";
            this.Load += new System.EventHandler(this.DatosEnLinea_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DerReproceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DerObservado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzqReproceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzqObservado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DerReproceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView DerObservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView IzqReproceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView IzqObservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbLinea;
        private System.Windows.Forms.Label lbNOP;
        private System.Windows.Forms.Label lbTurno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbParesDePrimera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Label lbObj;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}