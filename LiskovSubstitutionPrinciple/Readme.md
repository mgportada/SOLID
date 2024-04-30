# L - Principio de sustitución de Liskov (Liskov Substitution Principle): 
Las clases derivadas deben ser substituibles por sus clases base sin afectar el comportamiento del programa. 
Esto garantiza que los objetos de las clases derivadas se puedan usar en lugar de los objetos de las clases base sin necesidad de conocer la diferencia.


## Problema
Se tiene la interfaz pajaro con las acciones que puede realizar un pájaro.
hacer sonido, volar, andar, nadar

Sin embargo, un pingüino no puede volar, pero si puede nadar.
Por tanto no se puede sustituir un pingüino en lugar de un pájaro.

## Solución
Crear una interfaz para volar, andar y nadar.