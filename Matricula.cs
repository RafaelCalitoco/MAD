using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escola_conducao.Model
{
    public class Matricula
    {
        private int id_matricula;
        private Aluno aluno;
        private Funcionario funcionario;
        private DateTime Data;
        private string Descricao;

        public Matricula(int id_matricula, Aluno aluno, Funcionario funcionario, DateTime Data, string Descricao)
        {
            this.id_matricula = id_matricula;
            this.aluno = aluno;
            this.funcionario = funcionario;
            this.Data = Data;
            this.Descricao = Descricao;
        }

        public void setid_matricula(int id_matricula)
        {
            this.id_matricula = id_matricula;
        }

        public int getid_matricula()
        {
            return this.id_matricula;
        }

        public void setaluno(Aluno aluno)
        {
            this.aluno = aluno;
        }

        public Aluno getaluno()
        {
            return this.aluno;
        }

        public void setfuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }

        public Funcionario getFuncionario()
        {
            return this.funcionario;
        }

        public void setData(DateTime Data)
        {
            this.Data = Data;
        }

        public DateTime getData()
        {
            return this.Data;
        }

        public void setDescricao(string Descricao)
        {
            this.Descricao = Descricao;
        }

        public string getDescricao()
        {
            return this.Descricao;
        }
    }
}