# D - Principio de inversi�n de dependencia (Dependency Inversion Principle): 
Los m�dulos de alto nivel no deber�an depender de los m�dulos de bajo nivel. 
Ambos deber�an depender de abstracciones. Adem�s, las abstracciones no deber�an depender de los detalles; los detalles deber�an depender de las abstracciones.


## Problema
OrderService realiza la orden de un producto.
El hisotrial de la orden se guarda en un servicio de almacenamiento "DataDogService".
Si se quisiera cambiar el servicio de almacenamiento, porque otro es m�s barato o porque se quiere guardar en otro lugar, se tendr�a que modificar la clase OrderService.

OrderService no deber�a depender del servicio de almacenamiento, sino de una abstracci�n que permita cambiar el servicio de almacenamiento sin modificar el c�digo de OrderService.

## Soluci�n
Crear una interfaz StorageService con los m�todos necesarios para guardar la orden.
Guarda ahora los logs en GrafanaService.

