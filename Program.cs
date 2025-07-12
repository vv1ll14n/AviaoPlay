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
        int screenWidth = 40;
        int screenHeight = 20;
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
                    } else if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2) {
                        return;
                    }
                    break;
            }
        }

    }
}
