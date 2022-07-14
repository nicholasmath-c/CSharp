using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeViagens
{
    class Viagem
    {
        //private string estado; [propfull + tab + tab]
        private string estado;

        public string Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return this.cidade; }
            set { this.cidade = value; }
        }
        private string acomodacao;

        public string Acomodacao
        {
            get { return this.acomodacao; }
            set { this.acomodacao = value; }
        }
        private string tipotrans;

        public string Tipotrans
        {
            get { return this.tipotrans; }
            set { this.tipotrans = value; }
        }

        //Forma rápida: seleciona tudo; Ctrl + r + e
        private double valor;

        public double Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }

        //Método que retorna os dados da viagem

        public string RetornaDados()
        {
            string resultado = "";

            resultado += "Dados da viagem: ";
            resultado += "\n\t " + "Estado: " +             this.Estado;
            resultado += "\n\t " + "Cidade: " +             this.Cidade;
            resultado += "\n\t " + "Tipo de Transporte: " + this.Tipotrans;
            resultado += "\n\t " + "Acomodação: " +         this.Acomodacao;
            resultado += "\n\t " + "Valor da viagem: " +    this.Valor;
            resultado += "\n";


            return resultado;
        }
    }
}
