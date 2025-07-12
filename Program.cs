using System;
using System.Threading;

enum GameState
{
    MainMenu,
    Playing,
    GameOver
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

        GameState gameState = GameState.MainMenu;

    }
}
