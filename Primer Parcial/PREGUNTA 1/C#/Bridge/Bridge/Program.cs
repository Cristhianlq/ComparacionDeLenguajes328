using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*La abstracción define la interfaz para la parte de "control" de las dos jerarquías de clases. 
     * Mantiene una referencia a un objeto de la jerarquía de implementación y delega todo 
     * el trabajo real a este objeto..*/
    class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }

    // Puede extender la abstracción sin cambiar las clases de implementación.
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation)
            : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }

    /* La implementación define la interfaz para todas las clases de implementación. 
    No tiene que coincidir con la interfaz de Abstraction. De hecho, las dos interfaces 
     * pueden ser completamente diferentes. Normalmente, la interfaz de implementación 
     * proporciona solo operaciones primitivas, mientras que la abstracción define operaciones 
     * de nivel superior basadas en esas primitivas.*/
    public interface IImplementation
    {
        string OperationImplementation();
    }

    // Cada Implementación Concreta corresponde a una plataforma específica y
    // implementa la interfaz de implementación utilizando la API de esa plataforma.
    class materiaTeorica : IImplementation
    {
        public void calificar() {	
		Console.WriteLine("Introduce el nombre de la materia a evaluar: ");
		String nombreM = Console.ReadLine();
        List<int> notas = new List<int>();
		if (buscarMateria(nombreM)) {
			Console.WriteLine("Introduce el nombre del estudiante a evaluar:");
			String nombreA = Console.ReadLine();
			if (buscarAlumno(nombreA)) {
				Console.WriteLine("Introduce la cantidad de examenes a evaluar:");
				int cantExamenes = int.Parse(Console.ReadLine());
				for (int i = 0; i < cantExamenes; i++) {
					Console.WriteLine("Intoduce la nota asignada al examen numero " + (i + 1) + ": ");
                    notas.Add(int.Parse(Console.ReadLine()));
				}
				int nota = 0;
				for (int i = 0; i < cantExamenes; i++) {
					Console.WriteLine("Introduce la nota del examen " + (i + 1) + " del estudiante " + nombreA
                            + ": (En el rango" + notas.ElementAt(i) + ")");
                    nota += int.Parse(Console.ReadLine());
				}
				if (nota > 51)
					Console.WriteLine("El alumno " + nombreA + " aprobo con la nota de: " + nota);
				else
					Console.WriteLine("El alumno " + nombreA + " reprobo con la nota de: " + nota);
			} else
				Console.WriteLine("Alumno no encontrado");
		} else
			Console.WriteLine("Materia no encontrada");
		Console.WriteLine("\n...Fin Bridge...");
	}

        private bool buscarAlumno(String nombre)
        {
            String[] alumnosT = { "Cristhian", "Rosario", "Jorge", "Rodrigo", "Virginia", "Pepe" };
            return alumnosT.Contains(nombre);
        }

        private bool buscarMateria(String nombreM)
        {
            String[] mTeoricas = { "INF-121", "INF-111", "INF-131", "INF-144", "INF-151", "INF-164" };
            return mTeoricas.Contains(nombreM);
        }
    }

    class materiaPractica : IImplementation
    {
        public void calificar()
        {
            Console.WriteLine("Introduce el nombre de la materia a evaluar: ");
            String nombreM = Console.ReadLine();
            List<int> notas = new List<int>();
            if (buscarMateria(nombreM))
            {
                Console.WriteLine("Introduce el nombre del estudiante a evaluar:");
                String nombreA = Console.ReadLine();
                if (buscarAlumno(nombreA))
                {
                    Console.WriteLine("Introduce la cantidad de examenes a evaluar:");
                    int cantExamenes = int.Parse(Console.ReadLine());
                    for (int i = 0; i < cantExamenes; i++)
                    {
                        Console.WriteLine("Intoduce la nota asignada al examen numero " + (i + 1) + ": ");
                        notas.Add(int.Parse(Console.ReadLine()));
                    }
                    int nota = 0;
                    for (int i = 0; i < cantExamenes; i++)
                    {
                        Console.WriteLine("Introduce la nota del examen " + (i + 1) + " del estudiante " + nombreA
                                + ": (En el rango" + notas.ElementAt(i) + ")");
                        nota += int.Parse(Console.ReadLine());
                    }
                    if (nota > 51)
                        Console.WriteLine("El alumno " + nombreA + " aprobo con la nota de: " + nota);
                    else
                        Console.WriteLine("El alumno " + nombreA + " reprobo con la nota de: " + nota);
                }
                else
                    Console.WriteLine("Alumno no encontrado");
            }
            else
                Console.WriteLine("Materia no encontrada");
            Console.WriteLine("\n...Fin Bridge...");
        }

        private bool buscarAlumno(String nombre)
        {
            String[] alumnosL = { "Alejandro", "Ana", "Luis", "Rodrigo", "Virginia", "Pepe" };
            return alumnosL.Contains(nombre);
        }

        private bool buscarMateria(String nombreM)
        {
            String[] mLaboratorio = { "LAB-111", "LAB-121", "LAB-131", "LAB-273" };
            return mLaboratorio.Contains(nombreM);
        }
    }

    class Client
    {
        // Excepto por la fase de inicialización, donde un objeto de abstracción obtiene
        // vinculado con un objeto de implementación específico, el código del cliente debe
        // solo depende de la clase Abstraction. De esta forma, el código del cliente puede
        // admitir cualquier combinación de abstracción-implementación.
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
             /* El código del cliente debería poder funcionar con cualquier 
            combinación de implementación-abstracción preconfigurada.*/
            Client client = new Client();
            Abstraction abstraction;
            Console.WriteLine("PATRON DE DISEÑO BRIDGE: ");
		    Console.WriteLine("\tMENÚ: \nSeleccione una opcion: \n 1)Materia Teorica \n 2)Materia Practica:");
		    String opcion = Console.ReadLine();
		    if (opcion.Equals("1")){
			    abstraction = new Abstraction(new materiaTeorica());
                client.ClientCode(abstraction);
		    } else {
			    if (opcion.Equals("2")) {
				    abstraction = new ExtendedAbstraction(new materiaPractica());
                    client.ClientCode(abstraction);
			    } else
				Console.WriteLine("Saliendo del sistema....");
		    }
            Console.ReadLine();
        }
            
    }
}
