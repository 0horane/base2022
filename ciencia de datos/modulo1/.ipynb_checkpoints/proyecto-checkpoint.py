"""
Ejercicios Tipos de datos

1 -    Hacer una lista que contenga 3 materias de la escuela

2 -    Eliminar el primer registro de la lista

3 -    Agregar una materia más al final

4 -    Seleccionar el segundo elemento de la lista

5 -    Crear un diccionario con las materias y el nombre del/la profesor/a

6 -     Agregar una materia y un/a profesora/

7 -    Eliminar una materia y un/a profesor/a
"""
#1
materias = ["matematica", "lengua", "ingles"]
#2
materias.pop(0)
#3
materias.append("historia")
#4
materias[1]
#5
dictmaterias = {"matematica": "capalbo", "lengua":"ponzo", "historia": "sarella"}
#6
dictmaterias["ingles"]="migale"
#7
dictmaterias.pop("lengua")


"""
Ejericicios estructuras de control

1-    Definir 2 variables con números (num1 y num2). Crear una estructura condicional donde si los dos números son iguales se imprima "los dos números son iguales" (if... else...)

2-    Crear una estructura condicional donde si "no llueve", "podemos ir a la plaza" y sino "debemos quedarnos en casa" (if... else...)

3-    Definir una lista con 3 números (puede ser la misma que antes). Crear una estructura iterativa donde se imprima cada número +2 (for... in...)

4-    Crear una lista con 5 materias de la escuela. Crear una estructura interativa que permita CONTAR la cantidad de elementos en la lista (for... in...)

5-    Crea una función que divida dos números que reciba como parámetros

6-    Crea una función que reciba 2 números e incluya un condicional donde si el segundo número es 0 imprima "no se puede realizar esta operación" y sino realice una división entre el primer y el segundo número.

7-    Crear una función que dada una lista de números y un número (parámetros), agregue el número a la lista (def)
"""
#1 
num1=10
num2=11
if num1 == num2:
    print("los dos numeros son iguales")
else:
    print("los dos numeros son diferentes")

#2
tiempo = "no llueve"
if tiempo == "no llueve":
    print("podemos ir a la plaza")
else: 
    print("debemos quedarnos en casa")

#3
numeros = [4,77,3]
for number in numeros:
    print(number+2)

#4
materias = ["matematica", "lengua", "ingles", "historia", "educacion fisica"]
totalmaterias=0
for materia in materias:
    totalmaterias

totalmaterias

#5
def dividir(x,y):
    return x/y

#6
def dividirseguro(x,y):
    if y==0:
        print("no se puede dividir por 0")
    else:
        return x/y

#7
def agregar(plist,pnum):
    plist.append(pnum)




"""

Ejercicios Dataset pandas

Para estos ejercicios utilizaremos un dataset extraído de https://data.buenosaires.gob.ar/dataset/plan-de-vacunacion-covid-19 con la información de las vacunas dadas en la Ciudad de Buenos Aires entre el 8/3/2021 hasta el 31/01/22

import pandas as pd

from google.colab import drive
drive.mount('/content/drive')

Mounted at /content/drive

data = pd.read_csv("/content/drive/MyDrive/Aprender Programando/2022/Guías y Recursos - Trayectos 2021/Recursos/Modulos 1 y 2. Presentación CABA/Ciencia de datos/2022/Módulo 1/dataset_total_vacunas.csv") 

data

Ejercicios pandas 1: exploración

1-    Ver las 3 útlimas filas del dataset.

2-    Ver el tamaño del dataset

3-    Ver los nombres de las columnas

4-    Seleccionar la columna "TIPO_EFECTOR". Ver que valores toma esa columna y cuántos registros hay de cada uno.

5-    ¿Cuál es el registro en el que se dieron mayor cantidad de vacunas de DOSIS_1? ¿Cuántas vacunas se dieron? ¿Y de DOSIS_2?

6-    Eliminar la columna "ID_CARGA

7-    Cambiar los nombres de todas las columnas a minuscula

"""
import pandas as pd
data = pd.read_csv("datasetproyecto.csv")


#1
data.tail(3)
#2
len(data)
data.shape[0]
#3
data.columns
#4
data.groupby("TIPO_EFECTOR").size()
#5
data["DOSIS_1"].idxmax()
data["DOSIS_1"].max()
data["DOSIS_2"].idxmax()
data["DOSIS_2"].max()
#6
data.drop(columns="ID_CARGA")
#7
lowercasedict = dict()
for column in data.columns:
    lowercasedict[column]=column.lower()
data.rename(columns=lowercasedict, inplace=True)

"""
Ejercicios pandas 2: filtrar y agrupar

1-    Crear un nuevo Dataframe solamente con las vacunas aplicadas en Efectores Públicos.

2-    Crear un nuevo Dataframe solamente con las vacunas aplicadas a personas de entre 41 a 50 años.

3-    Calcular cuántas vacunas DOSIS_1 "Sinopharm" se dieron en efectores Públicos. Hacer con dos filtros, debe usarse el signo "&" y colocar cada uno entre parentesis: [(filtro1) & (filtro2)]

4-    Calcular cuántas vacunas "Sputik" DOSIS_2 se dieron a mujeres.

5-    Generar un Dataframe con la cantidad de vacunas DOSIS_1 que se dieron para mujeres. Y generar otro Dataframe para hombres. Usar groupby.

6-    Generar un Dataframe que tenga la cantidad de vacunas DOSIS_1 aplicadas a mujeres y hombres de cada tipo de vacuna. Usar groupby.

7-    Calcular cuántas vacunas de DOSIS_1 y cuantas vacunas de DOSIS_2 se dieron en cada efector, y en total (sumadas las dos).
"""
originaldata =  pd.read_csv("datasetproyecto.csv", sep=",")

#1
data2 = originaldata.copy() 
filtropublico = data2["TIPO_EFECTOR"]=="Público" #suponiendo que no queremos los publicos nacionales
data2=data.loc[filtropublico]

#2

data3= originaldata.copy() 


"""
Ejercicios opcionales

Usar estructuras de control en DataFrames

    Utilizar una iteración (for) para ver el registro con mayor cantidad de DOSIS_1 en cada Efector.

    Utilizar una iteración (for) para generar un Dataframe solo con los registros de mujeres y otro solo con los registros de los hombres.

    Crear una función (def) que reciba como parámetro la "VACUNA" y devuelva la cantidad de DOSIS_1 que se dieron a mujeres.

    Crear una función (def) que reciba como parámetro el género y devuelva la la cantidad de DOSIS_2 que se dieron.

    Crear una función (def) que reciba como parámetro el Tipo de Efector y devuelva la cantidad de registros que hay en cada uno.

    Utilizar un condicional (if) que sume la cantidad de vacunas DOSIS_1 aplicadas a hombres y la cantidad de vacunas DOSIS_2 aplicadas a mujeres.

    Utilizar un condicional (if) que sume la cantidad de vacunas DOSIS_1 y DOSIS_2 en el caso de Efectores Públicos, solo las DOSIS_1 en el caso de EFectores Privados y solo DOSIS_2 en el caso de Efectores Público Nacional

    Utilizar un condicional (if) que calcule la cantidad de vacunas DOSIS_1 de "Sputnik", DOSIS_2 de "Sinopharm" y la suma de las dos dosis de "Aztrazeneca"

    Hacer una función (def) que reciba como parámetro un rango de edad y utilizando un condicional (if) devuelva la cantidad de vacunas DOSIS_1 aplicadas en el caso de las mujeres y DOSIS_2 en el caso de hombres.

    Hacer una función que reciba como parámetro un rango de edad y a través de una interación devuelva la cantidad de vacunas aplicadas DOSIS_1 y DOSIS_2.

    Hacer una función (def) que reciba como parámetro un rango de edad y utilizando un condicional (if) devuelva la cantidad de vacunas DOSIS_1 aplicadas en el caso de las mujeres y DOSIS_2 en el caso de hombres.

"""

























