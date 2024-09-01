using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO
{
    internal class MenuOption
    {
        private List<Opcion> opciones;
        private Calcula calculador;

        public MenuOption()
        {
            calculador = new Calcula();
            opciones = new List<Opcion>() {
            new Opcion("Sumar", Sumar),
            new Opcion("Restar", Restar),
            new Opcion("Multiplicar", Multiplicar),
            new Opcion("Dividir", Dividir),
            new Opcion("Salir", () => Environment.Exit(0))
        };
            while (true)
            {
                MostrarMenu();
                SeleccionarOpcion();
            }
        }

        public void MostrarMenu()
        {
            foreach (Opcion opcion in opciones)
            {
                Console.WriteLine($"{opciones.IndexOf(opcion) + 1}. {opcion.Mensaje}");
            }
        }

        public void SeleccionarOpcion()
        {
            int numOpcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            opciones[numOpcion - 1].Accion.Invoke();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Sumar()
        {
            double a = ObtenerNumero("Ingrese el primer número: ");
            double b = ObtenerNumero("Ingrese el segundo número: ");
            Console.WriteLine($"Resultado: {calculador.Sumar(a, b)}");
        }

        public void Restar()
        {
            double a = ObtenerNumero("Ingrese el primer número: ");
            double b = ObtenerNumero("Ingrese el segundo número: ");
            Console.WriteLine($"Resultado: {calculador.Restar(a, b)}");
        }

        public void Multiplicar()
        {
            double a = ObtenerNumero("Ingrese el primer número: ");
            double b = ObtenerNumero("Ingrese el segundo número: ");
            Console.WriteLine($"Resultado: {calculador.Multiplicar(a, b)}");
        }

        public void Dividir()
        {
            double a = ObtenerNumero("Ingrese el primer número: ");
            double b = ObtenerNumero("Ingrese el segundo número: ");
            try
            {
                Console.WriteLine($"Resultado: {calculador.Dividir(a, b)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private double ObtenerNumero(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }
    }
}
