# I - Principio de segregaci�n de interfaces (Interface Segregation Principle): 
Los clientes no deber�an ser forzados a depender de interfaces que no utilizan. 
En lugar de tener interfaces monol�ticas, es mejor tener interfaces m�s espec�ficas y m�s peque�as.

## Problema
Se tiene una interfaz IFoodOrderService que sirve diferentes tipos de comida.
Sin embargo, no todos los servicios de comida sirven todos los tipos de comida.
Cada servicio de comida deber�a implementar solo los m�todos que necesita.

## Soluci�n
Crea interfaces m�s espec�ficas para cada tipo de comida.