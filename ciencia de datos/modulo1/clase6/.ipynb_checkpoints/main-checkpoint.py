import matplotlib.pyplot as plt
import pandas as pd

x = pd.array(range(0,100))
y = x**2

fig,ax=plt.subplots()
ax.plot(x,y)
