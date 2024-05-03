using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITienda_TP
{
    public partial class FmrAdministrador : Form
    {
        public FmrAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FmrAdministrador_Load(object sender, EventArgs e)
        {
           grilla_empleados.DataSource = grilla_empleados;
        }

        private void grilla_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
