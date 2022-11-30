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
    public partial class frm_perder : Form
    {
        frm_dificil frm_Dificil = new frm_dificil();

        public frm_perder(int pares)
        {
            InitializeComponent();
            lbl_pares.Text = pares.ToString();
        }

        private void Btn_jogarNovamente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brn_rank_Click(object sender, EventArgs e)
        {
            frm_ranking frm_Ranking = new frm_ranking();
            frm_Ranking.Show();
        }
    }
}
