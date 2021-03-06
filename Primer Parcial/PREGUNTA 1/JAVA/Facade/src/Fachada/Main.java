package Fachada;

import java.util.Arrays;
import java.util.Scanner;
import java.util.Vector;

class validarCalificacion {
	String[] alumnosL = { "Alejandro", "Ana", "Luis", "Rodrigo", "Virginia", "Pepe" };
	String[] alumnosT = { "Cristhian", "Rosario", "Jorge", "Rodrigo", "Virginia", "Pepe" };
	String[] mTeoricas = { "INF-121", "INF-111", "INF-131", "INF-144", "INF-151", "INF-164" };
	String[] mLaboratorio = { "LAB-111", "LAB-121", "LAB-131", "LAB-273" };

	public boolean buscarAlumnoTeorica(String nombre) {
		return Arrays.asList(alumnosT).contains(nombre);
	}

	public boolean buscarAlumnoLabo(String nombre) {
		return Arrays.asList(alumnosL).contains(nombre);
	}

	public boolean buscarMateriaT(String nombreM) {
		return Arrays.asList(mTeoricas).contains(nombreM);
	}

	public boolean buscarMateriaL(String nombreL) {
		return Arrays.asList(mLaboratorio).contains(nombreL);
	}
}

class calificar {
	public void calificarTeorica(String nombreEst) {
		Scanner Leer = new Scanner(System.in);
		Vector<Integer> notas = new Vector<Integer>();
		System.out.println("Introduce la cantidad de examenes a evaluar: ");
		int numExamenes = Leer.nextInt();
		for (int i = 0; i < numExamenes; i++) {
			System.out.println("Introduce sobre cuanto se evaluara el examen: " + (i + 1) + ": ");
			notas.add(Leer.nextInt());
		}
		System.out.println("Evaluando al alumno " + nombreEst);
		int notaFinal = 0;
		for (int i = 0; i < numExamenes; i++) {
			System.out.println(
					"Nota del examen: " + (i + 1) + ": (Debe estar en el rango definido de " + notas.get(i) + ")");
			notaFinal += Leer.nextInt();
		}
		if (notaFinal >= 51)
			System.out.println("El estudiante " + nombreEst + " APROBO con " + notaFinal);
		else
			System.out.println("El estudiante " + nombreEst + " REPROBO con " + notaFinal);
		notas.clear();
	}

	public void calificarLabo(String nombreEst) {
		Scanner Leer = new Scanner(System.in);
		Vector<Integer> notas = new Vector<Integer>();
		System.out.println("Introduce la cantidad de LABORATORIOS a evaluar: ");
		int numLabos = Leer.nextInt();
		for (int i = 0; i < numLabos; i++) {
			System.out.println("Introduce sobre cuanto se evaluara el laboratorio: " + (i + 1) + ": ");
			notas.add(Leer.nextInt());
		}
		System.out.println("Evaluando al alumno " + nombreEst);
		int notaFinal = 0;
		for (int i = 0; i < numLabos; i++) {
			System.out.println(
					"Nota del examen: " + (i + 1) + ": (Debe estar en el rango definido de " + notas.get(i) + ")");
			notaFinal += Leer.nextInt();
		}
		if (notaFinal >= 51)
			System.out.println("El estudiante " + nombreEst + " APROBO con " + notaFinal);
		else
			System.out.println("El estudiante " + nombreEst + " REPROBO con " + notaFinal);
		notas.clear();
	}
}

class Facade {
	public void calificar() {
		Scanner Leer = new Scanner(System.in);
		validarCalificacion validador = new validarCalificacion();
		calificar calificador = new calificar();
		System.out.println("Starting Facade \nSelecciona una opcion:");
		System.out.println("\tMEN? \n1)Materia Teorica \n2)Materia Laboratorio");
		String opcion = Leer.next();
		switch (opcion) {
		case "1": {
			String nombreMateria = LeerNombreMateria();
			if (validador.buscarMateriaT(nombreMateria)) {
				String nombreEst = LeerNombre();
				if (validador.buscarAlumnoTeorica(nombreEst))
					calificador.calificarTeorica(nombreEst);
				else
					System.out.println("Alumno no encontrado");
			} else
				System.out.println("Materia no valida");
			break;
		}
		case "2": {
			String nombreMateria = LeerNombreMateria();
			if (validador.buscarMateriaL(nombreMateria)) {
				String nombreEst = LeerNombre();
				if (validador.buscarAlumnoLabo(nombreEst))
					calificador.calificarLabo(nombreEst);
				else
					System.out.println("Alumno no encontrado");
			} else
				System.out.println("Materia no valida");
			break;
		}
		default:
			System.out.println("Opcion no valida");
			break;
		// throw new IllegalArgumentException("Unexpected value: " + opcion);
		}
		System.out.println("...FIN FACADE...");
	}

	private String LeerNombreMateria() {
		String nombreM = "";
		Scanner Leer = new Scanner(System.in);
		System.out.println("Introduce el nombre de la materia:");
		nombreM = Leer.nextLine();
		return nombreM;
	}

	private String LeerNombre() {
		String nombre = "";
		Scanner Leer = new Scanner(System.in);
		System.out.println("Introduce el nombre del estudiante:");
		nombre = Leer.nextLine();
		return nombre;
	}
}

public class Main {

	public static void main(String[] args) {
		Facade fachada = new Facade();
		fachada.calificar();
	}

}
