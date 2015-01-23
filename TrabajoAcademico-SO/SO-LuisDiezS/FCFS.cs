using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO_LuisDiezS
{
    public partial class FCFS : Form
    {
        int i = 0;

        public FCFS()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            String nombre_proceso;
            int duracion_proceso, hora_llegada_proceso;

            if (!String.IsNullOrEmpty(this.mtb_duracion.Text))
            {
                this.i++;
                nombre_proceso = "P" + this.i;
                duracion_proceso = Convert.ToInt16(this.mtb_duracion.Text);
                hora_llegada_proceso = Convert.ToInt16(this.mtb_llegada.Text);

                this.lb_proceso.Items.Add(nombre_proceso);
                this.lb_tllegada.Items.Add(hora_llegada_proceso);
                this.lb_duracion.Items.Add(duracion_proceso);
            }

            this.mtb_llegada.Clear();
            this.mtb_duracion.Clear();
            this.mtb_llegada.Focus();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.lb_proceso.Items.Clear();
            this.lb_duracion.Items.Clear();
            this.lb_tllegada.Items.Clear();
            this.lb_tinicio.Items.Clear();
            this.lb_tfin.Items.Clear();
            this.pb_proceso.Value = 0;
            this.mtb_llegada.Clear();
            this.mtb_duracion.Focus();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            int duracion, tiempo_inicio, tiempo_fin;
            this.lb_tinicio.Items.Clear();
            this.lb_tfin.Items.Clear();
            for (int n = 0; n < lb_proceso.Items.Count; n++)
            {
                //tiempo_inicio = Convert.ToDateTime(this.lb_tllegada.Items[n].ToString());
                if (n == 0)
                    tiempo_inicio = Convert.ToInt16(this.lb_tllegada.Items[n].ToString());
                else
                {
                    tiempo_inicio = Convert.ToInt16(this.lb_tfin.Items[n - 1].ToString());
                }
                duracion = Convert.ToInt16(this.lb_duracion.Items[n].ToString());
                tiempo_fin = tiempo_inicio + duracion;

                this.lbl_proceso.Text = "Ejecutando proceso " + this.lb_proceso.Items[n].ToString(); this.lbl_proceso.Update();
                this.lb_tinicio.Items.Add(tiempo_inicio); this.lb_tinicio.Update();

                for (int p = 1; p <= duracion; p++)
                {
                    this.pb_proceso.Value = (100 * p) / duracion;
                    Thread.Sleep(1000);
                }

                this.lb_tfin.Items.Add(tiempo_fin); this.lb_tfin.Update();

                Thread.Sleep(2000);
                this.pb_proceso.Value = 0;
            }
            MessageBox.Show("Se terminó de ejecutar los procesos", "Finalizado", MessageBoxButtons.OK);
        }
    }
}
