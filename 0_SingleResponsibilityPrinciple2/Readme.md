## Problema

Se tiene un servicio de reporte que genera reportes en diferentes formatos.
El servicio de reporte tiene un método para generar reportes en formato PDF y otro para generar reportes en formato Excel.
Si se quisiera agregar un nuevo formato de reporte, se tendría que modificar la clase ReportService.
Pero no hace nada nuevo, solo genera reportes en diferentes formatos.

El servicio de reporte debería generar nuevos formatos sin necesidad de modificar su código fuente.

## Solución

Crear una interfaz Report con un método generate() que devuelva el reporte en el formato deseado.