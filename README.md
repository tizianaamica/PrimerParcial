# PrimerParcial
Segundo Ejercicio del Primer Parcial de Programación II

El capitán de un barco desea cargar de mercancía la embarcación, con el propósito de maximizar sus ganancias cuando se venda en las tiendas de destino. La bodega para cargar la mercancía del barco tiene solo ‘S’ metros cúbicos.
Se suministra una lista de productos que se pueden almacenar en la bodega, cada producto tiene su volumen(expresados en metros cúbicos) y un valor de ganancia.

Entrada (bodega.in)
La primera línea contiene 2 enteros: S y N, donde S es la capacidad de la bodega y N es el número de productos.
Las N líneas siguientes contiene la información acerca de cada productos enumerados de 1 a N; cada línea contiene 2 enteros (a y b). Donde a es el volumen del producto y b es el valor de ganancia.
Su tarea es acomodar la mercancía para maximizar la ganancia del capitán.

Salida (Por pantalla)
La salida debe tener N+1 líneas. La primera línea será un entero con el monto máximo de la ganancia alcanzable. Cada línea siguiente contiene un entero (por producto), el monto de ese producto a colocar en el barco. (ejm. Línea k hace referencia al producto k-1).
Si existen varias soluciones de obtener la mayor ganancia, solo debe colocar una.

Ejemplo:
Capacidad de la Bodega 10, 3 productos
producto 1: tamaño 5, ganancia 3
producto 2: tamaño 7, ganancia 5
producto 3: tamaño 6, ganancia 5

El archivo de entrada será algo como esto:
10 3
5 3
7 5
6 5

Máxima ganancia = 6
Almacena dos del tipo "Producto 1" 

La salida será algo como esto:
6
2
0
0

Ejemplo 2:

Entrada:
23 4
10 5
11 6
3 1
6 2

Salida:
12
0
2
0
0
