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
    public partial class PorPrioridad : Form
    {
        int i = 0;
        public PorPrioridad()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int llegada, duracion, prioridad;
            String nombre_proceso, estado_proceso;

            if (!String.IsNullOrEmpty(mtb_llegada.Text) && !String.IsNullOrEmpty(mtb_duracion.Text) && !String.IsNullOrEmpty(mtb_prioridad.Text))
            {
                llegada = Convert.ToInt16(this.mtb_llegada.Text);
                duracion = Convert.ToInt16(this.mtb_duracion.Text);
                prioridad = Convert.ToInt16(this.mtb_prioridad.Text);
                nombre_proceso = "P" + (i + 1);
                estado_proceso = "en espera";

                this.dgv_procesos.Rows.Insert(i, nombre_proceso, llegada, duracion, prioridad, estado_proceso);
                this.dgv_procesos.Rows[i].Cells["estado"].Style.ForeColor = Color.DarkRed;

                this.mtb_llegada.Clear();
                this.mtb_duracion.Clear();
                this.mtb_prioridad.Clear();
                this.mtb_llegada.Focus();
                i++;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.dgv_procesos.Rows.Clear();
            this.pb_proceso.Value = 0;
            this.mtb_prioridad.Clear();
            this.mtb_duracion.Clear();
            this.mtb_llegada.Clear();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            /* obteniendo prioridades */
            List<int> list = new List<int>();
            for (int n = 0; n < this.dgv_procesos.Rows.Count; n++ )
            {
                int prioridad = Convert.ToInt16(this.dgv_procesos.Rows[n].Cells["prioridad"].Value);
                
                if( prioridad > 0 )
                    list.Add(prioridad);
            }
            // eliminar duplicados
            List<int> listaPrioridades = new List<int>();
            foreach ( int prioridad in list )
            {
                int repetida = 0;
                for ( int n = 0; n < listaPrioridades.Count; n++ )
                {
                    if ( prioridad == listaPrioridades[n] )
                    {
                        repetida++;
                        break;
                    }
                }
                if(repetida == 0)
                    listaPrioridades.Add(prioridad);
            }

            // ordenar en forma ascendente
            int tmp = 0;
            for (int i = 0; i < listaPrioridades.Count; i++ )
            {
                for (int j = 0; j < listaPrioridades.Count - 1; j++ )
                {
                    if ( listaPrioridades[j + 1] < listaPrioridades[j] )
                    {
                        tmp = listaPrioridades[j];
                        listaPrioridades[j] = listaPrioridades[j + 1];
                        listaPrioridades[j + 1] = tmp;
                    }
                }
            }

            foreach (int prioridad in listaPrioridades)
            {
                for (int n = 0; n < this.dgv_procesos.Rows.Count; n++)
                {
                    if (Convert.ToInt16(this.dgv_procesos.Rows[n].Cells["prioridad"].Value) == prioridad)
                    {
                        //ejecutar proceso
                        int duracion = Convert.ToInt16(this.dgv_procesos.Rows[n].Cells["duracion"].Value);
                        this.lbl_proceso.Text = "Ejecutando proceso " + this.dgv_procesos.Rows[n].Cells["proceso"].Value;
                        this.lbl_proceso.Update();
                        this.dgv_procesos.Rows[n].Cells["estado"].Value = "en ejecución";
                        this.dgv_procesos.Rows[n].Cells["estado"].Style.ForeColor = Color.DarkOrange;
                        this.dgv_procesos.Update();

                        // cargando progress bar
                        for (int p = 1; p <= duracion; p++)
                        {
                            this.pb_proceso.Value = (100 * p) / duracion;
                            Thread.Sleep(1000);
                        }

                        this.dgv_procesos.Rows[n].Cells["estado"].Value = "terminado";
                        this.dgv_procesos.Rows[n].Cells["estado"].Style.ForeColor = Color.DarkGreen;
                        this.dgv_procesos.Update();
                    }
                }
            }
            MessageBox.Show("Se terminó de ejecutar los procesos", "Finalizado", MessageBoxButtons.OK);
        }
    }
}
