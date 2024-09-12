using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCarro.classes.Carr;
using ProjetoCarro.classes.Mott;

namespace ProjetoCarro.classes.MotFlxx
{
    public class MotorFlex : Motor
    {
        public override void Acelerar(Carro c, int quantCombustivel)
        {
            int aceleracaoMotor = quantCombustivel * 500;
            c.SetVelocidade(aceleracaoMotor/50);
        }
    }
}