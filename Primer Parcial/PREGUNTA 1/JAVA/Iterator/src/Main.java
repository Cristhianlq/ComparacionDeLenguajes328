import java.util.Scanner;
import java.util.Vector;

class IteradorConcreto implements Iterador {
	private AgregadoConcreto agregado;
	private int posicion_actual = 0;

	// -------------------------
	public IteradorConcreto(AgregadoConcreto agregado) {
		this.agregado = agregado;
	}

	// -------------------------
	@Override
	public Object primero() {
		Object obj = null;
		if (this.agregado.aDatos.isEmpty() == false) {
			this.posicion_actual = 0;
			obj = this.agregado.aDatos.firstElement();
		}
		return obj;
	}

	// -------------------------
	@Override
	public Object siguiente() {
		Object obj = null;
		if ((this.posicion_actual) < this.agregado.aDatos.size()) {
			obj = this.agregado.aDatos.elementAt(this.posicion_actual);
			this.posicion_actual = this.posicion_actual + 1;
		}
		return obj;
	}

	// -------------------------
	@Override
	public boolean hayMas() {
		boolean ok = false;
		if (this.posicion_actual < (this.agregado.aDatos.size())) {
			ok = true;
		}
		return ok;
	}

	// -------------------------
	@Override
	public Object actual() {
		Object obj = null;
		if (this.posicion_actual < this.agregado.aDatos.size()) {
			obj = this.agregado.aDatos.elementAt(this.posicion_actual);
		}
		return obj;
	}
}

interface Iterador {
	public Object primero();

	public Object siguiente();

	public boolean hayMas();

	public Object actual();
}

class AgregadoConcreto implements Agregado {
	protected Vector<String> aDatos = new Vector<String>();

	public AgregadoConcreto() {
		Scanner Leer = new Scanner(System.in);
		System.out.println("Starting Facade \nSelecciona una opcion:");
		System.out.println("\tMENÚ \n1)Materia Teorica \n2)Materia Laboratorio");
		String opcion = Leer.next();
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
			System.out.println("Opcion no valida");
			break;
		}
	}

	@Override
	public Iterador getIterador() {
		return new IteradorConcreto(this);
	}

	public void llenarTeorico() {
		// Las notas a considerar seran 3:1er Parcial (30), 2do Parcial (30), Final
		// (40),
		this.aDatos.add(new String("INF-121;Cristhian;30;30;30"));
		this.aDatos.add(new String("INF-131;Pepe;15;15;15"));
		this.aDatos.add(new String("INF-151;Luis;18;28;20"));
		this.aDatos.add(new String("INF-111;Rolando;20;0;30"));
		this.aDatos.add(new String("INF-121;Alejandro;20;18;20"));
	}

	public void llenarLabo() {
		// Las notas a considerar seran 5: 5 laboratorios sobre 20 puntos
		this.aDatos.add(new String("LAB-121;Cristhian;10;15;10;15;0"));
		this.aDatos.add(new String("LAB-121;Alejandro;20;18;20;15;10;"));
		this.aDatos.add(new String("LAB-131;Miguel;12;10;8;20;12"));
		this.aDatos.add(new String("LAB-273;Jose;18;18;12;13;11"));
		this.aDatos.add(new String("LAB-273;Moises;18;18;12;13;11"));
	}
}

interface Agregado {
	public Iterador getIterador();
}

public class Main {
	public static void main(String[] args) {
		try {
			// Crear el objeto agregado que contiene la lista (un vector de notas en este
			// ejemplo)
			AgregadoConcreto agregado = new AgregadoConcreto();
			// Crear el objeto iterador para recorrer la lista
			System.out.println("Introduce el nombre de la materia a calificar");
			Scanner Leer = new Scanner(System.in);
			String materia = Leer.next();
			Iterador iterador = agregado.getIterador();
			// Recorrer todo el vector
			boolean sw = true;
			while (iterador.hayMas() == true) {
				String arr[] = iterador.siguiente().toString().split(";");
				if (arr[0].equals(materia)) {
					sw = false;
					int nota = 0;
					for (int i = 2; i < arr.length; i++) {
						nota += Integer.parseInt(arr[i]);
					}
					System.out.println("Nota del alumno: " + arr[1] + " es: " + nota);
				}
			}
			if (sw)
				System.out.println("No se encontro la materia");
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}