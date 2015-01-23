namespace SO_LuisDiezS
{
    partial class FCFS
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
            this.lb_proceso = new System.Windows.Forms.ListBox();
            this.lb_tllegada = new System.Windows.Forms.ListBox();
            this.lb_duracion = new System.Windows.Forms.ListBox();
            this.lb_tinicio = new System.Windows.Forms.ListBox();
            this.lb_tfin = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pb_proceso = new System.Windows.Forms.ProgressBar();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_proceso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 136);
            this.groupBox1.TabIndex = 0;
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
            // lb_proceso
            // 
            this.lb_proceso.FormattingEnabled = true;
            this.lb_proceso.Location = new System.Drawing.Point(233, 31);
            this.lb_proceso.Name = "lb_proceso";
            this.lb_proceso.Size = new System.Drawing.Size(49, 134);
            this.lb_proceso.TabIndex = 3;
            // 
            // lb_tllegada
            // 
            this.lb_tllegada.FormattingEnabled = true;
            this.lb_tllegada.Location = new System.Drawing.Point(321, 31);
            this.lb_tllegada.Name = "lb_tllegada";
            this.lb_tllegada.Size = new System.Drawing.Size(49, 134);
            this.lb_tllegada.TabIndex = 5;
            // 
            // lb_duracion
            // 
            this.lb_duracion.FormattingEnabled = true;
            this.lb_duracion.Location = new System.Drawing.Point(409, 31);
            this.lb_duracion.Name = "lb_duracion";
            this.lb_duracion.Size = new System.Drawing.Size(49, 134);
            this.lb_duracion.TabIndex = 7;
            // 
            // lb_tinicio
            // 
            this.lb_tinicio.FormattingEnabled = true;
            this.lb_tinicio.Location = new System.Drawing.Point(497, 32);
            this.lb_tinicio.Name = "lb_tinicio";
            this.lb_tinicio.Size = new System.Drawing.Size(49, 134);
            this.lb_tinicio.TabIndex = 9;
            // 
            // lb_tfin
            // 
            this.lb_tfin.FormattingEnabled = true;
            this.lb_tfin.Location = new System.Drawing.Point(585, 32);
            this.lb_tfin.Name = "lb_tfin";
            this.lb_tfin.Size = new System.Drawing.Size(49, 134);
            this.lb_tfin.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proceso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Llegada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Duración:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fin:";
            // 
            // pb_proceso
            // 
            this.pb_proceso.Location = new System.Drawing.Point(233, 222);
            this.pb_proceso.Name = "pb_proceso";
            this.pb_proceso.Size = new System.Drawing.Size(401, 23);
            this.pb_proceso.TabIndex = 13;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(74, 222);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "&Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // lbl_proceso
            // 
            this.lbl_proceso.AutoSize = true;
            this.lbl_proceso.Location = new System.Drawing.Point(233, 203);
            this.lbl_proceso.Name = "lbl_proceso";
            this.lbl_proceso.Size = new System.Drawing.Size(0, 13);
            this.lbl_proceso.TabIndex = 12;
            // 
            // FCFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 280);
            this.Controls.Add(this.lbl_proceso);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.pb_proceso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_tfin);
            this.Controls.Add(this.lb_tinicio);
            this.Controls.Add(this.lb_duracion);
            this.Controls.Add(this.lb_tllegada);
            this.Controls.Add(this.lb_proceso);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FCFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCFS (First Come, First Served)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ListBox lb_proceso;
        private System.Windows.Forms.ListBox lb_tllegada;
        private System.Windows.Forms.ListBox lb_duracion;
        private System.Windows.Forms.ListBox lb_tinicio;
        private System.Windows.Forms.ListBox lb_tfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pb_proceso;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_proceso;
    }
}