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
        string NomeUsuario = "Renan Rodrigues", tempo = "10";
        JogadorDTO jogador = new JogadorDTO();
        public frm_ranking()
        {
            InitializeComponent();
        }
        private void Frm_ranking_Load_1(object sender, EventArgs e)
        {
            JogadorDAO dao = new JogadorDAO();
            var ListaJogadores = dao.ListarJogadores();
            // var CadastraJogador = dao.CadastraJogador(jogador);

            for (int i = 0; i < ListaJogadores.Count; i++)
            {
                if (i == 5)
                {
                    break;
                }
                switch (i)
                {
                    case 0:
                        lbl_primeiro.Text = $"{ListaJogadores[i].Nome ?? ""} - tempo: {ListaJogadores[i].Tempo}";
                        break;
                    case 1:
                        lbl_segundo.Text = $"{ListaJogadores[i].Nome ?? ""}  - tempo: {ListaJogadores[i].Tempo}";
                        break;
                    case 2:
                        lbl_terceiro.Text = $"{ListaJogadores[i].Nome ?? ""} - tempo: {ListaJogadores[i].Tempo}";
                        break;
                    case 3:
                        lbl_quarto.Text = $"{ListaJogadores[i].Nome ?? ""} - tempo: {ListaJogadores[i].Tempo}";
                        break;
                    case 4:
                        lbl_quinto.Text = $"{ListaJogadores[i].Nome ?? ""} - tempo: {ListaJogadores[i].Tempo}";
                        break;
                }
            }
        }
    }
}
