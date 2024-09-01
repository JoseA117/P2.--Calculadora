using System;

namespace Calculadora_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            try
            {
                MenuOption menu = new MenuOption();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Menu();
            }
        }
    }
}