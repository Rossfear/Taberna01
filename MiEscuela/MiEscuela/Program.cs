using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    class MiClasePrueba
    {
        protected int pruebaA;
    }
    class Program : MiClasePrueba
    {
        public static void ImprimirMensajeEnPantalla(string mensaje, bool guardar = false)
        {
            Console.WriteLine("Respuesta del sistema: ");
            Console.WriteLine(mensaje);
            if (guardar)
            {
                //Guardar en bd el mensaje
            }
        }
        /*public static void ImprimirMensajePrueba()
        {
            Console.WriteLine("Mensaje de prueba");
        }*/
        static void Main(string[] args)
        {
            Console.Title = "Sistema de Administración Escolar";
            Profesor<int> profInterno = new Profesor<int>();
            string resp = profInterno.Checar();

            Profesor<string> profExterno = new Profesor<string>();

            string nombreEstudiante = "Pepito";
            string gradoGrupo = "5A";
            Estudiante estudiante = new Estudiante(nombreEstudiante, gradoGrupo);
            //estudiante = null;

            bool estatusEstudiante = true;
            Estudiante estudianteB = new Estudiante(estatusEstudiante);

           // Materia miMateria = new Materia();
            //Program miProgram = new Program();

            ImprimirMensajeEnPantalla(resp);

            /*Console.WriteLine("Presiona 0 para mostrar mensaje de prueba");
            int x = Int32.Parse(Console.ReadLine());
            if(x == 0)
            {

                ImprimirMensajeEnPantalla("Mensaje de prueba");
            }*/
           
            //Profesor nuevoProfesor = new Profesor();
            //nuevoProfesor.id = 0;

            /*Program prueba = new Program();
            prueba.pruebaA = 1;*/

            List<int> miLista = new List<int>();
            miLista.Add(5);
            int[] datos = { 1, 3, 2, 4 };
            List<int> miListaB = new List<int>(datos);
            miLista.AddRange(miListaB);
            miLista.Sort();
            foreach(int num in miLista)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();

        }
    }
}
