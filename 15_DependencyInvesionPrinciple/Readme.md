## Problema
El cliente debe poder elegir pagar con cualquier método de pago válido.

Puedes modificar la clase tienda, pero no las ExternalLibraries.

## Solución
Crear una interfaz PaymentMethod con un método pay()
Crea una nueva clase para cada método de pago que implemente la interfaz PaymentMethod.

La tienda debe aceptar cualquier clase con PaymentMethod.