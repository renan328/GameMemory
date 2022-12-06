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
        string NomeUsuario = "Renan Rodrigues", tempo = "10";
        public List<JogadorDTO> ListarJogadores()
        {
            var conexao = ConnectionFactory.Create();
            conexao.Open();

            var query = "SELECT* FROM jogador ORDER BY tempo ASC LIMIT 5";
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
        public void CadastraJogador(JogadorDTO jogador)
        {
            var conexao = ConnectionFactory.Create();
            conexao.Open();

            var query = @"INSERT INTO Usuario (Nome,tempo) VALUES
						(@nome,@tempo)";

            var comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@nome", jogador.Nome).Value = NomeUsuario;
            comando.Parameters.AddWithValue("@tempo", jogador.Tempo).Value = tempo;

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
