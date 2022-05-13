"""
Ejercicios

1-    ¿Cuáles son los posibles destinatarios?

2-     Mostrar la información de los encuentros del año 2019. Crear una máscara y luego acceder con .loc

3-    Crea un Dafreame con los destinatarios de los encuentros del año 2019.

4-    ¿Cuántos encuentros hubo en el año 2018?

5-    ¿Cuántos encuentros hubo para "Almunos de nivel secundario"? Realizaro con sum() y luego crea un Dataframe con la información de este/esos encuentro/s

6-    ¿Cuántos participantes promedio hubo por año? usar groupby

7-    ¿Cuántos participantes de cada destinatario hubo? usar groupby

8-    ¿Cuántos participantes hubo por año por destinatario por año? para hacer agrupaciones sobre 2 columnas se deben colocar entre corchetes dentro del parentesis (["columa1", "columna2"])
"""
import pandas as pd
data = pd.read_csv("Encuentros educación ambiental.csv", sep=";")
#1
data["Encuentro_destinatarios"].unique()
#2
mask_2018 = data["encuentro_anio"]==2018
data.loc[mask_2018]
#3



















