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
        private static extern IntPtr CreateRoundRectRgn
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
            string Usuario = txt_nomeUsuario.Text;
        }

        private void btn_comecar_Click(object sender, EventArgs e)
        {
            //if (txt_nomeUsuario.Text != string.Empty)
            //{
                    frm_dificil formdificil = new frm_dificil();
                    formdificil.Show();
            //}
            //else
            //{
              //  MessageBox.Show("Digite seu nome!");
            //}
        }

        private void Frm_inicio_Load(object sender, EventArgs e)
        {
            btn_comecar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_comecar.Width, btn_comecar.Height, 50, 50));
            txt_nomeUsuario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_nomeUsuario.Width, txt_nomeUsuario.Height, 30, 30));

            //txt_nomeUsuario.GotFocus += RemoveText;
            //txt_nomeUsuario.LostFocus += AddText;
        }

        /*public void RemoveText(object sender, EventArgs e)
        {
            if (txt_nomeUsuario.Text == "Digite seu nome aqui")
            {
                txt_nomeUsuario.Text = "";
            }
        }
        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nomeUsuario.Text))
                txt_nomeUsuario.Text = "Digite seu nome aqui";
        }*/

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_informacoes_Click(object sender, EventArgs e)
        {
            frm_info frm_Info = new frm_info();
            frm_Info.Show();
        }
    }
}
