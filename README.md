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



# Classe vs. objeto:

- Classe é uma definição do que um objeto deve conter e como ele se comporta.

- Objeto é uma instância concreta da classe, criada em memória com seus próprios valores.

  
		public class Pessoa
		{
		    public string Nome;
		    public int Idade;
		}
		class Program
		{
		    static void Main()
		    {
		        Pessoa pessoa1 = new Pessoa();  // objeto criado a partir da classe Pessoa
		        pessoa1.Nome = "Ana";
		        pessoa1.Idade = 25;
		        Console.WriteLine($"Nome: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
		    }
		}


  # Modificadores de acesso:

- Public: O membro é acessível de qualquer lugar (sem restrição).

- Private: O membro só pode ser acessado dentro da própria classe. 

- Protected: O membro pode ser acessado dentro da classe e por classes de herança.

Quando usar:

- Private para proteger dados internos da classe (encapsulamento).

- Public para expor propriedades e métodos que precisam ser acessados por outras partes do programa.

- Protected para permitir acesso em classes filhas, mas dentro da hierarquia.


# Sobrecarga (Overloading) vs. Sobrescrita (Overriding)

- Sobrecarga: Métodos com o mesmo nome, mas assinaturas diferentes  dentro da mesma classe.

- Sobrescrita: Uma classe derivada redefine a implementação de um método da classe base.

  Exemplo Sobrecarga:
  
		public class Calculadora
		{
		    public int Somar(int a, int b) => a + b;
		    public int Somar(int a, int b, int c) => a + b + c;  // método sobrecarregado
		}
  Exemplo Sobrescrita:

		public class Animal
		{
		    public virtual void Falar() => Console.WriteLine("Som genérico");
		}
		public class Cachorro : Animal
		{
		    public override void Falar() => Console.WriteLine("Au Au");
		}



