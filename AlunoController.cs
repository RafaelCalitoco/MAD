using Escola_conducao.Dao;
using Escola_conducao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escola_conducao.Control
{
    public class AlunoController
    {
        private Aluno aluno;
        private AlunoDao dao;


        public AlunoController()
        {

        }

        public string inserir(string Nome, string BI, string Telefone, string Email)
        {

            if (Nome.ToString().Equals("") || BI.ToString().Equals("") ||  Telefone.ToString().Equals("") || Email.ToString().Equals(""))
            {
                return "<b>Erro: campo em branco</b>";
            }
            else
            {
                aluno = new Aluno(0, Nome, BI, Telefone, Email);
                dao = new AlunoDao();
                dao.inserir(aluno);
                return "<b>Inserido com sucesso!</b>";
            }

        }

    }
}