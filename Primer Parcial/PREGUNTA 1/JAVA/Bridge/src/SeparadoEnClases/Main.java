package SeparadoEnClases;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner Leer = new Scanner(System.in);
		System.out.println("PATRON DE DISEÑO BRIDGE: ");
		System.out.println("\tMENÚ: \nSeleccione una opcion: \n 1)Materia Teorica \n 2)Materia Practica:");
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
