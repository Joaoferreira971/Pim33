using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Validacao
    {
        private string nome;
        private int cpf;
        private int telefone;
        private string email;
        private int datanascimento;
        private string mensagem;

        public Validacao(string nome, int cpf, int telefone, string email, int datanascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.email = email;
            this.datanascimento = datanascimento;
            this.Validar();
        }
        private void Validar()
        {
            this.mensagem = "";
            try
            {
                this.nome = nome;
                this.cpf = cpf;
                this.telefone = telefone;
                this.email = email;
                this.datanascimento = datanascimento;
            }
            catch
            {
                this.mensagem = "Digite um nome válido";
                this.mensagem = "Digite um CPF válido";
                this.mensagem = "Digite um telefone válido";
                this.mensagem = "Digite um email válido";
                this.mensagem = "Digite uma data de nascimento válida";
                this.mensagem = "Cadastro realizado com sucesso!";
            }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Cpf
        {
            get { return cpf; }
        }
        public int Telefone
        {
            get { return telefone; }
        }
        public string Email
        {
            get { return email; }
        }
        public int Datanascimento
        {
            get { return datanascimento; }
        }
        public string Mensagem
        {
            get { return mensagem; }
        }
    }
}

