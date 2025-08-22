using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha os veículos para competir (Carro, Moto, Bicicleta):");

        Console.Write("Digite o nome do primeiro veículo: ");
        string veiculo1 = Console.ReadLine();
        Console.Write("Digite o nome do segundo veículo: ");
        string veiculo2 = Console.ReadLine();

        // Criando os veículos
        Veiculo v1 = Veiculo.CriarVeiculo(veiculo1);
        Veiculo v2 = Veiculo.CriarVeiculo(veiculo2);

        // Exibindo a corrida
        Console.WriteLine($"Veículos escolhidos: {v1.Nome} vs {v2.Nome}");
        v1.Mover();
        v2.Mover();
    }
}
