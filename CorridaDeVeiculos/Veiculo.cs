using System;

public class Veiculo
{
    public string Nome { get; set; }
    public int Velocidade { get; set; }

    // Método que será sobrescrito pelas subclasses
    public virtual void Mover()
    {
        Console.WriteLine($"{Nome} está se movendo.");
    }

    // Método para criar os veículos
    public static Veiculo CriarVeiculo(string nome)
    {
        switch (nome.ToLower())
        {
            case "carro":
                return new Carro();
            case "moto":
                return new Moto();
            case "bicicleta":
                return new Bicicleta();
            default:
                Console.WriteLine("Veículo não reconhecido. Escolha entre Carro, Moto ou Bicicleta.");
                return null;
        }
    }

    // Subclasse Carro
    public class Carro : Veiculo
    {
        public Carro()
        {
            Nome = "Carro";
        }

        public override void Mover()
        {
            Console.WriteLine("Carro: Vruuummmm!");
        }
    }

    // Subclasse Moto
    public class Moto : Veiculo
    {
        public Moto()
        {
            Nome = "Moto";
        }

        public override void Mover()
        {
            Console.WriteLine("Moto: Vroom vroom!");
        }
    }

    // Subclasse Bicicleta
    public class Bicicleta : Veiculo
    {
        public Bicicleta()
        {
            Nome = "Bicicleta";
        }

        public override void Mover()
        {
            Console.WriteLine("Bicicleta: Pedalando...");
        }
    }
}
