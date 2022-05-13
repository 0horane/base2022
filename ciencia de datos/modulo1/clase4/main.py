import pandas as pd

#from google.colab import drive
#from google.colab import files
#drive.mount ("/content/drive")
#import io
#filesUploaded = files.upload()
#data = pd.read_csv(io.BytesIO(filesUploaded["encuentro-educacion-ambiental.csv"]), sep=";") 


data =  pd.read_csv("Encuentros educación ambiental.csv", sep=";")

data.head(2)

### Ejercicios
# 1. ¿Cuántas columnas tiene el Dataframe?
#
print(data.shape[1])
# 2. Seleccionar únicamente la columna "encuentro_tematica?
# 
print(data["encuentro_tematica"])
# 3. Ver los últimos 5 registros
# 
data.tail()
data.tail(5)
data[-5:]
# 4. ¿Cuántos participantes totales hubo?
# 
data["encuentro_participantes"].sum()
# 5. ¿Cuáles son los posibles destinatarios?

data["Encuentro_destinatarios"].unique()


