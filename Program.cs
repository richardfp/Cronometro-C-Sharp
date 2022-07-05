using System;
using System.Threading;

namespace Crono
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // Pega o último digito que o usuário digitou
            int time = int.Parse(data.Substring(0, data.Length - 1)); // Pega todos os digitos menos o último
            int multiplier = 1;

            if (type == 'm') {
            multiplier = 60;
            }

            if (time == 0) {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);
        }

        static void PreStart(int time) {
            Console.Clear();
            Console.WriteLine("Preparar....");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar....");
            Thread.Sleep(1000);
            Console.WriteLine("Go!!!");
            Thread.Sleep(500);

            Start(time);
        }

        static void Start(int time) 
        {
            int currentTime = 0;

            while (currentTime != time) 
            {           
                Console.Clear();     
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); // Tempo para executar a proxima intrução. 1000 ms
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado.");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
