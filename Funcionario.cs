using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escola_conducao.Model
{
    public class Funcionario
    {
     private int id_aluno;
        private string Nome;
        private string BI;
        private int Idade;
        private string Telefone;
        private string Provincia;
        private string Cargo;

        public Funcionario(int id_aluno, string Nome, string BI, int Idade, string Telefone, string Provincia, string Cargo)
        {
            this.id_aluno = id_aluno;
            this.Nome = Nome;
            this.BI = BI;
            this.Idade = Idade;
            this.Telefone = Telefone;
            this.Provincia = Provincia;
            this.Cargo = Cargo;
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

        public void setIdade(int Idade)
        {
            this.Idade = Idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }

        public void setProvincia(string Provincia)
        {
            this.Provincia = Provincia;
        }

        public string getProvincia()
        {
            return this.Provincia;
        }

        public void setCargo(string Cargo)
        {
            this.Cargo = Cargo;
        }

        public string getCargo()
        {
            return this.Cargo;
        }
    }
}