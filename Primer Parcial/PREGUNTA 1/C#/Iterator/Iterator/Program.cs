using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IteradorConcreto : Iterador {
	    private AgregadoConcreto agregado;
	    private int posicion_actual = 0;
	    public IteradorConcreto(AgregadoConcreto agregado) {
		    this.agregado = agregado;
	    }

	    public Object primero() {
		    Object obj = null;
		    if (!this.agregado.aDatos.Any()) {
			    this.posicion_actual = 0;
			    obj = this.agregado.aDatos.First();
		    }
		    return obj;
	    }

	    public Object siguiente() {
		    Object obj = null;
		    if ((this.posicion_actual) < this.agregado.aDatos.Count()) {
			    obj = this.agregado.aDatos.ElementAt(this.posicion_actual);
			    this.posicion_actual = this.posicion_actual + 1;
		    }
		    return obj;
	    }

	    public bool hayMas() {
		    bool ok = false;
		    if (this.posicion_actual < (this.agregado.aDatos.Count())) {
			    ok = true;
		    }
		    return ok;
	    }

	    public Object actual() {
		    Object obj = null;
		    if (this.posicion_actual < this.agregado.aDatos.Count()) {
			    obj = this.agregado.aDatos.ElementAt(this.posicion_actual);
		    }
		    return obj;
	    }
}

interface Iterador {
	Object primero();

	Object siguiente();

	bool hayMas();

	Object actual();
}

class AgregadoConcreto : Agregado {
	public List<String> aDatos = new List<String>();

	public AgregadoConcreto() {
		Console.WriteLine("Starting Facade \nSelecciona una opcion:");
		Console.WriteLine("\tMENÚ \n1)Materia Teorica \n2)Materia Laboratorio");
		String opcion = Console.ReadLine();
		switch (opcion) {
		case "1": {
			this.llenarTeorico();
			break;
		}
		case "2": {
			this.llenarLabo();
			break;
		}
		default:
			Console.WriteLine("Opcion no valida");
			break;
		}
	}

	public Iterador getIterador() {
		return new IteradorConcreto(this);
	}

	public void llenarTeorico() {
		// Las notas a considerar seran 3:1er Parcial (30), 2do Parcial (30), Final
		// (40),
		this.aDatos.Add("INF-121;Cristhian;30;30;30");
		this.aDatos.Add("INF-131;Pepe;15;15;15");
		this.aDatos.Add("INF-151;Luis;18;28;20");
		this.aDatos.Add("INF-111;Rolando;20;0;30");
		this.aDatos.Add("INF-121;Alejandro;20;18;20");
	}

	public void llenarLabo() {
		// Las notas a considerar seran 5: 5 laboratorios sobre 20 puntos
		this.aDatos.Add("LAB-121;Cristhian;10;15;10;15;0");
		this.aDatos.Add("LAB-121;Alejandro;20;18;20;15;10;");
		this.aDatos.Add("LAB-131;Miguel;12;10;8;20;12");
		this.aDatos.Add("LAB-273;Jose;18;18;12;13;11");
		this.aDatos.Add("LAB-273;Moises;18;18;12;13;11");
	}
}

interface Agregado {
	Iterador getIterador();
}

    class Program
    {
        static void Main(string[] args)
        {
            try {
			// Crear el objeto agregado que contiene la lista (un vector de notas en este
			// ejemplo)
			AgregadoConcreto agregado = new AgregadoConcreto();
			// Crear el objeto iterador para recorrer la lista
			Console.WriteLine("Introduce el nombre de la materia a calificar");
			String materia = Console.ReadLine();
			Iterador iterador = agregado.getIterador();
			// Recorrer todo el vector
			bool sw = true;
			while (iterador.hayMas() == true) {
                String cad = iterador.siguiente() +"";
                String[] arr = cad.Split(';');
				if (arr[0].Equals(materia)) {
					sw = false;
					int nota = 0;
					for (int i = 2; i < arr.Length; i++) {
						nota += int.Parse(arr[i]);
					}
					Console.WriteLine("Nota del alumno: " + arr[1] + " es: " + nota);
				}
			}
			if (sw)
				Console.WriteLine("No se encontro la materia");
            Console.ReadLine();
		} catch (Exception e) {
			Console.WriteLine(e);
		}
        }
    }
}
