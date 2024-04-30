# S - Principio de responsabilidad �nica (Single Responsibility Principle): 
Una clase deber�a tener una �nica raz�n para cambiar. 
En otras palabras, una clase debe tener una sola responsabilidad y no debe tener m�s de una raz�n para ser modificada.

## Problema
UserService hace la acci�n de agregar un usuario.
Si fuera necesario cambiar la encriptaci�n de la contrase�a, se tendr�a que modificar la clase UserService.
Aunque la encriptaci�n de la contrase�a es una responsabilidad distinta a la de agregar un usuario...

## Soluci�n
Crear una clase que se encargue de la encriptaci�n de la contrase�a.