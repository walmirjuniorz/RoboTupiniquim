namespace Robo.Tupiniquim.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Robô Tupiniquim");
        Console.WriteLine("-------------------------");

        Console.Write("Digite a posição inicial (X,Y): ");
        string posicaoInicial = Console.ReadLine();

        Console.Write("Digite os Comandos: ");
        string comando = Console.ReadLine();

        MovimentoRobo Robo = new MovimentoRobo();

        Robo.Inicializar(posicaoInicial);
        Robo.ExecutarComandos(comando);
        Robo.MostrarPosicaoFinal();
    }
}


