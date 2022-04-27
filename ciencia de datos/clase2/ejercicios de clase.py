"""
Crea dos variables con valores enteros y luego imprime los resultados de su suma, resta, multiplicación y división.

Crea dos listas con 3 nombres cada una llamadas grupo1 y grupo2.

Crea una tercera lista llamada grupo3 con los últimos nombres de cada una de las listas grupo1 y grupo2 y elimina esos nombres de las listas originales.

Crea una lista llamada todos con todos los nombres de las listas.

Crea un diccionario que tenga 3 pares de clave valor con países y capitales.

Hace un print de los nombres de lo países.

Mostrá los nombres de las capitales

Agrega una par de país-capital

"""



#1
var1 = 5
var2 = 10
print(var1+var2, var1-var2, var1*var2, var1/var2)
#2
grupo1 = ["Jorge", "Lisa", "Hernan"]
grupo2 = ["Sol", "Juana", "Roberto"]
#3
grupo3 = [grupo1.pop(), grupo2.pop()]
#4
todos = grupo1 + grupo2 + grupo3
#5
capitales = {"peru": "lima", "alemania": "berlin", "egipto": "cairo" }
#6
print(" ".join(capitales))
#7
print(" ".join(map(lambda x: capitales[x], capitales)))
#8
capitales["argentina"]="buenos aires"




