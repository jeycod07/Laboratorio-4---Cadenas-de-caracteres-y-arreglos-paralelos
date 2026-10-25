
using System;

class Program
{
    static void Main()
    {
        string texto = "Bienvenidos al laboratorio de programacion";

        Console.WriteLine("=== LABORATORIO 4 ===");
        Console.WriteLine("Texto original: " + texto);

        // Obtener una subcadena
        string subcadena = texto.Substring(0, 11);
        Console.WriteLine("\nSubcadena: " + subcadena);

        // Buscar una palabra
        int posicion = texto.IndexOf(
           "laboratorio",
           StringComparison.OrdinalIgnoreCase
        );

        // Reemplazar una palabra
        string reemplazo = texto.Replace("laboratorio", "curso");
        Console.WriteLine("Texto reemplazado: " + reemplazo);

        // Separar el texto en palabras
        string[] palabras = texto.Split(' ');

        Console.WriteLine("\nPalabras separadas:");
        foreach (string palabra in palabras)
        {
            Console.WriteLine(palabra);
        }

        
        // LISTAS PARALELAS
        Console.WriteLine("\n=== LISTAS PARALELAS ===");

        string[] nombres = { "Ana", "Carlos", "Maria", "Pedro" };
        int[] edades = { 20, 22, 19, 25 };

        Console.WriteLine("\nLista de personas:");

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
        }

        // Buscar una persona por nombre
        Console.Write("\nIngrese el nombre a buscar: ");
        string buscar = (Console.ReadLine() ?? "").Trim();

        bool encontrado = false;

        for (int i = 0; i < nombres.Length; i++)
        {
            if (nombres[i].Equals(buscar, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nombre: " + nombres[i]);
                Console.WriteLine("Edad: " + edades[i] + " años");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Persona no encontrada.");
        }

        
        // ESTRUCTURA COMBINADA
        Console.WriteLine("\n=== LISTA DE USUARIOS ===");

        var usuarios = new[]
        {
            new { Nombre = "Ana", Email = "ana@gmail.com", Ciudad = "Lima" },
            new { Nombre = "Carlos", Email = "carlos@gmail.com", Ciudad = "Arequipa" },
            new { Nombre = "Maria", Email = "maria@gmail.com", Ciudad = "Lima" },
            new { Nombre = "Pedro", Email = "pedro@gmail.com", Ciudad = "Cusco" }
        };

        foreach (var usuario in usuarios)
        {
            Console.WriteLine("Nombre: " + usuario.Nombre);
            Console.WriteLine("Correo: " + usuario.Email);
            Console.WriteLine("Ciudad: " + usuario.Ciudad);
            Console.WriteLine("------------------------");
        }

        
        // BUSQUEDA DE USUARIOS POR CIUDAD
        Console.WriteLine("\n=== BUSQUEDA POR CIUDAD ===");

        Console.Write("\nIngrese la ciudad a buscar: ");
        string ciudadBuscar = (Console.ReadLine() ?? "").Trim();

        bool ciudadEncontrada = false;

        foreach (var usuario in usuarios)
        {
            if (usuario.Ciudad.Equals(
                ciudadBuscar,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nNombre: " + usuario.Nombre);
                Console.WriteLine("Correo: " + usuario.Email);
                Console.WriteLine("Ciudad: " + usuario.Ciudad);

                ciudadEncontrada = true;
            }
        }

        if (!ciudadEncontrada)
        {
            Console.WriteLine("No se encontraron usuarios en esa ciudad.");
        }

        
        // ORDENAMIENTO ALFABETICO DE USUARIOS
        Console.WriteLine("\n=== USUARIOS ORDENADOS ALFABETICAMENTE ===");

        var usuariosOrdenados = usuarios
            .OrderBy(u => u.Nombre)
            .ToList();

        foreach (var usuario in usuariosOrdenados)
        {
            Console.WriteLine("Nombre: " + usuario.Nombre);
            Console.WriteLine("Correo: " + usuario.Email);
            Console.WriteLine("Ciudad: " + usuario.Ciudad);
            Console.WriteLine("------------------------");
        }
    }
}

