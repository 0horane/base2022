
# Ejercicios
"""
1. Calculen la suma de los primeros 200 números pares.

2. Crea un condicional que si dos números son distintos, imprima "son distintos". (distinto es *!=*)

3. Crea una lista de amigos/as/es y crea una iteración que permita contar la cantidad de personas en la lista.

4. Crea una lista de números y una iteración que imprima en cada caso el número multiplicado por -1

5. Crear una función que dados 2 números (parámetros), los sume (*def*) 

6. Crea una función que reciba una lista de números y de como resultado la 
multiplicación de todos ellos
"""


#1
#suponiendo que se incluye el 0
sum(range(0,200,2))

#alternativamente
counter=0
for x in range(0,200,2):
  counter+=x
print(counter)

#2
def igualdad (x,y):
  if x!=y:
    print("son distintos")

igualdad(1,2)
igualdad(3,3)

#3
amigos=["ambar","jose","belisario","rocio","galo"]
cantidadamigos=0
for item in amigos:
  cantidadamigos+=1

print(cantidadamigos)

#4
numlist = [43,-43,34,-34,43,-65,8,-3,534,23,5,67,8]
for item in numlist:
  print(item*-1)

print('\n'.join(map(lambda x: str(x*-1), numlist)))

#5
def suma(x,y):
  return x+y

print(suma(1,3))

#6
def product(numlist):
  prodAccumulator=1
  for item in numlist:
    prodAccumulator *= item
  return prodAccumulator

print(product([1,4,5,5,3,3,2,-1]))
