using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escola_conducao.Model
{
    public class Aluno
    {
        private int id_aluno;
        private string Nome;
        private string BI;
        private string Telefone;
        private string Email;

        public Aluno(int id_aluno, string Nome, string BI, string Telefone, string Email)
        {
            this.id_aluno = id_aluno;
            this.Nome = Nome;
            this.BI = BI;
            this.Telefone = Telefone;
            this.Email = Email;
        }


        public void setid_aluno(int id_aluno)
        {
            this.id_aluno = id_aluno;
        }

        public int getid_aluno()
        {
            return this.id_aluno;
        }

        public void setNome(string Nome)
        {
            this.Nome= Nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setBI(string BI)
        {
            this.BI = BI;
        }

        public string getBI()
        {
            return this.BI;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public string getEmail()
        {
            return this.Email;
        }
    }
}