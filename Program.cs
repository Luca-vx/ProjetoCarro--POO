using ProjetoCarro.classes;
using ProjetoCarro.classes.Carr;
using ProjetoCarro.classes.MotFlxx;
using ProjetoCarro.classes.Tanqq;

internal class Program
{
    private static void Main(string[] args)
    {
        MotorDiesel m = new MotorDiesel();
        Tanque t = new Tanque(500);
        Carro c = new Carro("BMW", "AZUL", m, t);
        c.Ligar();
        Console.Write("\n");
        // se o carro ficar sem gasolina ele vai se desligar sozinho logo depois de avisar o usuario
        c.Acelerar(100);
        c.Abastecer(500);
        c.Acelerar(10);
        Console.WriteLine($"Velocidade de um carro a Diesel com consumo de 10 unidades de gasolina: {c.GetVelocidade()}");

        MotorFlex m2 = new MotorFlex();
        Carro c2 = new Carro("UNO", "Vermelho", m2, t);
        c2.Ligar();
        c2.Abastecer(5000);
        c2.Acelerar(10);
        Console.WriteLine($"Velocidade de um carro com motor flex com consumo de 10 unidades de gasolina {c2.GetVelocidade()}");
        // a velocidade de um carro com Motor Flex como mostrado no exemplo acima é de (100) Já a de um motor a diesel (68) ambos com uma aceleração de 10 unidades de combustivel
    }
}