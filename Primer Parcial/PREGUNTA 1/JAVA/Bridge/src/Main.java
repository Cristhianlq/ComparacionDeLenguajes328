import java.util.Arrays;
import java.util.Scanner;
import java.util.Vector;

interface Implementador {
	void calificar();
}

/** primera implementacion de Implementador Materia Teorica **/
class materiaTeorica implements Implementador {
	public void calificar() {
		Scanner Leer = new Scanner(System.in);
		System.out.println("Introduce el nombre de la materia a evaluar: ");
		String nombreM = Leer.next();
		Vector<Integer> notas = new Vector<Integer>();
		if (buscarMateria(nombreM)) {
			System.out.println("Introduce el nombre del estudiante a evaluar:");
			String nombreA = Leer.next();
			if (buscarAlumno(nombreA)) {
				System.out.println("Introduce la cantidad de examenes a evaluar:");
				int cantExamenes = Leer.nextInt();
				for (int i = 0; i < cantExamenes; i++) {
					System.out.println("Intoduce la nota asignada al examen numero " + (i + 1) + ": ");
					notas.add(Leer.nextInt());
				}
				int nota = 0;
				for (int i = 0; i < cantExamenes; i++) {
					System.out.println("Introduce la nota del examen " + (i + 1) + " del estudiante " + nombreA
							+ ": (En el rango" + notas.get(i) + ")");
					nota += Leer.nextInt();
				}
				if (nota > 51)
					System.out.println("El alumno " + nombreA + " aprobo con la nota de: " + nota);
				else
					System.out.println("El alumno " + nombreA + " reprobo con la nota de: " + nota);
			} else
				System.out.println("Alumno no encontrado");
		} else
			System.out.println("Materia no encontrada");
		System.out.println("\n...Fin Bridge...");
	}

	private boolean buscarAlumno(String nombre) {
		String[] alumnosT = { "Cristhian", "Rosario", "Jorge", "Rodrigo", "Virginia", "Pepe" };
		return Arrays.asList(alumnosT).contains(nombre);
	}

	private boolean buscarMateria(String nombreM) {
		String[] alumnosL = { "Alejandro", "Ana", "Luis", "Rodrigo", "Virginia", "Pepe" };
		String[] mTeoricas = { "INF-121", "INF-111", "INF-131", "INF-144", "INF-151", "INF-164" };
		String[] mLaboratorio = { "LAB-111", "LAB-121", "LAB-131", "LAB-273" };
		return Arrays.asList(mTeoricas).contains(nombreM);
	}
}

/** segunda implementacion de Implementador Materia Practica **/
class materiaPractica implements Implementador {
	public void calificar() {
		Scanner Leer = new Scanner(System.in);
		System.out.println("Introduce el nombre del laboratorio a evaluar: ");
		String nombreM = Leer.next();
		Vector<Integer> notas = new Vector<Integer>();
		if (buscarMateria(nombreM)) {
			System.out.println("Introduce el nombre del estudiante a evaluar:");
			String nombreA = Leer.next();
			if (buscarAlumno(nombreA)) {
				System.out.println("Introduce la cantidad de LABORATORIOS a evaluar:");
				int cantExamenes = Leer.nextInt();
				for (int i = 0; i < cantExamenes; i++) {
					System.out.println("Intoduce la nota asignada al LABORATORIO numero " + (i + 1) + ": ");
					notas.add(Leer.nextInt());
				}
				int nota = 0;
				for (int i = 0; i < cantExamenes; i++) {
					System.out.println("Introduce la nota del laboratorio " + (i + 1) + " del estudiante " + nombreA
							+ ": (En el rango" + notas.get(i) + ")");
					nota += Leer.nextInt();
				}
				if (nota > 51)
					System.out.println("El alumno " + nombreA + " aprobo con la nota de: " + nota);
				else
					System.out.println("El alumno " + nombreA + " reprobo con la nota de: " + nota);
			} else
				System.out.println("Alumno no encontrado");
		} else
			System.out.println("Materia no encontrada");
		System.out.println("\n...Fin Bridge...");
	}

	private boolean buscarAlumno(String nombre) {
		String[] alumnosL = { "Alejandro", "Ana", "Luis", "Rodrigo", "Virginia", "Pepe" };
		return Arrays.asList(alumnosL).contains(nombre);
	}

	private boolean buscarMateria(String nombreM) {
		String[] mLaboratorio = { "LAB-111", "LAB-121", "LAB-131", "LAB-273" };
		return Arrays.asList(mLaboratorio).contains(nombreM);
	}
}

/** interfaz de abstracci?n **/
interface Abstraccion {
	void calificar();
}

/** clase refinada que implementa la abstraccion **/
class AbstraccionRefinada implements Abstraccion {
	private Implementador implementador;

	public AbstraccionRefinada(Implementador implementador) {
		this.implementador = implementador;
	}

	public void calificar() {
		implementador.calificar();
	}
}

/** aplicacion que usa el patr?n Bridge **/

public class Main {

	public static void main(String[] args) {
		Scanner Leer = new Scanner(System.in);
		System.out.println("PATRON DE DISE?O BRIDGE: ");
		System.out.println("\tMEN?: \nSeleccione una opcion: \n 1)Materia Teorica \n 2)Materia Practica:");
		String opcion = Leer.next();
		if (opcion.equals("1")) {
			Abstraccion bridge = new AbstraccionRefinada(new materiaTeorica());
			bridge.calificar();
		} else {
			if (opcion.equals("2")) {
				Abstraccion bridge = new AbstraccionRefinada(new materiaPractica());
				bridge.calificar();
			} else
				System.out.println("Saliendo del sistema....");
		}
	}

}
