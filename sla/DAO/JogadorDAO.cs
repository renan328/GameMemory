using MySql.Data.MySqlClient;
using sla.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sla.DAO
{
    class JogadorDAO
    {
        public List<JogadorDTO> ListarJogadores()
        { // 
            var conexao = ConnectionFactory.Create();
            conexao.Open();

            var query = "SELECT* FROM jogador ORDER BY tempo DESC";
            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();
            var ListaJogadores = new List<JogadorDTO>();

            while (dataReader.Read())
            {
                var jogador = new JogadorDTO();
                jogador.ID = int.Parse(dataReader["id"].ToString());
                jogador.Nome = dataReader["nome"].ToString();
                jogador.Tempo = dataReader["tempo"].ToString();

                ListaJogadores.Add(jogador);
            }

            conexao.Close();

            return ListaJogadores;
        }
    }
}
