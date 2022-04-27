

"""

## Ejercitación de práctica optativos


#### Tipos de datos

1. Armar una lista con 6 ciudades

2. Seleccionar la segunda ciudad

3. Eliminar la última ciudad

4. Reemplazar la primer ciudad con otra

5. Agregar una ciudad al final

6. Armar un diccionario que tenga 3 duplas de Provincia y Ciudad (ej: "Provincia de Buenos Aires: La Plata"

7. Eliminar el último registro (dupla Ciudad-Provincia)

8. Ver todas las claves (*keys*)
"""
#1
ciudades = ["buenos aires", "cordoba", "tucuman", "bariloche", "resistencia", "neuquen"]
#2
print(ciudades[1])
#3
ciudades.pop()
#4
ciudades[0]="mendoza"
#5
ciudades.append("viedma")
#6
capitalprovincial = {"formosa":"formosa", "posadas":"misiones", "chubut":"rawson"}
#7
capitalprovincial.pop(list(capitalprovincial)[-1])





"""
#### Estructuras de Control

1. Como en una playa, crear una estructura condicional donde si la bandera es igual a "roja", imprima "prohibición de baño", si es "roja con negro", imprima "mar peligroso; si es "amarilla con negro", imprima "mar dudoso" y si es "celeste" imprima "mar calmo"

2. Crear una estructura condicional que indique que si la bandera es "roja" **o** "llueve", imprima "no puedo entrar al mar"

3. Crear una estructura condicional que indique que si "no llueve" **y** la bandera es "celeste" imprima "puedo entrar al mar"

4. Crear una estructura de iteración donde cuente la cantidad de ciudades en la lista creada anteriormente

5. Crear una lista de números y crear una estructura de iteración donde se vayan multiplicando e imprima el resultado final

6. Crear una función que reciba como argumento 2 números y los multiplique

7. Crear una función que reciba como argumento una ciudad y devuelva su Provincia de acuerdo al diccionario definido previamente

8. Crear una función que reciba el color de una bandera e imprima el significado (combinar función con estructura condicional)
"""
"""
#### Exploración de dataset

Para esta ejercitación utilizaremos un dataset extraído de https://data.buenosaires.gob.ar/dataset/murales

Registro de murales relevados por la Comisión para la Preservación del Patrimonio Histórico Cultural de la Ciudad de Buenos Aires con la ubicación, artista, tamaño y nombre de la obra.

#Importamos la librería que utilizaremos

import pandas as pd

# Archivo desde Drive

from google.colab import drive
drive.mount('/content/drive')

# Archivo desde computadora

from google.colab import files
import io

filesUploaded = files.upload()

### Ejercicios pandas 1: exploración

1. Definir el Dataframe con pd.read_csv. Ver los ulitmos 5 registros del dataset

2. Ver una muestra aleatoria de 6 murales

3. Ver los "Autores" posibles

4. ¿Hay más de un mural con el mismo nombre? 

5. Modificar el nombre de la columna "F_E"

6. Renombrar todas las columnas

7. Eliminar la columna "UBICACION". ¿Cuál es el código para eliminar dos columnas a la vez?


#### Ejericios pandas 2: filtrar y agrupar

1. Hacer un filtro para seleccionar solo los murales realizados en el año 1939 / antes del año 1950

2. Hacer un filtro para seleccionar solo los murales que Luis Seoane. ¿Cuántos murales realizó? 

3. De los murales de Luis Seoane ¿Cuál fue el primero?¿Y el úlitmo?

4. Hacer un filtro para seleccionar los murales que NO son realizados con la Técnica "MURAL CERAMICO" 

5. Hacer una agrupación y crear un DataFrame que tenga cada uno de los autores y el año de su primer mural

6. Hacer una agrupación y crear un DataFrame que tenga cada uno de los autores y el año de su último mural
"""