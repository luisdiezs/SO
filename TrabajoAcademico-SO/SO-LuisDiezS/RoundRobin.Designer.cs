﻿namespace SO_LuisDiezS
{
    partial class RoundRobin
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
            this.mtb_duracion = new System.Windows.Forms.MaskedTextBox();
            this.mtb_llegada = new System.Windows.Forms.MaskedTextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_procesos = new System.Windows.Forms.DataGridView();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.pb_proceso = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_cuanto = new System.Windows.Forms.MaskedTextBox();
            this.lb_cola = new System.Windows.Forms.ListBox();
            this.proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_proceso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procesos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtb_duracion);
            this.groupBox1.Controls.Add(this.mtb_llegada);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Proceso";
            // 
            // mtb_duracion
            // 
            this.mtb_duracion.Location = new System.Drawing.Point(113, 62);
            this.mtb_duracion.Mask = "99";
            this.mtb_duracion.Name = "mtb_duracion";
            this.mtb_duracion.Size = new System.Drawing.Size(51, 20);
            this.mtb_duracion.TabIndex = 1;
            // 
            // mtb_llegada
            // 
            this.mtb_llegada.Location = new System.Drawing.Point(113, 30);
            this.mtb_llegada.Mask = "99";
            this.mtb_llegada.Name = "mtb_llegada";
            this.mtb_llegada.Size = new System.Drawing.Size(51, 20);
            this.mtb_llegada.TabIndex = 0;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(97, 107);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "&Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(6, 107);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "&Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duración (sg):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo de llegada:";
            // 
            // dgv_procesos
            // 
            this.dgv_procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_procesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proceso,
            this.llegada,
            this.duracion,
            this.estado});
            this.dgv_procesos.Location = new System.Drawing.Point(217, 12);
            this.dgv_procesos.Name = "dgv_procesos";
            this.dgv_procesos.Size = new System.Drawing.Size(344, 201);
            this.dgv_procesos.TabIndex = 8;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(62, 261);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 9;
            this.btn_iniciar.Text = "&Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // pb_proceso
            // 
            this.pb_proceso.Location = new System.Drawing.Point(217, 261);
            this.pb_proceso.Name = "pb_proceso";
            this.pb_proceso.Size = new System.Drawing.Size(344, 23);
            this.pb_proceso.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cuanto:";
            // 
            // mtb_cuanto
            // 
            this.mtb_cuanto.Location = new System.Drawing.Point(100, 222);
            this.mtb_cuanto.Mask = "99";
            this.mtb_cuanto.Name = "mtb_cuanto";
            this.mtb_cuanto.Size = new System.Drawing.Size(51, 20);
            this.mtb_cuanto.TabIndex = 4;
            // 
            // lb_cola
            // 
            this.lb_cola.BackColor = System.Drawing.Color.RoyalBlue;
            this.lb_cola.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cola.ForeColor = System.Drawing.Color.White;
            this.lb_cola.FormattingEnabled = true;
            this.lb_cola.ItemHeight = 16;
            this.lb_cola.Location = new System.Drawing.Point(597, 27);
            this.lb_cola.Name = "lb_cola";
            this.lb_cola.Size = new System.Drawing.Size(31, 180);
            this.lb_cola.TabIndex = 12;
            // 
            // proceso
            // 
            this.proceso.HeaderText = "Proceso";
            this.proceso.Name = "proceso";
            this.proceso.ReadOnly = true;
            this.proceso.Width = 75;
            // 
            // llegada
            // 
            this.llegada.HeaderText = "Llegada";
            this.llegada.Name = "llegada";
            this.llegada.ReadOnly = true;
            this.llegada.Width = 75;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duración";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            this.duracion.Width = 75;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cola:";
            // 
            // lbl_proceso
            // 
            this.lbl_proceso.AutoSize = true;
            this.lbl_proceso.Location = new System.Drawing.Point(217, 242);
            this.lbl_proceso.Name = "lbl_proceso";
            this.lbl_proceso.Size = new System.Drawing.Size(0, 13);
            this.lbl_proceso.TabIndex = 14;
            // 
            // RoundRobin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 298);
            this.Controls.Add(this.lbl_proceso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_cola);
            this.Controls.Add(this.mtb_cuanto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_proceso);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.dgv_procesos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoundRobin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round Robin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtb_duracion;
        private System.Windows.Forms.MaskedTextBox mtb_llegada;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_procesos;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.ProgressBar pb_proceso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_cuanto;
        private System.Windows.Forms.ListBox lb_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_proceso;

    }
}