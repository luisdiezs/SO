using System;
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
    public partial class DosNiveles : Form
    {
        int i = 0;
        public DosNiveles()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int llegada, duracion;
            String nombre_proceso, estado_proceso;

            if (!String.IsNullOrEmpty(mtb_llegada.Text) && !String.IsNullOrEmpty(mtb_duracion.Text))
            {
                llegada = Convert.ToInt16(this.mtb_llegada.Text);
                duracion = Convert.ToInt16(this.mtb_duracion.Text);
                nombre_proceso = "P" + (i + 1);
                estado_proceso = "en espera";

                this.dgv_procesos.Rows.Insert(i, nombre_proceso, llegada, duracion, "", estado_proceso);
                this.dgv_procesos.Rows[i].Cells["estado"].Style.ForeColor = Color.DarkRed;

                this.mtb_llegada.Clear();
                this.mtb_duracion.Clear();
                this.mtb_llegada.Focus();
                i++;
            }
        }
    }
}
