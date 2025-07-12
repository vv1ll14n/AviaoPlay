using System;
using System.Threading;

enum GameState
{
    Menu,
    Jogando,
    FimDeJogo
}

class Program
{
    static void Main()
    {
        Console.Title = "Jogo do aviaozinho";
        // dimensões do jogo
        int screenWidth = 50;
        int screenHeight = 30;
        Console.SetWindowSize(screenWidth, screenHeight);
        Console.SetBufferSize(screenWidth, screenHeight);

        // Variaveis do Aviao
        double AviaoVertical = screenHeight / 2.0;
        double VelocidadeVertical = 0;
        const double Gravidade = 0.2;
        const double Voar = -1.0;

        // iniciando o jogo

        GameState gameState = GameState.Menu;

        Console.WriteLine("Bem vindo ao jogo do Aviaozinho!");
        Console.WriteLine("Precione qualquer tecla para iniciar");
        Console.ReadKey(true);

        //Jogo

        while (true)
        {
            switch (gameState)
            {
                case GameState.Menu:
                    Console.WriteLine("Jogo do Aviao");
                    Console.WriteLine("1 - iniciar jogo");
                    Console.WriteLine("2 - sair");
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                    if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
                    {
                        AviaoVertical = screenHeight / 2.0;
                        VelocidadeVertical = 0;
                        gameState = GameState.Jogando;
                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2)
                    {
                        return;
                    }
                    break;
                case GameState.Jogando:
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo consoleKeyInfoJogar = Console.ReadKey(true);
                        if (consoleKeyInfoJogar.Key == ConsoleKey.Spacebar)
                        {
                            VelocidadeVertical = Voar;
                        }
                        ;
                    }
                    VelocidadeVertical += Gravidade;
                    AviaoVertical += VelocidadeVertical;
                    //comparando a velocidade do aviao
                    if (AviaoVertical < 0 || AviaoVertical > screenHeight - 1)
                    {
                        gameState = GameState.FimDeJogo;
                    }
                    Console.Clear();
                    Console.SetCursorPosition(5, (int)Math.Round(AviaoVertical));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("=>"); // aviao feio

                    for (int i = 0; i < screenWidth; i++)
                    {
                        Console.SetCursorPosition(i, 0);
                        Console.Write("=");
                        Console.SetCursorPosition(i, screenHeight - 1);
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        Console.WriteLine("░░░░░░░░░░█");
                        Console.WriteLine("░░░░░░░░▄▄█▄▄");
                        Console.WriteLine("░░░░▀▀▀██▀▀▀██▀▀▀");
                        Console.WriteLine("▄▄▄▄▄▄▄███████▄▄▄▄▄▄▄");
                        Console.WriteLine("░░█▄█░░▀██▄██▀░░█▄█");
                    }
                    Thread.Sleep(50);
                    break;
                case GameState.FimDeJogo:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fim de jogo");
                    ConsoleKeyInfo consoleKeyInfoFimDeJogo = Console.ReadKey(true);
                    if (consoleKeyInfoFimDeJogo.Key == ConsoleKey.R)
                    {
                        gameState = GameState.Menu;
                    }
                    break;
            }
        }

    }
}
