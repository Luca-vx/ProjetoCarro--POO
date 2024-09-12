using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCarro.classes.Mott;
using ProjetoCarro.classes.Tanqq;

namespace ProjetoCarro.classes.Carr
{
    public class Carro
    {
        private string modelo { get; set; }
        private string cor { get; set; }
        private int velocidade { get; set; }
        private Motor motor { get; set; }
        private Tanque tanque { get; set; }

        public Carro(string modelo, string cor, Motor motor, Tanque tanque)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.velocidade = 0;
            this.motor = motor;
            this.tanque = tanque;
        }
        public void Ligar()
        {
            motor.Ligar();
        }
        public void Desligar()
        {
            if (velocidade > 0)
                Frear();
            motor.Desligar();
        }
        public void Acelerar(int quantidadeCombustivel)
        {
            if (quantidadeCombustivel < tanque.GetCombustivelPresente())
            {                
                motor.Acelerar(this,quantidadeCombustivel);
            }
        }
        public void Frear()
        {
            this.velocidade = 0;
        }
        protected internal void SetVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }        
        public int GetVelocidade()
        {
            return this.velocidade;
        }
        public void Abastecer(int quantidade)
        {
            tanque.Abastecer(quantidade);
        }
    }
}