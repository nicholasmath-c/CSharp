using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHerançaEncapsulamento
{
    class Pessoa
    {
        private string nome;
        private string cpf;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }
    }
}
