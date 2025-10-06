# Checkpoint-2-C
	Esse repositorio e do CP2 de C#



# Conceitos fundamentais 
	1.Encapsulamento: 
		Ocultar os detalhes internos de uma classe, mostrando so o essencial por meio de m�todos e propriedades. 
		Assim garante a prote��o dos dados e impede o acesso direto e n�o autorizado.

		public class Pessoa
{
    private string nome; // campo privado

    public string Nome   // propriedade p�blica para acessar o campo privado
    {
        get { return nome; }
        set { nome = value; }
    }
}


	2.Heran�a:
		Quando uma classe (classe derivada) herda propriedades e m�todos de outra (classe base),reutilizando o c�digo.

		public class Animal
{
    public void Comer() { Console.WriteLine("Animal comendo"); }
}

public class Cachorro : Animal
{
    public void Latir() { Console.WriteLine("Cachorro latindo"); }
}



	3.Polimorfismo:
		� quando permite que objetos de diferentes classes derivadas possam ser tratados como objetos da classe base, assim podendo executar m�todos sobrescrito.	

		public class Animal
{
    public virtual void EmitirSom() { Console.WriteLine("Som gen�rico"); }
}

public class Gato : Animal
{
    public override void EmitirSom() { Console.WriteLine("Miau"); }
}

public class Cachorro : Animal
{
    public override void EmitirSom() { Console.WriteLine("Au Au"); }
}



	4.Abstra��o:
		� o foco nos aspectos essenciais de um objeto, ignorando detalhes complexos ou irrelevantes


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