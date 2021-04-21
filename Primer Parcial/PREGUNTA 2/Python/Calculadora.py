#------------------------------Metodos para calcular en POSTORDEN-------------------------------
from tkinter import *
from math import *
def calculate_total(ppostf):
    operadores = ["**", "/", "*", "+", "-", "(", ")"]
    i = 0
    r = 0
    j = 0
    pila = []
    for j in ppostf:
        if j in operadores:
            n1 = float(pila[len(pila) - 2])
            n2 = float(pila[len(pila) - 1])

            if j == "+":
                r = n1 + n2

            if j == "-":
                r = n1 - n2

            if j == "*":
                r = n1 * n2

            if j == "/":
                r = n1 / n2

            if j == "**":
                r = n1 ** n2

            pila[len(pila) - 2] = r
            pila.pop(len(pila) - 1)
        else:
            pila.append(j)

        i = i + 1

    return pila


def apilar(pcar, ppila, ppostfijo):
    # *** Prioridades de la expresion Infija y de la pila***
    prioridad_infija = {"**": 4, "*": 2, "/": 2,
                        "+": 1, "-": 1, "(": 5, ")": "NA"}
    prioridad_pila = {"**": 3, "*": 2, "/": 2,
                      "+": 1, "-": 1, "(": 0, ")": "NA"}
    # Verificarsi la pila esta vacia
    if len(ppila) == 0:
        ppila.append(pcar)
        return ppila
    #Verificamos si es un parentesis
    if pcar == "(":
        ppila.append(pcar)
        return ppostfijo
    # Sacar todos los operadores de la pila hasta encontrar el parentesis ( que abre
    if pcar == ")":
        indice = - 1
        k = 0
        i = 0
        for k in ppila:
            ppostfijo.append(ppila[indice])
            ppila.pop(indice)
            indice = -1
            if ppila[indice] == "(":
                ppila.pop(indice)
                break
        return ppostfijo
    # --------------------------------------------------------------------------------------------------
    # ***Buscar valor del caracter leido en prioridad_infija
    valor_infija = prioridad_infija[pcar]

    # ***Buscar valor del ultimo operador en prioridad_pila
    car_pila = ppila[-1]
    valor_pila = prioridad_pila[car_pila]
    # Si valor de infija = al valor de la pila sacamos el operador
    # anterior de la pila y lo colocamos en postfijo
    if valor_infija == valor_pila:
        if car_pila != "(":
            ppostfijo.append(car_pila)
        ppila.pop(- 1)
        ppila.append(pcar)
        return ppostfijo
    # --------------------------------------------------------------------------------------------------
    if valor_infija > valor_pila:
        ppila.append(pcar)
        return ppostfijo
    # si valor_pila > valor_infija sacar de la pila todos los operadores de mayor precendencia y
    # luego introducir el valor de la infija en la pilai
    indice = - 1
    while valor_pila > valor_infija:
        ppostfijo.append(ppila[indice])
        ppila.pop()
        if ppila == []:
            break
        indice = - 1
        if len(ppila) > 0:
            car_pila = ppila[indice]
            valor_pila = prioridad_pila[car_pila]
    ppila.append(pcar)
    return ppostfijo

def formar_postfijo(pexpinfija):

    operadores = ["**", "/", "*", "+", "-", "(", ")"]
    exp_postfija = []
    pila = []
    for i in pexpinfija:
        if i in operadores:
            apilar(i, pila, exp_postfija)
        else:
            exp_postfija.append(i)

    # Si la pila aun tiene elementos
    z = -1
    for ii in pila:
        exp_postfija.append(pila[z])
        # pila.pop(z)
        z = z - 1
    return exp_postfija

#Codigo opcional para la conversion de operaciones:
# Ejemplo: 2(3*3) + 3+2(2+2) -> 2 * (3 * 3) + 3 + 2 * (2 + 2)
def basico(pexpinf):
    exp_infija = []
    cad = ""
    indice = 0

    for i in pexpinf:

        if i.isdigit():
            cad = cad + i
            anterior = i
            # Verifica la posibilidad : 1 + (3 + 4) 12 lo transforma en  1 + (3 + 4) * 12
            if indice > 0 and indice <= len(pexpinf) - 2 and pexpinf[indice-1] == ")":
                exp_infija.append("*")
        else:
            # si la cadena tiene alamcenado numeros
            if cad != "":
                exp_infija.append(cad)
                cad = ""
                # Verifica la posibilidad : 1 + 2 (3 + 4)  lo transforma en 1 + 2 * (3 + 4)
                if i == "(" and indice > 0 and indice <= len(pexpinf) - 2 and anterior != '':
                    exp_infija.append("*")
                    anterior = ''
                if i == "*" and indice <= len(pexpinf) - 2:
                    if pexpinf[indice + 1] == "*":
                        exp_infija.append("**")
                    elif pexpinf[indice - 1] != "*":
                        exp_infija.append(i)
                else:
                    exp_infija.append(i)

            else:
                if i == "*":
                    if exp_infija[-1] != "**":
                        exp_infija.append(i)
                else:
                    exp_infija.append(i)
        indice = indice + 1

    # Si finalizo el for y aun tiene car en cad
    if cad != ' ' and cad != '':
        exp_infija.append(cad)
    return exp_infija

# -----------------------------------INTERFAZ GRAFICA FUNCIONES DE LOS-------------------------------------------------------

# VISUALIZAR LA OPERACION EN LA PANTALLA
def btnClik(num):
    global operador
    operador = operador+str(num)
    input_text.set(operador)

# CÁLCULO Y MUESTRA DE RESULTADOS.
#Llamado a convertir expInfija a PostFija
def resultado():
    global operador
    #print(expinfija)
    operador = basico(operador.replace(' ', ''))
    postfijo = formar_postfijo(operador)
    #print(postfijo)
    try:
        opera = str(calculate_total(postfijo).pop(0))
        input_text.set(opera)
    except:
        input_text.set("ERROR")
    operador = ""

# LIMPIEZA DE PANTALLA.
def clear():
    global operador
    operador = ("")
    input_text.set("0")

# BORRAR DIGITO
def deleteDigit():
    global operador
    operador = operador[0:len(operador)-1]
    input_text.set(operador)

#-------------------PARAMETROS PARA LAS VENTANAS---------------------
ventana = Tk()
ventana.title("CALCULADORA")
ventana.geometry("392x500")
ventana.configure(background="gray14")
color_boton = ("gray23")
color_boton_op = ("seagreen")
color_boton_operator = ("indianred")
color_boton_igual = ("navy")
color_texto = ("ghost white")

ancho_boton = 11
alto_boton = 3
input_text = StringVar()
operador = ""
fuente = ('verdana', 20, 'bold')

Salida = Entry(ventana, font=('arial', 20, 'bold'), width=22,
               textvariable=input_text, bd=20, insertwidth=4, bg="gray76", justify="right")
Salida.place(x=10, y=60)

# CREAMOS NUESTROS BOTONES
# ----------------Botones numericos------------------

Button(ventana, text="C", fg=color_texto, bg=color_boton_operator,
       width=ancho_boton, height=alto_boton, command=clear).place(x=17, y=180)
Button(ventana, text="(", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik("(")).place(x=107, y=180)
Button(ventana, text=")", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(")")).place(x=197, y=180)
Button(ventana, text="/", fg=color_texto, bg=color_boton_op, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik("/")).place(x=287, y=180)
fg = color_texto,
Button(ventana, text="7", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(7)).place(x=17, y=240)
Button(ventana, text="8", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(8)).place(x=107, y=240)
Button(ventana, text="9", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(9)).place(x=197, y=240)
Button(ventana, text="*", fg=color_texto, bg=color_boton_op, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik("*")).place(x=287, y=240)
fg = color_texto,
Button(ventana, text="4", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(4)).place(x=17, y=300)
Button(ventana, text="5", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(5)).place(x=107, y=300)
Button(ventana, text="6", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(6)).place(x=197, y=300)
Button(ventana, text="-", fg=color_texto, bg=color_boton_op, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik("-")).place(x=287, y=300)
fg = color_texto,
Button(ventana, text="1", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(1)).place(x=17, y=360)
Button(ventana, text="2", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(2)).place(x=107, y=360)
Button(ventana, text="3", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(3)).place(x=197, y=360)
Button(ventana, text="+", fg=color_texto, bg=color_boton_op, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik("+")).place(x=287, y=360)
fg = color_texto,
Button(ventana, text=",", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(".")).place(x=17, y=420)
Button(ventana, text="0", fg=color_texto, bg=color_boton, width=ancho_boton,
       height=alto_boton, command=lambda: btnClik(0)).place(x=107, y=420)
Button(ventana, text="←", fg=color_texto, bg=color_boton_operator, width=ancho_boton,
       height=alto_boton, command=deleteDigit).place(x=197, y=420)
Button(ventana, text="=", fg=color_texto, bg=color_boton_igual,
       width=ancho_boton, height=alto_boton, command=resultado).place(x=287, y=420)
clear()
ventana.mainloop()
