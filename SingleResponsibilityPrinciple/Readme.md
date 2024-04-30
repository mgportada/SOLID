# S - Principio de responsabilidad única (Single Responsibility Principle): 
Una clase debería tener una única razón para cambiar. 
En otras palabras, una clase debe tener una sola responsabilidad y no debe tener más de una razón para ser modificada.

## Problema
UserService hace la acción de agregar un usuario.
Si fuera necesario cambiar la encriptación de la contraseña, se tendría que modificar la clase UserService.
Aunque la encriptación de la contraseña es una responsabilidad distinta a la de agregar un usuario...

## Solución
Crear una clase que se encargue de la encriptación de la contraseña.