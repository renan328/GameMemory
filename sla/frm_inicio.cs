using sla.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sla
{
    public partial class frm_inicio : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
           (
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );

        public frm_inicio()
        {
            InitializeComponent();
        }

        private void btn_comecar_Click(object sender, EventArgs e)
        {
            string Nome = txt_nomeUsuario.Text;
            frm_jogo formjogo = new frm_jogo(Nome);

            if (Nome == string.Empty)
            {
                MessageBox.Show("Insira seu nome", "Coloque seu nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                formjogo.Show();
            }



        }

        private void Frm_inicio_Load(object sender, EventArgs e)
        {
            btn_comecar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_comecar.Width, btn_comecar.Height, 30, 30));
            txt_nomeUsuario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_nomeUsuario.Width, txt_nomeUsuario.Height, 30, 30));
            btn_sair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_sair.Width, btn_sair.Height, 30, 30));
            btn_informacoes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_informacoes.Width, btn_informacoes.Height, 30, 30));
            btn_rank.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_rank.Width, btn_rank.Height, 30, 30));
        }

        private void btn_informacoes_Click(object sender, EventArgs e)
        {
            frm_info frm_Info = new frm_info();
            frm_Info.ShowDialog();
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rank_Click(object sender, EventArgs e)
        {
            frm_ranking frm_Ranking = new frm_ranking();
            frm_Ranking.Show();
        }
    }
}
