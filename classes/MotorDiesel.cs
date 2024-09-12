using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCarro.classes.Carr;
using ProjetoCarro.classes.Mott;

namespace ProjetoCarro.classes
{
    public class MotorDiesel : IMotor
    {
        
        private bool ligado { get; set; }
        private int aceleracao { get; set; }
        public MotorDiesel()
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
            SetAceleracao(quantCombustivel * 750);
            double calculo = GetAceleracao() / 110;
            int valorAceleracao = Convert.ToInt32(Math.Round(calculo));
            c.SetVelocidade(valorAceleracao);
        }
    }
}