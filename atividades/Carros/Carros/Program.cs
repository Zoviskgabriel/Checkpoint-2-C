using System;
using System.Collections.Generic;

public class Veiculo
{
    public virtual void Acelerar()
    {
        Console.WriteLine("Veículo acelerando...");
    }
}

public class Carro : Veiculo
{
    public override void Acelerar()
    {
        Console.WriteLine("Carro acelerando rapidamente...");
    }
}

public class Caminhao : Veiculo
{
    public override void Acelerar()
    {
        Console.WriteLine("Caminhão acelerando lentamente...");
    }
}

public class Moto : Veiculo
{
    public override void Acelerar()
    {
        Console.WriteLine("Moto acelerando com agilidade...");
    }
}

class Program
{
    static void Main()
    {
        List<Veiculo> veiculos = new List<Veiculo>()
        {
            new Carro(),
            new Caminhao(),
            new Moto()
        };

        foreach (Veiculo v in veiculos)
        {
            v.Acelerar();
        }
    }
}
