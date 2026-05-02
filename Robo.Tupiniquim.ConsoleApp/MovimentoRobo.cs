namespace Robo.Tupiniquim.ConsoleApp;

public class MovimentoRobo
{
    int x;
    int y;
    string direcao;

    public void Inicializar(string posicaoInicial)
    {
        x = posicaoInicial[0] - '0';
        y = posicaoInicial[2] - '0';
        direcao = posicaoInicial[4].ToString();
    }

    public void ExecutarComandos(string comando)
    {
        for (int i = 0; i < comando.Length; i++)
        {
            char comandoAtual = comando[i];

            switch (comandoAtual)
            {
                case 'E':
                    direcao = MovimentoEsquerda(direcao);
                    break;

                case 'D':
                    direcao = MovimentoDireita(direcao);
                    break;

                case 'M':
                    MovimentoFrente();
                    break;
            }
        }
    }
    static string MovimentoEsquerda(string direcao)
    {
        if (direcao == "N") direcao = "O";
        else if (direcao == "O") direcao = "S";
        else if (direcao == "S") direcao = "L";
        else if (direcao == "L") direcao = "N";
        return direcao;
    }
    static string MovimentoDireita(string direcao)
    {
        if (direcao == "N") direcao = "L";
        else if (direcao == "L") direcao = "S";
        else if (direcao == "S") direcao = "O";
        else if (direcao == "O") direcao = "N";
        return direcao;
    }
    void MovimentoFrente()
    {
        if (direcao == "N") y++;
        else if (direcao == "S") y--;
        else if (direcao == "L") x++;
        else if (direcao == "O") x--;
    }
    public void MostrarPosicaoFinal()
    {
        Console.WriteLine("A Posiçao final é: " + x + " " + y + " " + direcao);
    }
}
