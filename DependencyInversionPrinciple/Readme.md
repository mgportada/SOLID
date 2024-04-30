# D - Principio de inversión de dependencia (Dependency Inversion Principle): 
Los módulos de alto nivel no deberían depender de los módulos de bajo nivel. 
Ambos deberían depender de abstracciones. Además, las abstracciones no deberían depender de los detalles; los detalles deberían depender de las abstracciones.


## Problema
OrderService realiza la orden de un producto.
El hisotrial de la orden se guarda en un servicio de almacenamiento "DataDogService".
Si se quisiera cambiar el servicio de almacenamiento, porque otro es más barato o porque se quiere guardar en otro lugar, se tendría que modificar la clase OrderService.

OrderService no debería depender del servicio de almacenamiento, sino de una abstracción que permita cambiar el servicio de almacenamiento sin modificar el código de OrderService.

## Solución
Crear una interfaz StorageService con los métodos necesarios para guardar la orden.
Guarda ahora los logs en GrafanaService.

