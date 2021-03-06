package SeparadoEnClases;

import java.util.Arrays;
import java.util.Scanner;

class materiaTeorica implements Implementador {
	public void calificar() {
		Scanner Leer = new Scanner(System.in);
		System.out.println("Introduce el numero de calificaciones a evaluar");
		int numCalificaciones = Leer.nextInt();
		int nota = 0;
		if (buscarAlumno("Pepe")) {
			for (int i = 0; i < numCalificaciones; i++) {
				System.out.println("Intoduce la nota " + i + " del alumno Pepe: ");
				nota += Leer.nextInt();
			}
			if (nota > 51)
				System.out.println("El alumno Pepe aprobo con la nota de: " + nota);
			else
				System.out.println("El alumno Pepe reprobo con la nota de: " + nota);
		} else
			System.out.println("Alumno no encontrado");
	}

	private boolean buscarAlumno(String nombre) {
		String[] nombres = { "Marta", "Ana", "Luis", "Rodrigo", "Virginia", "Pepe" };
		return Arrays.asList(nombres).contains(nombre);
	}
}
