class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("-------------------------");
        Console.WriteLine("Robô Tupiniquim");
        Console.WriteLine("-------------------------");

        Console.Write("Digite a posição inicial (X,Y): ");
        string posicaoInicial = Console.ReadLine();

        string[] posicao = new string[3];
        string valorAtual = "";
        int indice = 0;

        for (int i = 0; i < posicaoInicial.Length; i++)
        {
            if (posicaoInicial[i] != ' ')
            {
                valorAtual = valorAtual + posicaoInicial[i];
            }
            else
            {
                posicao[indice] = valorAtual;
                valorAtual = "";
                indice++;
            }
        }
        posicao[indice] = valorAtual;

        Console.Clear();
        Console.WriteLine("-------------------------");
        Console.WriteLine("Lista de Comandos");
        Console.WriteLine("E (Esquerda)");
        Console.WriteLine("D (Direita)");
        Console.WriteLine("M (Mover)");
        Console.WriteLine("-------------------------");
        Console.Write("Digite o Comando: ");
        string comando = Console.ReadLine();

        char[] instrucoes = comando.ToCharArray();

        for (int i = 0; i < comando.Length; i++)
        {
            char comandoAtual = comando[i];

            if (comandoAtual == 'E')
            {

            }
            else if (comandoAtual == 'D')
            {

            }
            else if (comandoAtual == 'M')
            {

            }
        }


    }
}


