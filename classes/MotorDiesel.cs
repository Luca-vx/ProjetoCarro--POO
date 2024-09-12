using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCarro.classes.Carr;
using ProjetoCarro.classes.Mott;

namespace ProjetoCarro.classes
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar(Carro c, int quantCombustivel)
        {
            int aceleracaoMotor = quantCombustivel * 750;
            
        }
    }
}