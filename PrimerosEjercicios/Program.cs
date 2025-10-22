using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosEjercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Que ejercicio quieres hacer?");
            int ej = int.Parse(Console.ReadLine());
            switch (ej)
            {
                case 1:
                    ejercicio1();
                    break;
            }
            switch (ej)
            {
                case 2:
                    ejercicio2();
                    break;
            }
            switch (ej)
            {
                case 3:
                    ejercicio3();
                    break;
            }
            switch (ej)
            {
                case 4:
                    ejercicio4();
                    break;
            }
            switch (ej)
            {
                case 5:
                    ejercicio5();
                    break;
            }
            switch (ej)
            {
                case 6:
                    ejercicio6();
                    break;
            }
            switch (ej)
            {
                case 7:
                    ejercicio7();
                    break;
            }
            switch (ej)
            {
                case 8:
                    ejercicio8();
                    break;
            }
            switch (ej)
            {
                case 9:
                    ejercicio9();
                    break;
            }
            switch (ej)
            {
                case 10:
                    ejercicio10();
                    break;
            }
            switch (ej)
            {
                case 11:
                    ejercicio11();
                    break;
            }
            switch (ej)
            {
                case 12:
                    ejercicio12();
                    break;
            }

        }

        static void ejercicio1()
        {
            Console.WriteLine("Ingrese el tamaño del array:");
            int tamArray = int.Parse(Console.ReadLine());
            int[] array = new int[tamArray];

            for (int i = 0; i < tamArray; i++)
            {
                Console.WriteLine($"Ingrese el numero en la posición {i}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            int suma = 0;

            foreach (int i in array)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
            Console.WriteLine(suma / array.Length);
        }
        static void ejercicio2()
        {
            Console.WriteLine("Introduce una frase:");
            String frase = Console.ReadLine();
            int espacios = frase.Count(esp => esp == ' ');
            Console.WriteLine("Numero de espacios:");
            Console.WriteLine(espacios);
            Console.WriteLine("Numero de caracteres:");
            Console.WriteLine(countcharacters(frase));
            int countcharacters(String linea)
            {
                int total = 0;
                foreach (char c in linea)
                {
                    total++;
                }
                return total;
            }
        }
        static void ejercicio3()
        {
            Console.WriteLine("Dime un numero para calcular el factorial:");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("El numero no puede ser negativo");
            }
            else
            {
                Console.WriteLine(calcularfactorial(numero));
                int calcularfactorial(int num)
                {

                    if (num == 0 || num == 1)
                        return 1;
                    else
                        return num * calcularfactorial(num - 1);
                }
            }
        }
        static void ejercicio4()
        {
            Console.Write("Introduce un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} NO es un número primo.");
            }

            bool EsPrimo(int n)
            {
                if (n <= 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }

                return true;
            }
        }
        static void ejercicio5()
        {
            Console.WriteLine("Calcular potencia X");
            Console.WriteLine("Introduce la base:");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el exponente:");
            int exp = int.Parse(Console.ReadLine());

            long resultadoInterativa = PotenciaIterativa(bas, exp);
            long resultadoRecursiva = PotenciaRecursiva(bas, exp);
            Console.WriteLine("Interativa");
            Console.WriteLine(resultadoInterativa);
            Console.WriteLine("Recursiva");
            Console.WriteLine(resultadoRecursiva);

            long PotenciaIterativa(int baseNum, int expe)
            {
                long resultado = 1;
                for (int i = 0; i < expe; i++)
                {
                    resultado *= baseNum;
                }
                return resultado;
            }


            long PotenciaRecursiva(int baseNum, int expe)
            {
                if (expe == 0)
                    return 1;
                else
                    return baseNum * PotenciaRecursiva(baseNum, expe - 1);
            }

        }
        static void ejercicio6()
        {
            int intentos = 0;
            bool accesoConcedido = false;

            while (intentos < 3 && !accesoConcedido)
            {
                Console.Write("Introduce el nombre de usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Introduce la contraseña: ");
                string contrasena = Console.ReadLine();

                if (ValidarLogin(usuario, contrasena))
                {
                    Console.WriteLine("Acceso concedido. Bienvenido.");
                    accesoConcedido = true;
                }
                else
                {
                    intentos++;
                    Console.WriteLine("Usuario o contraseña incorrectos.");
                }
            }

            if (!accesoConcedido)
            {
                Console.WriteLine("Has superado el número máximo de intentos. Acceso denegado.");
            }
        }

        static bool ValidarLogin(string usuario, string contrasena)
        {
            return usuario == "usuario2DAM" && contrasena == "pass2DAM";
        }

        static void ejercicio7()
        {
            Console.Write("Introduce el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (EsMultiplo(num1, num2))
            {
                Console.WriteLine($"{num1} es múltiplo de {num2}.");
            }
            else if (EsMultiplo(num2, num1))
            {
                Console.WriteLine($"{num2} es múltiplo de {num1}.");
            }
            else
            {
                Console.WriteLine("Ninguno de los dos números es múltiplo del otro.");
            }


            bool EsMultiplo(int a, int b)
            {
                if (b == 0) return false;
                return a % b == 0;
            }
        }
        static void ejercicio8()
        {
            Console.WriteLine("Introduce el numero:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma es: {sumarnum(numero)}");

            int sumarnum(int num)
            {
                int suma = 0;
                while (num > 0)
                {
                    suma += num % 10;
                    num = num / 10;
                }
                return suma;
            }
        }
        static void ejercicio9()
        {


            int[] numeros = { 5, 2, 7, 4, 5, 9 };
            int posicionMenor = ObtenerPosicionMenor(numeros);
            Console.WriteLine($"La posición del número menor es: {posicionMenor}");
        }

        static int ObtenerPosicionMenor(int[] array)
        {
            int menor = array[0];
            int posicion = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < menor)
                {
                    menor = array[i];
                    posicion = i;
                }
            }

            return posicion;
        }

        static void ejercicio10()
        {
            Banco banco = new Banco();
            banco.Operar();
            banco.ObtenerEstado();
        }
        public class Cliente
        {
            private string nombre;
            private double cantidadTotal;

            public Cliente(string nombre)
            {
                this.nombre = nombre;
                this.cantidadTotal = 0;
            }

            public void Ingresar(double cantidad)
            {
                cantidadTotal += cantidad;
            }

            public void Sacar(double cantidad)
            {
                if (cantidad <= cantidadTotal)
                {
                    cantidadTotal -= cantidad;
                }
                else
                {
                    Console.WriteLine($"{nombre} no tiene suficiente saldo para retirar {cantidad}");
                }
            }

            public double GetCantidadTotal()
            {
                return cantidadTotal;
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Cliente: {nombre} | Saldo actual: {cantidadTotal} €");
            }
        }
        public class Banco
        {
            private Cliente cliente1;
            private Cliente cliente2;
            private Cliente cliente3;

            public Banco()
            {
                cliente1 = new Cliente("Ana");
                cliente2 = new Cliente("Luis");
                cliente3 = new Cliente("María");
            }

            public void Operar()
            {
                cliente1.Ingresar(1000);
                cliente2.Ingresar(1500);
                cliente3.Ingresar(2000);

                cliente1.Sacar(200);
                cliente2.Sacar(300);
                cliente3.Sacar(500);
            }

            public void ObtenerEstado()
            {
                double totalBanco = cliente1.GetCantidadTotal() +
                                    cliente2.GetCantidadTotal() +
                                    cliente3.GetCantidadTotal();

                Console.WriteLine($"Dinero total del banco: {totalBanco} €");

                cliente1.MostrarInformacion();
                cliente2.MostrarInformacion();
                cliente3.MostrarInformacion();
            }
        }

    }
}
