using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCarro.classes.Tanqq
{
    public class Tanque
    {
        private int capacidade { get; set; }
        private int quantidadePresente { get; set; }
        public Tanque(int capacidade)
        {
            this.capacidade = capacidade;
            this.quantidadePresente = 0;
        }

        public void Abastecer(int quantidade)
        {
            if ((this.quantidadePresente + quantidade) <= this.capacidade)
                this.quantidadePresente += quantidade;
            else
                this.quantidadePresente = capacidade;
        }
        public int UsarCombustivel(int quantidade)
        {
            if(quantidade <= quantidadePresente)
                quantidadePresente -= quantidade;
            return quantidadePresente;
        }
        public int GetCombustivelPresente()
        {
            return this.quantidadePresente;
        }
    }
}