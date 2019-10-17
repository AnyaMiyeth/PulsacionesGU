using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
namespace PulsacionesGUI
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
               dataGridView1.DataSource= PersonaService.Consultar(); 
        }
    }
}
