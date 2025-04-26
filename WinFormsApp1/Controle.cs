using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Controle
    {
        private string Nome;

        public int Cpf { get; }

        private int CPF;
        private int Telefone;
        private string Email;
        private int Datanascimento;
        private string mensagem; 
        public Controle(string nome, int cpf, int telefone, string email, int datanascimento)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Email = email;
            this.Datanascimento = datanascimento;
            this.Executar();
        }
        private void Executar()
        {
            this.mensagem = ""; 
            Validacao validacao = new Validacao(Nome, Cpf, Telefone, Email, Datanascimento);
            if (validacao.Mensagem.Equals(""))
            {
                Cadastro cadastro = new Cadastro(Nome, Cpf, Telefone, Email, Datanascimento);
                this.mensagem = cadastro.Mensagem;
            }
            else
            {
                this.mensagem = validacao.Mensagem; 
            }

        }
        public string Mensagem
        {
            get { return mensagem; } 
        }
    }
}
