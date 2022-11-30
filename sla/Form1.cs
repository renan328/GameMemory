using sla.DAO;
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
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            JogadorDAO dao = new JogadorDAO();
            var jogador = dao.ListarJogadores();

            foreach (var item in jogador)
            {
                Console.WriteLine(item);
                label1.Text = item.ToString();
            };


            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 50, 50));
        }
    }
}
