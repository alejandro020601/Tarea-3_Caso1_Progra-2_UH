using System;

namespace Tarea_3_Caso_1_Progra_2_UH
{
    internal class Program
{
    static void Main(string[] args)
    {
        string nombreEstudiante;
        float notaFinal;
        string estatusEstudiante = "Aprobado";

        Console.WriteLine("Digite el nombre del estudiante:");
        nombreEstudiante = Console.ReadLine();

            do
            {
                Console.WriteLine("Digite la nota final(0.00 a 100.00): ");
                if (!float.TryParse(Console.ReadLine(), out notaFinal)){//esta linea la conoci/comprendi investigando
                                                                        //es la forma que encontre para verificar que el dato que ingresa el usuario no es de otro tipo
                                                                        //lo que entendi es que TryParse intenta convertir lo que escribió el usuario a float, pero en vez de lanzar un error si no puede, devuelve true o false.
                    Console.WriteLine("Dato inválido");
                    notaFinal = -1;
                }
            }
            while (notaFinal < 0.00 || notaFinal > 100.00);

            //determinar
            if (notaFinal < 70.00) {
                estatusEstudiante = "Reprobado";
            }

        // Mostrar los resultados
        Console.WriteLine("\n--- ESTATUS DEL ESTUDIANTE ---");
        Console.WriteLine(nombreEstudiante + " ---> " + estatusEstudiante);

        Console.Read();
    }
}
}
