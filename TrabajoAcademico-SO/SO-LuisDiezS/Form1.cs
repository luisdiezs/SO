﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO_LuisDiezS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fCFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCFS formFCFS = new FCFS();
            formFCFS.MdiParent = this;
            formFCFS.Text = "FCFS (First Come, First Served)";
            formFCFS.Show();
        }

        private void roundRobinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoundRobin formRoundRobin = new RoundRobin();
            formRoundRobin.MdiParent = this;
            formRoundRobin.Show();
        }

        private void fIFoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCFS formFCFS = new FCFS();
            formFCFS.MdiParent = this;
            formFCFS.Text = "FIFO (First In, First Out)";
            formFCFS.Show();
        }

        private void porPrioridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PorPrioridad formPorPrioridad = new PorPrioridad();
            formPorPrioridad.MdiParent = this;
            formPorPrioridad.Show();
        }

        private void sJFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SJF formSJF = new SJF();
            formSJF.MdiParent = this;
            formSJF.Show();
        }

        private void nivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosNiveles formDosNiveles = new DosNiveles();
            formDosNiveles.MdiParent = this;
            formDosNiveles.Show();
        }
    }
}
