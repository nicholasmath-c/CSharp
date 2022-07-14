using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHerançaEncapsulamento
{
    class Aluno : Pessoa
    {
        private string curso;
        private int rm;
        private string periodo;
        //Método de acesso publico
        public string Curso
        {
            get { return this.curso; }
            set { this.curso = value; }
        }

        public int Rm
        {
            get { return this.rm; }
            set { this.rm = value; }
        }

        public string Periodo
        {
            get { return this.curso; }
            set { this.curso = value; }
        }




    }
}
