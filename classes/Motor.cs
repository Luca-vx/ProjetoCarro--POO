using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCarro.classes.Carr;

namespace ProjetoCarro.classes.Mott
{
    public interface IMotor
    {
        public void Ligar();                
        public void Desligar();                                        
        public bool IsLigado();                           
        public void SetAceleracao(int aceleracao);                            
        public int GetAceleracao();
        public void Acelerar(Carro c, int quantCombustivel);    
    }
}