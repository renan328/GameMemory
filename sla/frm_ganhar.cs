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
    public partial class frm_ganhar : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );

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

        private void Frm_ganhar_Load(object sender, EventArgs e)
        {
            brn_rank.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, brn_rank.Width, brn_rank.Height, 50, 50));
            btn_jogarNovamente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_jogarNovamente.Width, btn_jogarNovamente.Height, 50, 50));
        }
    }
}
