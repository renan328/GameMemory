using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sla
{
    public partial class frm_ganhar : Form
    {
        frm_dificil frm_Dificil = new frm_dificil();
        public frm_ganhar(int tempoGasto)
        {
            InitializeComponent();
            lbl_tempo.Text = tempoGasto + " segundos";
            
        }

        private void btn_jogarNovamente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
