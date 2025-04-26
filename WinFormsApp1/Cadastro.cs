using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Cadastro
    {
        private string nome;
        private int cpf;
        private int telefone;
        private string email;
        private int datanascimento;
        private string mensagem;
        public Cadastro(string nome, int cpf, int telefone, string email, int datanascimento)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.email = email;
            this.datanascimento = datanascimento;
            this.Verificar();
        }
        private void Verificar()
        {
            this.mensagem = "Cadastro realizado com sucesso!";
            try
            {
                this.Nome = nome;
                this.CPF = cpf;
                this.telefone = telefone;
                this.email = email;
                this.datanascimento = datanascimento;
            }
            catch
            {
                this.mensagem = "Erro ao cadastrar!";
            }
        }
        public string Nome { get; private set; }
        public int CPF { get; private set; }

        public int Cpf
        {
            get { return cpf; }
        }
        public int Telefone
        {
            get { return telefone; }
            private set { telefone = value; } 
        }
        public string Email
        {
            get { return email; }
        }
        public int DataNascimento
        {
            get { return datanascimento; }
        }
        public string Mensagem
        {
            get { return mensagem; }
        }
    }
}