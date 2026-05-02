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
        int x = 0;
        int y = 0;
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

        Console.Write("Digite os Comandos: ");
        string comando = Console.ReadLine();

        x = posicaoInicial[0] - '0';
        y = posicaoInicial[2] - '0';
        char direcao = posicaoInicial[4];

        for (int i = 0; i < comando.Length; i++)
        {
            char comandoAtual = comando[i];

            switch (comandoAtual)
            {
                case 'E':
                    if (direcao == 'N') direcao = 'O';
                    else if (direcao == 'O') direcao = 'S';
                    else if (direcao == 'S') direcao = 'L';
                    else if (direcao == 'L') direcao = 'N';
                    break;

                case 'D':
                    if (direcao == 'N') direcao = 'L';
                    else if (direcao == 'L') direcao = 'S';
                    else if (direcao == 'S') direcao = 'O';
                    else if (direcao == 'O') direcao = 'N';
                    break;

                case 'M':
                    if (direcao == 'N') y++;
                    else if (direcao == 'S') y--;
                    else if (direcao == 'L') x++;
                    else if (direcao == 'O') x--;
                    break;
            }
        }

        Console.WriteLine("A Posiçao final é: " + x + " " + y + " " + direcao);
    }
}


