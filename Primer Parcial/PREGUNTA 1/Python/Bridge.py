from __future__ import annotations
from abc import ABC, abstractmethod

class Abstraction:
    """
    La abstracción define la interfaz para la parte de "control" de los dos
    jerarquías de clases. Mantiene una referencia a un objeto del
    Implementación de jerarquía y delega todo el trabajo real a este objeto.
    """
    def __init__(self, implementation: Implementation) -> None:
        self.implementation = implementation

    def operation(self) -> str:
        return (f"Abstraction: Base operation with:\n"
                f"{self.implementation.operation_implementation()}")


class ExtendedAbstraction(Abstraction):
    """
    Puede extender la abstracción sin cambiar las clases de implementación.
    """
    def operation(self) -> str:
        return (f"ExtendedAbstraction: Extended operation with:\n"
                f"{self.implementation.operation_implementation()}")

class Implementation(ABC):
    """
    La implementación define la interfaz para todas las clases de implementación. 
    No tiene que coincidir con la interfaz de Abstraction. 
    De hecho, las dos interfaces pueden ser completamente diferentes. 
    Normalmente, la interfaz de implementación proporciona solo operaciones primitivas, 
    mientras que la abstracción define operaciones de nivel superior basadas en esas primitivas.
    """
    @abstractmethod
    def operation_implementation(self) -> str:
        pass


"""
Cada Implementación Concreta corresponde a una plataforma e implementos específicos
la interfaz de implementación utilizando la API de esa plataforma.
"""


class ConcreteImplementationA(Implementation):
    def operation_implementation(self) -> str:
        nombres = ["Marta", "Ana", "Luis", "Rodrigo", "Virginia", "Pedro", "Cristhian"]
        numCalificaciones = int(input("Introduce el numero de calificaciones a evaluar"))
        nota = 0
        nombre = "Pedro"
        if nombre in nombres:
            for i in range(numCalificaciones):
                print("Introduce la nota ", (i+1), " del alumno")
                nota = nota + int(input())
            if nota > 51:
                return "APROBO CON "+str(nota)
            else:
                return "REPROBO CON "+str(nota)
        else:
            return "Alumno no encontrado"


class ConcreteImplementationB(Implementation):
    def operation_implementation(self) -> str:
        nombres = ["Marta", "Ana", "Luis", "Rodrigo", "Virginia", "Pedro", "Cristhian"]
        numCalificaciones = int(input("Introduce el numero de calificaciones a evaluar"))
        nota = 0
        nombre = "Pedro"
        if nombre in nombres:
            for i in range(numCalificaciones):
                print("Introduce la nota ", (i+1), " del alumno")
                nota = nota + int(input())
            if nota > 51:
                return "APROBO CON "+str(nota)
            else:
                return "REPROBO CON "+str(nota)
        else:
            return "Alumno no encontrado"



def client_code(abstraction: Abstraction) -> None:
    """
    Excepto por la fase de inicialización, donde un objeto de abstracción se vincula
    con un objeto de implementación específico, el código de cliente solo debe depender de
    la clase Abstracción. De esta forma, el código del cliente puede admitir cualquier 
    combinación de implementación y abstracción.
    """
    # ...
    print(abstraction.operation(), end="")
    # ...

if __name__ == "__main__":
    """
    El código del cliente debería poder trabajar con cualquier abstracción preconfigurada.
    combinación de implementación.
    """
    print("PATRON DE DISEÑO BRIDGE: ")
    print("\tMENÚ: \nSeleccione una opcion: \n 1)Materia Teorica \n 2)Materia Practica:")
    opcion = input()
    if opcion == "1":
        implementation = ConcreteImplementationA()
        abstraction = Abstraction(implementation)
        client_code(abstraction)
    elif opcion == "2":
        implementation = ConcreteImplementationB()
        abstraction = ExtendedAbstraction(implementation)
        client_code(abstraction)
    else:
        print("Saliendo del sistema...")