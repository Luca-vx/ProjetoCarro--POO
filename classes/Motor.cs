using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCarro.classes.Carr;

namespace ProjetoCarro.classes.Mott
{
    public abstract class Motor
    {
        private bool ligado { get; set; }
        private int aceleracao { get; set; }
        public Motor()
        {
            this.ligado = false;
            this.aceleracao = 0;
        }
        public void Ligar()
        {
            if(!IsLigado())            
                this.ligado = true;   
            else
                Console.WriteLine("Motor já esta Ligado");
        }
        public void Desligar()
        {
            if(IsLigado())
                this.ligado = false;
            else
                Console.WriteLine("Motor já esta Desligado");
            
        }
        public bool IsLigado()
        {
            return ligado;
        }
        public void SetAceleracao(int aceleracao)
        {
            this.aceleracao = aceleracao;
        }
        public int GetAceleracao()
        {
            return aceleracao;
        }
        //fiquei em duvida nessa abaixo
        public virtual void Acelerar(Carro c, int quantCombustivel)
        {}
    }
}