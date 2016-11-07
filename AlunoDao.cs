using Escola_conducao.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Escola_conducao.Dao
{
    public class AlunoDao
    {
        private Aluno aluno;
        private List<Aluno> alunos;
        private string conexao;

        public AlunoDao()
        { }

        public void inserir(Aluno aluno)
        {
            conexao = new Conexao().getConexao();
            MySqlConnection sqlc = new MySqlConnection(conexao);
            sqlc.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO aluno(Nome, BI, Telefone, Email) values ('" + aluno.getNome() + "', '" + aluno.getBI() + "', '" + aluno.getTelefone() + "', '" + aluno.getEmail() + "') ", sqlc);
            int a = comando.ExecuteNonQuery();
            // Fecha a conexão
            sqlc.Close();
 

        }

        public void update(Aluno aluno)
        {

        }

        public void delete(Aluno aluno)
        {

        }

        public Aluno getAluno()
        {
            return aluno;
        }

        public List<Aluno> getAlunos()
        {
            return alunos;
        }
    }
}