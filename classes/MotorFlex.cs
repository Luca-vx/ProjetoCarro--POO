using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCarro.classes.Carr;
using ProjetoCarro.classes.Mott;

namespace ProjetoCarro.classes.MotFlxx
{
    public class MotorFlex : IMotor
    {
        private bool ligado { get; set; }
        private int aceleracao { get; set; }
        public MotorFlex()
        {
            this.ligado = false;
            this.aceleracao = 0;
        }
        public void Ligar()
        {            
            if(!IsLigado())           
            { 
                this.ligado = true;   
                Console.WriteLine("Carro Ligado");
            }
            else
                Console.WriteLine("Motor já esta Ligado");
        }
        public void Desligar()
        {
            if(IsLigado())
            {
                this.ligado = false;
                Console.WriteLine("Carro Desligado");
            }
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
        public void Acelerar(Carro c, int quantCombustivel)
        {
            SetAceleracao(quantCombustivel * 500);
            c.SetVelocidade(GetAceleracao()/50);
        }
    }
}