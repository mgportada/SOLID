# O - Principio de abierto/cerrado (Open/Closed Principle): 
Las entidades de software (clases, m�dulos, funciones, etc.) deben estar abiertas para la extensi�n pero cerradas para la modificaci�n. 
Esto significa que el comportamiento de una clase debe poder extenderse sin modificar su c�digo fuente.

## Problema
AreaCalculator calcula el �rea total de todas las figuras geom�tricas que recibe.

Si se quisiera agregar una nueva figura geom�trica, se tendr�a que modificar la clase AreaCalculator.
Pero no hace nada nuevo, solo calcula el �rea total de las figuras que recibe.
Area Calculator puede aceptar nuevas figuras geom�tricas sin necesidad de modificar su c�digo fuente.
El area de una figura geom�trica es una responsabilidad distinta a la de calcular el �rea total de todas las figuras geom�tricas que recibe.

## Soluci�n
Crear una interfaz Shape con un m�todo getArea() que devuelva el �rea de la figura geom�trica.