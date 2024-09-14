using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCarro.classes.Carr;

namespace ProjetoCarro__POO.classes
{
    public abstract class Motor
    {
        public abstract void Ligar();                
        public abstract void Desligar();                                        
        public abstract bool IsLigado();                           
        public abstract void SetAceleracao(int aceleracao);                            
        public abstract int GetAceleracao();
        public abstract void Acelerar(Carro c, int quantCombustivel);    
    }
}