using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
   public class Facade
    {
       public void calificar() 
        {
            validarCalificacion validador = new validarCalificacion();
            calificar calificador = new calificar(); 
		    Console.WriteLine("Starting Facade \nSelecciona una opcion:");
		    Console.WriteLine("\tMENÚ \n1)Materia Teorica \n2)Materia Laboratorio");
		    String opcion = Console.ReadLine();
		    switch (opcion) {
		    case "1": {
			    String nombreMateria = LeerNombreMateria();
			    if (validador.buscarMateriaT(nombreMateria)) {
				    String nombreEst = LeerNombre();
				    if (validador.buscarAlumnoTeorica(nombreEst))
					    calificador.calificarTeorica(nombreEst);
				    else
					    Console.WriteLine("Alumno no encontrado");
			    } else
				    Console.WriteLine("Materia no valida");
			    break;
		    }
		    case "2": {
			    String nombreMateria = LeerNombreMateria();
			    if (validador.buscarMateriaL(nombreMateria)) {
				    String nombreEst = LeerNombre();
				    if (validador.buscarAlumnoLabo(nombreEst))
					    calificador.calificarLabo(nombreEst);
				    else
					    Console.WriteLine("Alumno no encontrado");
			    } else
				    Console.WriteLine("Materia no valida");
			    break;
		    }
		    default:
			    Console.WriteLine("Opcion no valida");
			    break;
		    // throw new IllegalArgumentException("Unexpected value: " + opcion);
		    }
            Console.WriteLine("...FIN FACADE...");
	    }

        private String LeerNombreMateria() 
        {
		    String nombreM = "";
            Console.WriteLine("Introduce el nombre de la materia:");
            nombreM = Console.ReadLine();
		    return nombreM;
	    }

        private String LeerNombre() 
        {
		    String nombre = "";
            Console.WriteLine("Introduce el nombre del estudiante:");
		    nombre = Console.ReadLine();
		    return nombre;
	    }
    }

    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    class validarCalificacion
    {
        String[] alumnosL = { "Alejandro", "Ana", "Luis", "Rodrigo", "Virginia", "Pepe" };
        String[] alumnosT = { "Cristhian", "Rosario", "Jorge", "Rodrigo", "Virginia", "Pepe" };
        String[] mTeoricas = { "INF-121", "INF-111", "INF-131", "INF-144", "INF-151", "INF-164" };
        String[] mLaboratorio = { "LAB-111", "LAB-121", "LAB-131", "LAB-273" };

        public bool buscarAlumnoTeorica(String nombre)
        {
            return alumnosT.Contains(nombre);
        }

        public bool buscarAlumnoLabo(String nombre)
        {
            return alumnosL.Contains(nombre);
        }

        public bool buscarMateriaT(String nombreM)
        {
            return mTeoricas.Contains(nombreM);
        }

        public bool buscarMateriaL(String nombreL)
        {
            return mLaboratorio.Contains(nombreL);
        }
    }
    // Some facades can work with multiple subsystems at the same time.
    class calificar
    {
        public void calificarTeorica(String nombreEst) {
            List<int> notas = new List<int>();
		    Console.WriteLine("Introduce la cantidad de examenes a evaluar: ");
		    int numExamenes = int.Parse(Console.ReadLine());
		    for (int i = 0; i < numExamenes; i++) {
			    Console.WriteLine("Introduce sobre cuanto se evaluara el examen: " + (i + 1) + ": ");
                notas.Add(int.Parse(Console.ReadLine()));

		    }
		    Console.WriteLine("Evaluando al alumno " + nombreEst);
		    int notaFinal = 0;
		    for (int i = 0; i < numExamenes; i++) {
			    Console.WriteLine(
					    "Nota del examen: " + (i + 1) + ": (Debe estar en el rango definido de " + notas.ElementAt(i)+ ")");
                notaFinal += int.Parse(Console.ReadLine());
		    }
		    if (notaFinal >= 51)
			    Console.WriteLine("El estudiante " + nombreEst + " APROBO con " + notaFinal);
		    else
                Console.WriteLine("El estudiante " + nombreEst + " REPROBO con " + notaFinal);
		    notas.Clear();
	    }

        public void calificarLabo(String nombreEst) {
            List<int> notas = new List<int>();
		    Console.WriteLine("Introduce la cantidad de LABORATORIOS a evaluar: ");
            int numLabos = int.Parse(Console.ReadLine());
		    for (int i = 0; i < numLabos; i++) {
			    Console.WriteLine("Introduce sobre cuanto se evaluara el laboratorio: " + (i + 1) + ": ");
                notas.Add(int.Parse(Console.ReadLine()));
		    }
		    Console.WriteLine("Evaluando al alumno " + nombreEst);
		    int notaFinal = 0;
		    for (int i = 0; i < numLabos; i++) {
			    Console.WriteLine(
					    "Nota del examen: " + (i + 1) + ": (Debe estar en el rango definido de " + notas.ElementAt(i) + ")");
                notaFinal += int.Parse(Console.ReadLine());
		    }
		    if (notaFinal >= 51)
			    Console.WriteLine("El estudiante " + nombreEst + " APROBO con " + notaFinal);
		    else
                Console.WriteLine("El estudiante " + nombreEst + " REPROBO con " + notaFinal);
		    notas.Clear();
	    }
    }

    class Client
    {
        // The client code works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know about the existence
        // of the subsystem. This approach lets you keep the complexity under
        // control.
        public static void ClientCode(Facade facade)
        {
            facade.calificar();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Facade facade = new Facade();
            Client.ClientCode(facade);
            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadLine();
        }
    }
}
