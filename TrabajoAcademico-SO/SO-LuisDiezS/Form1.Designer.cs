﻿namespace SO_LuisDiezS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesYControlDeProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundRobinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPrioridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIFoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sJFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colocaciónDeAlmacenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primerAjusteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mejorAjusteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peorAjusteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificaciónDeDiscosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fCFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesYControlDeProcesosToolStripMenuItem,
            this.colocaciónDeAlmacenamientoToolStripMenuItem,
            this.planificaciónDeDiscosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesYControlDeProcesosToolStripMenuItem
            // 
            this.operacionesYControlDeProcesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roundRobinToolStripMenuItem,
            this.porPrioridadToolStripMenuItem,
            this.fIFoToolStripMenuItem,
            this.sJFToolStripMenuItem,
            this.nivelesToolStripMenuItem});
            this.operacionesYControlDeProcesosToolStripMenuItem.Name = "operacionesYControlDeProcesosToolStripMenuItem";
            this.operacionesYControlDeProcesosToolStripMenuItem.Size = new System.Drawing.Size(203, 20);
            this.operacionesYControlDeProcesosToolStripMenuItem.Text = "Operaciones y Control de Procesos";
            // 
            // roundRobinToolStripMenuItem
            // 
            this.roundRobinToolStripMenuItem.Name = "roundRobinToolStripMenuItem";
            this.roundRobinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.roundRobinToolStripMenuItem.Text = "Round Robin";
            this.roundRobinToolStripMenuItem.Click += new System.EventHandler(this.roundRobinToolStripMenuItem_Click);
            // 
            // porPrioridadToolStripMenuItem
            // 
            this.porPrioridadToolStripMenuItem.Name = "porPrioridadToolStripMenuItem";
            this.porPrioridadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porPrioridadToolStripMenuItem.Text = "Por Prioridad";
            this.porPrioridadToolStripMenuItem.Click += new System.EventHandler(this.porPrioridadToolStripMenuItem_Click);
            // 
            // fIFoToolStripMenuItem
            // 
            this.fIFoToolStripMenuItem.Name = "fIFoToolStripMenuItem";
            this.fIFoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fIFoToolStripMenuItem.Text = "FIFO";
            this.fIFoToolStripMenuItem.Click += new System.EventHandler(this.fIFoToolStripMenuItem_Click);
            // 
            // sJFToolStripMenuItem
            // 
            this.sJFToolStripMenuItem.Name = "sJFToolStripMenuItem";
            this.sJFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sJFToolStripMenuItem.Text = "SJF";
            this.sJFToolStripMenuItem.Click += new System.EventHandler(this.sJFToolStripMenuItem_Click);
            // 
            // nivelesToolStripMenuItem
            // 
            this.nivelesToolStripMenuItem.Name = "nivelesToolStripMenuItem";
            this.nivelesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nivelesToolStripMenuItem.Text = "Dos Niveles";
            this.nivelesToolStripMenuItem.Click += new System.EventHandler(this.nivelesToolStripMenuItem_Click);
            // 
            // colocaciónDeAlmacenamientoToolStripMenuItem
            // 
            this.colocaciónDeAlmacenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primerAjusteToolStripMenuItem,
            this.mejorAjusteToolStripMenuItem,
            this.peorAjusteToolStripMenuItem});
            this.colocaciónDeAlmacenamientoToolStripMenuItem.Name = "colocaciónDeAlmacenamientoToolStripMenuItem";
            this.colocaciónDeAlmacenamientoToolStripMenuItem.Size = new System.Drawing.Size(189, 20);
            this.colocaciónDeAlmacenamientoToolStripMenuItem.Text = "Colocación de Almacenamiento";
            // 
            // primerAjusteToolStripMenuItem
            // 
            this.primerAjusteToolStripMenuItem.Name = "primerAjusteToolStripMenuItem";
            this.primerAjusteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.primerAjusteToolStripMenuItem.Text = "Primer Ajuste";
            // 
            // mejorAjusteToolStripMenuItem
            // 
            this.mejorAjusteToolStripMenuItem.Name = "mejorAjusteToolStripMenuItem";
            this.mejorAjusteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.mejorAjusteToolStripMenuItem.Text = "Mejor Ajuste";
            // 
            // peorAjusteToolStripMenuItem
            // 
            this.peorAjusteToolStripMenuItem.Name = "peorAjusteToolStripMenuItem";
            this.peorAjusteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.peorAjusteToolStripMenuItem.Text = "Peor Ajuste";
            // 
            // planificaciónDeDiscosToolStripMenuItem
            // 
            this.planificaciónDeDiscosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fCFSToolStripMenuItem,
            this.sSTFToolStripMenuItem});
            this.planificaciónDeDiscosToolStripMenuItem.Name = "planificaciónDeDiscosToolStripMenuItem";
            this.planificaciónDeDiscosToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.planificaciónDeDiscosToolStripMenuItem.Text = "Planificación de Discos";
            // 
            // fCFSToolStripMenuItem
            // 
            this.fCFSToolStripMenuItem.Name = "fCFSToolStripMenuItem";
            this.fCFSToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.fCFSToolStripMenuItem.Text = "FCFS";
            this.fCFSToolStripMenuItem.Click += new System.EventHandler(this.fCFSToolStripMenuItem_Click);
            // 
            // sSTFToolStripMenuItem
            // 
            this.sSTFToolStripMenuItem.Name = "sSTFToolStripMenuItem";
            this.sSTFToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sSTFToolStripMenuItem.Text = "SSTF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 434);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesYControlDeProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colocaciónDeAlmacenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificaciónDeDiscosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fCFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundRobinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPrioridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIFoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primerAjusteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mejorAjusteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peorAjusteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sJFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelesToolStripMenuItem;
    }
}

