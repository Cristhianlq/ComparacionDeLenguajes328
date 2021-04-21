from __future__ import annotations
class Facade:
    """
    La clase Facade proporciona una interfaz simple para la lógica compleja de uno o varios subsistemas.
    La Fachada delega las solicitudes del cliente a los objetos apropiados dentro del subsistema. 
    The Facade también es responsable de administrar su ciclo de vida. Todo esto protege al cliente de la 
    complejidad no deseada del subsistema.
    """
    def __init__(self, svalidarCalificacion: SvalidarCalificacion, scalificar: Scalificar) -> None:
        """
        Dependiendo de las necesidades de su aplicación, puede proporcionar a Facade objetos de subsistema 
        existentes o forzar a Facade a crearlos por sí mismo.
        """
        self._svalidarCalificacion= svalidarCalificacion or SvalidarCalificacion()
        self._scalificar = scalificar or Scalificar()
    
    def calificar(self):
        validador = SvalidarCalificacion()
        calificador = Scalificar()
        print("Starting Facade \nSelecciona una opcion:")
        print("\tMENÚ \n1)Materia Teorica \n2)Materia Laboratorio")
        opcion = str(input())
        if opcion == "1":
            nombreMateria = input("Introduce el nombre de la Materia: ")
            if (validador.buscarMateriaT(nombreMateria)):
                nombreEst = input("Introduce el nombre del Estudiante: ")
                if (validador.buscarAlumnoTeorica(nombreEst)):
                    calificador.calificarTeorica(nombreEst)
                else:
                    print("Alumno no encontrado")
            else:
                print("Materia no valida")
        elif opcion == "2":
            nombreMateria = input("Introduce el nombre de la Materia: ")
            if (validador.buscarMateriaL(nombreMateria)):
                nombreEst = input("Introduce el nombre del Estudiante: ")
                if (validador.buscarAlumnoLabo(nombreEst)):
                    calificador.calificarLabo(nombreEst)
                else:
                    print("Alumno no encontrado")
            else:
                print("Materia no valida")
        else:
            print("Opcion no valida")
        print("...FIN FACADE...")

class SvalidarCalificacion:

    def buscarAlumnoTeorica(self, nombre):
        alumnosT=[ "Cristhian", "Rosario", "Jorge", "Rodrigo", "Virginia", "Pepe"]
        if nombre in alumnosT:
            return True
        else:
            return False
    def buscarAlumnoLabo(self, nombre):
        alumnosL=["Alejandro", "Ana", "Luis", "Rodrigo", "Virginia", "Pepe"]
        if nombre in alumnosL:
            return True
        else:
            return False
    
    def buscarMateriaT(self, nombreM):
        mTeoricas=[ "INF-121", "INF-111", "INF-131", "INF-144", "INF-151", "INF-164"]
        if nombreM in mTeoricas:
            return True
        else:
            return False

    def buscarMateriaL(self, nombreL):
        mLaboratorio=[ "LAB-111", "LAB-121", "LAB-131", "LAB-273"]
        if nombreL in mLaboratorio:
            return True
        else:
            return False

class Scalificar:
    def calificarTeorica(self, nombreEst):
        notas=[]
        print("Introduce la cantidad de examenes a evaluar: ")
        numExamenes = int(input())
        for i in range(numExamenes):
            print("Introduce sobre cuanto se evaluara el examen: ", (i + 1), ": ")
            notas.append(int(input()))
        print("Evaluando al alumno ",nombreEst)
        notaFinal = 0
        for i in range(numExamenes):
            print("Nota del examen: ", (i + 1), ": (Debe estar en el rango definido de ", notas[i],")")
            notaFinal = notaFinal + int(input())
        if notaFinal >= 51:
            print("El estudiante ", nombreEst, " APROBO con ", notaFinal)
        else:
            print("El estudiante ", nombreEst ," REPROBO con ", notaFinal)
        notas=[]

    def calificarLabo(self, nombreEst):
        notas=[]
        print("Introduce la cantidad de LABORATORIOS a evaluar: ")
        numExamenes = int(input())
        for i in range(numExamenes):
            print("Introduce sobre cuanto se evaluara el LABORATORIO: ", (i + 1), ": ")
            notas.append(int(input()))
        print("Evaluando al alumno ",nombreEst)
        notaFinal = 0
        for i in range(numExamenes):
            print("Nota del LABORATORIO: ", (i + 1), ": (Debe estar en el rango definido de ", notas[i],")")
            notaFinal = notaFinal + int(input())
        if notaFinal >= 51:
            print("El estudiante ", nombreEst, " APROBO con ", notaFinal)
        else:
            print("El estudiante ", nombreEst ," REPROBO con ", notaFinal)
        notas=[]

def client_code(facade: Facade) -> None:
    """
    El código del cliente funciona con subsistemas complejos a través de una interfaz simple proporcionada por Facade. 
    Cuando una fachada gestiona el ciclo de vida del subsistema, es posible que el cliente ni siquiera sepa sobre 
    la existencia del subsistema. Este enfoque le permite mantener la complejidad bajo control.
    """
    facade.calificar()


if __name__ == "__main__":
    # El código de cliente puede tener algunos de los objetos del subsistema ya creados.
    # En este caso, podría valer la pena inicializar la Fachada con estos 
    # objetos en lugar de dejar que la Fachada cree nuevas instancias.
    subsystem1 = SvalidarCalificacion()
    subsystem2 = Scalificar()
    facade = Facade(subsystem1, subsystem2)
    facade.calificar()