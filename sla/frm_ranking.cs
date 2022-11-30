using sla.DAO;
using sla.DTO;
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
    public partial class frm_ranking : Form
    {
        public frm_ranking()
        {
            InitializeComponent();
        }

        JogadorDTO jogador = new JogadorDTO();

        private void frm_ranking_Load(object sender, EventArgs e)
        {
            JogadorDAO dao = new JogadorDAO();
            var jogador = dao.ListarJogadores();

            foreach (var item in jogador)
            {
                label1.Text += item.ToString();
            };
        }
    }
}
