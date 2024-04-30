# I - Principio de segregación de interfaces (Interface Segregation Principle): 
Los clientes no deberían ser forzados a depender de interfaces que no utilizan. 
En lugar de tener interfaces monolíticas, es mejor tener interfaces más específicas y más pequeñas.

## Problema
Se tiene una interfaz IFoodOrderService que sirve diferentes tipos de comida.
Sin embargo, no todos los servicios de comida sirven todos los tipos de comida.
Cada servicio de comida debería implementar solo los métodos que necesita.

## Solución
Crea interfaces más específicas para cada tipo de comida.