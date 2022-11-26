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
    public partial class frm_medio : Form
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

        public frm_medio()
        {
            InitializeComponent();
        }

        private void Frm_dificil_Load(object sender, EventArgs e)
        {
            btn_start.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_start.Width, btn_start.Height, 30, 30));
        }
    }
}
