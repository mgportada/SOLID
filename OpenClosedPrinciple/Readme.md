# O - Principio de abierto/cerrado (Open/Closed Principle): 
Las entidades de software (clases, módulos, funciones, etc.) deben estar abiertas para la extensión pero cerradas para la modificación. 
Esto significa que el comportamiento de una clase debe poder extenderse sin modificar su código fuente.

## Problema
AreaCalculator calcula el área total de todas las figuras geométricas que recibe.

Si se quisiera agregar una nueva figura geométrica, se tendría que modificar la clase AreaCalculator.
Pero no hace nada nuevo, solo calcula el área total de las figuras que recibe.
Area Calculator puede aceptar nuevas figuras geométricas sin necesidad de modificar su código fuente.
El area de una figura geométrica es una responsabilidad distinta a la de calcular el área total de todas las figuras geométricas que recibe.

## Solución
Crear una interfaz Shape con un método getArea() que devuelva el área de la figura geométrica.