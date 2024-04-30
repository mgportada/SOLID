## Problema

Tienes una tienda que vende productos locales en españa.
Hay dos tipos de ventas "Sales":
	* **Locales**: Se debe pagar IVA
	* **Internacionales**: No se debe pagar IVA en españa.

Sin embargo, la clase abstracta `Sales` tiene un método `calculateTax` que calcula el IVA.
Este método no debería estar en la clase abstracta `Sales` ya que no todos los tipos de ventas tienen IVA.



## Solución
Modificar la clase abstracta `Sales` para que no tenga el método `calculateTax`.
Crear una interfaz `Taxable` con el método `calculateTax` y hacer que las clases `LocalSales`  implemente la interfaz `Taxable`.