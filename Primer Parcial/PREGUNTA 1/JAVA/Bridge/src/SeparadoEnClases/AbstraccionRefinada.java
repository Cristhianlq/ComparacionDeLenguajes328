package SeparadoEnClases;

public class AbstraccionRefinada implements Abstraccion {
	private Implementador implementador;

	public AbstraccionRefinada(Implementador implementador) {
		this.implementador = implementador;
	}

	public void calificar() {
		implementador.calificar();
	}
}
