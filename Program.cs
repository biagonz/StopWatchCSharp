using System;
using System.Threading;

namespace StopWatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("=== Menu ===");
      Console.WriteLine("S - Segundo");
      Console.WriteLine("M - Minutos");
      Console.WriteLine("0 - Sair");
      Console.WriteLine("Quanto tempo deseja contar?");

      string data = Console.ReadLine().ToLower();

      Console.WriteLine("");
      Console.WriteLine("Modo de exibição: ");
      Console.WriteLine("D - Descrescente");
      Console.WriteLine("C - Crescente");
      Console.Write("Insira sua opção:");

      char mod = char.Parse(Console.ReadLine().ToLower());
      if (mod != 'd' && mod != 'c')
      {
        Console.WriteLine("");
        Console.WriteLine("Opção inválida!!");
        Thread.Sleep(2000);
        Menu();
      }

      //Substring captura um pedaço da string segundo o parametro passado.
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));
      int multiplier = 1;

      if (type == 'm') multiplier = 60;
      if (time == 0) System.Environment.Exit(0);

      PreStart(time * multiplier, mod);
    }

    static void PreStart(int time, char mod)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go!!!");
      Thread.Sleep(1000);

      Start(time, mod);
    }
    static void Start(int time, char mod)
    {
      int currentTime = 0;
      if (mod == 'd')
      {
        while (time != -1)
        {
          Console.Clear();
          Console.WriteLine(time);
          time--;
          Thread.Sleep(1000);
        }
      }
      else if (mod == 'c')
      {
        while (currentTime != time)
        {
          Console.Clear();
          currentTime++;
          Console.WriteLine(currentTime);
          //Espera a quantidade de tempo determinado para 
          //realizar a próxima iteração 
          Thread.Sleep(1000);
        }
      }

      Console.Clear();
      Console.WriteLine("StopWatch finalizado!");
      Thread.Sleep(2500);
    }
  }


}
