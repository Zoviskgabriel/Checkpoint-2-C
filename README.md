# Checkpoint-2-C
	Esse repositorio e do CP2 de C#



# Conceitos fundamentais 
	1.Encapsulamento: 
		Ocultar os detalhes internos de uma classe, mostrando so o essencial por meio de métodos e propriedades. 
		Assim garante a proteção dos dados e impede o acesso direto e não autorizado.

		public class Pessoa
{
    private string nome; // campo privado

    public string Nome   // propriedade pública para acessar o campo privado
    {
        get { return nome; }
        set { nome = value; }
    }
}


	2.Herança:
		Quando uma classe (classe derivada) herda propriedades e métodos de outra (classe base),reutilizando o código.

		public class Animal
{
    public void Comer() { Console.WriteLine("Animal comendo"); }
}

public class Cachorro : Animal
{
    public void Latir() { Console.WriteLine("Cachorro latindo"); }
}



	3.Polimorfismo:
		É quando permite que objetos de diferentes classes derivadas possam ser tratados como objetos da classe base, assim podendo executar métodos sobrescrito.	

		public class Animal
{
    public virtual void EmitirSom() { Console.WriteLine("Som genérico"); }
}

public class Gato : Animal
{
    public override void EmitirSom() { Console.WriteLine("Miau"); }
}

public class Cachorro : Animal
{
    public override void EmitirSom() { Console.WriteLine("Au Au"); }
}



	4.Abstração:
		É o foco nos aspectos essenciais de um objeto, ignorando detalhes complexos ou irrelevantes


		public abstract class Forma
{
    public abstract double CalcularArea();
}

public class Circulo : Forma
{
    public double Raio { get; set; }
    public override double CalcularArea() => Math.PI * Raio * Raio;
}



# Classe vs. objeto