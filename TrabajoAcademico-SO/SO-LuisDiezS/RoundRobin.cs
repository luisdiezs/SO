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
    public partial class RoundRobin : Form
    {
        int i = 0;
        public RoundRobin()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int llegada, duracion;
            String nombre_proceso, estado_proceso;

            if(!String.IsNullOrEmpty(mtb_llegada.Text) && !String.IsNullOrEmpty(mtb_duracion.Text))
            {
                llegada = Convert.ToInt16(this.mtb_llegada.Text);
                duracion = Convert.ToInt16(this.mtb_duracion.Text);
                nombre_proceso = "P" + (i + 1);
                estado_proceso = "en espera";

                this.dgv_procesos.Rows.Insert(i, nombre_proceso, llegada, duracion, estado_proceso);

                this.mtb_llegada.Clear();
                this.mtb_duracion.Clear();
                this.mtb_llegada.Focus();

                i++;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.dgv_procesos.Rows.Clear();
            this.pb_proceso.Value = 0;
            this.lb_cola.Items.Clear();
            this.mtb_cuanto.Clear();
            this.mtb_duracion.Clear();
            this.mtb_llegada.Clear();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            int tiempo_actual, tiempo_restante, duracion_proceso_actual, cuanto, index_proceso_actual, completado, rafaga;
            String proceso_actual, estado;

            tiempo_actual = 0;
            duracion_proceso_actual = 0;
            index_proceso_actual = 0;
            completado = 0;
            rafaga = 0;
            cuanto = Convert.ToInt16(this.mtb_cuanto.Text);
            estado = "en espera";
            this.lb_cola.Items.Add(this.dgv_procesos.Rows[0].Cells["proceso"].Value.ToString());
            this.lb_cola.Update();

            do
            {
                rafaga++;
                do
                {
                    /* obteniendo proceso a ejecutar desde la cola */
                    proceso_actual = this.lb_cola.Items[0].ToString();

                    for (int n = 0; n < this.dgv_procesos.Rows.Count; n++)
                    {
                        if (this.dgv_procesos.Rows[n].Cells["proceso"].Value.ToString() == proceso_actual)
                        {
                            index_proceso_actual = n;
                            break;
                        }
                    }

                    /* ejecutando proceso actual */
                    this.lbl_proceso.Text = "Ejecutando proceso " + this.dgv_procesos.Rows[index_proceso_actual].Cells["proceso"].Value; this.lbl_proceso.Update();
                    this.lb_cola.Items.RemoveAt(0);
                    this.lb_cola.Update();

                    this.dgv_procesos.Rows[index_proceso_actual].Cells["estado"].Value = "en ejecución";
                    this.dgv_procesos.Update();

                    for (int p = 1; p <= cuanto; p++)
                    {
                        this.pb_proceso.Value = (100 * p) / cuanto;
                        Thread.Sleep(1000);
                        tiempo_actual++;

                        /* agregando procesos a la cola según tiempo de llegada */
                        if (rafaga == 1)
                        {
                            for (int n = 0; n < this.dgv_procesos.Rows.Count - 1; n++)
                            {
                                if (Convert.ToInt16(this.dgv_procesos.Rows[n].Cells["llegada"].Value.ToString()) == tiempo_actual && this.dgv_procesos.Rows[n].Cells["estado"].Value.ToString() == "en espera")
                                {
                                    this.lb_cola.Items.Add(this.dgv_procesos.Rows[n].Cells["proceso"].Value.ToString());
                                    this.lb_cola.Update();
                                    break;
                                }
                            }
                        }

                        /* evaluando duración del proceso */
                        duracion_proceso_actual = Convert.ToInt16(this.dgv_procesos.Rows[index_proceso_actual].Cells["duracion"].Value.ToString());
                        tiempo_restante = duracion_proceso_actual - 1;
                        this.dgv_procesos.Rows[index_proceso_actual].Cells["duracion"].Value = tiempo_restante;
                        this.dgv_procesos.Update();

                        if (p == 2 && tiempo_restante > 0)
                        {
                            this.lb_cola.Items.Add(this.dgv_procesos.Rows[index_proceso_actual].Cells["proceso"].Value.ToString());
                            this.lb_cola.Update();
                        }
                        else if (tiempo_restante == 0)
                        {
                            estado = "terminado";
                            break;
                        }
                    }

                    this.dgv_procesos.Rows[index_proceso_actual].Cells["estado"].Value = estado;
                    this.dgv_procesos.Update();

                    Thread.Sleep(1500);
                } while (this.lb_cola.Items.Count > 0);

                /* verificando que todos los procesos esten terminados */
                for (int n = 0; n <= this.dgv_procesos.Rows.Count - 1; n++)
                {
                    if (this.dgv_procesos.Rows[n].Cells["estado"].Value.ToString() == "terminado")
                    {
                        completado = 1;
                    }
                    else
                    {
                        completado = 0;
                        break;
                    }
                }

            } while (completado == 0);
            MessageBox.Show("Se terminó de ejecutar los procesos", "Finalizado", MessageBoxButtons.OK);
        }
    }
}
