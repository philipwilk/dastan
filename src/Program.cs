﻿//Skeleton Program code for the AQA A Level Paper 1 Summer 2023 examination
//this code should be used in conjunction with the Preliminary Material
//written by the AQA Programmer Team
//developed in the Visual Studio Community Edition programming environment

namespace Dastan
{
  class Program
  {
    static void Main(string[] args)
    {
      Dastan ThisGame = new Dastan(6, 6, 4);
      ThisGame.PlayGame();
      Console.WriteLine("Goodbye!");
      Console.ReadLine();
    }
  }
}