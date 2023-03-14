// así es la sintaxis para crear un vector de 10 números.
// int n;
// int[] numeros = new int[10];

//  0 1 2 3 4 5 6 7 8 9  índices (va de 0 a n-1)
// |9| | | | |1| | | | |  espacios de memoria

// Cargarle valores individuales:
// en el espacio 6 (n - 1 = 5) se le asigna el valor 1.
// numeros[6] = 1;
// numeros[0] = 9;
// // Se pueden combinar:

// n = numeros[6] + numeros[0];

// // y mostrar:
// Console.WriteLine(numeros[6]);
 


// como cargarle los valores en conjunto:
// (PRIMERO) Se cargan con un ciclo for con la misma cantidad de elementos.

// int n, acu = 0;
// int[] numeros = new int[10];

// for (int x = 0; x < 10; x++)
// {
//     Console.WriteLine("Ingrese la nota: ");
//     n = int.Parse(Console.ReadLine());
//     numeros[x] = n;
// }

// // (LUEGO HAGO LAS OPERACIONES) para sumar los elementos:

// for (int x = 0; x < 10; x++)
// {
//     acu += numeros[x];
// }

// int prom = acu / 10;
// Console.WriteLine("El promedio es: " + prom);


// EJEMPLO DE VECTORES DOUBLE (FLOAT) ---------------------

// Registro de temperaturas de 31 días:

// double[] muestraMatutina = new double[31];
// double[] muestraVespertina = new double[31];
// double[] muestraNocturna = new double[31];

// // se hace un ciclo for para cargar los elementos en cada uno:
// // registro matutino
// int dia;
// double temperatura;

// Console.WriteLine("Cargue el registro matutino: ");
// for (int x = 0; x < 31; x++)
// {
//     // pido los valores y asigno a las variables
//     Console.WriteLine("Ingrese día: ");
//     dia = int.Parse(Console.ReadLine());
//     Console.WriteLine("Ingrese temperatura registrada: ");
//     temperatura = double.Parse(Console.ReadLine());
//     // -1 para que coincida con los índices y los cargo en el vector (ésto se puede hacer en este ejemplo porque uno de los datos(días) coincide con los índices, sino hay que hacer 2 vectores)
//     muestraMatutina[dia-1] = temperatura;
// }

// for (int x = 0; x < 31; x++)
// {
//     //muestraVespertina
//     Console.WriteLine("Ingrese día: ");
//     dia = int.Parse(Console.ReadLine());
//     Console.WriteLine("Ingrese temperatura: ");
//     temperatura = double.Parse(Console.ReadLine());

//     muestraVespertina[dia-1] = temperatura;
// }

// for (int x = 0; x < 31; x++)
// {
//     //muestraNocturna
//     Console.WriteLine("Ingrese día: ");
//     dia = int.Parse(Console.ReadLine());
//     Console.WriteLine("Ingrese temperatura: ");
//     temperatura = double.Parse(Console.ReadLine());

//     muestraNocturna[dia-1] = temperatura;
// }


// // OTRO EJEMPLO
// double s;
// int l;

// double[] sueldos = new double[50];
// int[] legajo = new int[50];

// for (int x = 0; x < 50; x++)
// {
//     s = double.Parse(Console.ReadLine());
//     sueldos[x] = s;
//     l = int.Parse(Console.ReadLine());
//     legajo[x] = l;
// }



// EJEMPLO DE CADENAS DE CARACTERES --------------------------
// si la cadena la vamos a utilizar para cargar letras (ejemplo p:presente y a:ausente, se convierte en un vector de char),
// si se usa para cargar y modificar frases o nombres es una cadena de caracteres.

// ESTO ES UN VECTOR DE CHAR.
// se escribe igual que un vector normal
// char[] asistencia = new char[10];

// asistencia[0] = 'P';
// asistencia[1] = 'P';
// asistencia[2] = 'A';

// |P|P|A| | | | | | |


// // CADENAS DE CARACTERES:
// char[] nombre = new char[10];

// char letra;
// // agregamos un índice para conocer las posiciones del vector.
// int indice = 0;

// Console.WriteLine("Ingrese su nombre letra por letra y termina con punto..");
// letra = char.Parse(Console.ReadLine());

// // voy agregando letras y cuando termino ingreso un punto, le agregamos un tope al índice para que coincida con el tamaño del vector.
// while (letra != '.' && indice < 10)
// {
//     // agregamos estas líneas para guardar los valores en el vector
//     nombre[indice] = letra;
//     letra = char.Parse(Console.ReadLine());
//     indice++;
// }

// // colocamos esto fuera del ciclo, para que cuando se ingrese el punto y termine, le coloquemos el BARRA CERO para finalizar la el vector.
// nombre[indice] = '\0';

// // Para mostrar inicializamos nuevamente el índice en cero, y mediante el while mostramos cada letra en cada posición.
// Console.WriteLine("Hola ");
// indice = 0;
// while (nombre[indice] != '\0')
// {
//     Console.Write(nombre[indice]);
//     indice++;
// }
//|r|o|d|r|i|\0| | | | | |

//Terminamos la cadena de caracteres con un BARRA CERO \0
//|H|O|L|A| |Q|U|E| |T|A|L|?|\0| | | |


// TODO LO DE ARRIBA (SOBRE CADENA DE CARACTERES) SE PUEDE REEMPLAZAR POR:

// el string es una tipo de dato AVANZADO de alto nivel.
// string nombre;
// Console.WriteLine("Ingrese su nombre: ");
//// no hago la transformación con el .Parse, porque el Console.Readline() arroja un tipo de dato string.
// nombre = Console.ReadLine();
// Console.WriteLine("Hola " + nombre);






// EJERCICIO 1 ------------------------------------------------------------
// 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
// Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.


// PRIMERO CARGO LOS VALORES AL VECTOR.
// int[] numero = new int[10];

// for (int x = 0; x < 10; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     numero[x] = int.Parse(Console.ReadLine());
// }

// // DESPUÉS HAGO LAS OPERACIONES CON OTRO CICLO.
// int max = numero[0], pos = 1;

// for (int x = 0; x < 10; x++)
// {
//     if (numero[x] >= max){
//         max = numero[x];
//         pos = x+1;
//     }
// }

// Console.WriteLine("El valor máximo es: " + max + " en la posición " + pos);



// EJERCICIO 2 -------------------------------------------
// 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
// Luego recorrer ese vector para calcular el promedio. 
// Mostrar por pantalla los valores que son mayores al promedio.

// int[] numeros = new int[10];

// for (int x = 0; x < 10; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     numeros[x] = int.Parse(Console.ReadLine());
// }

// int con = 0, acu = 0, promedio;

// for (int x = 0; x < 10; x++)
// {
//     con++;
//     acu+=numeros[x];

// }

// promedio = acu / con;
// Console.WriteLine("El promedio es: " + promedio);

// for (int x = 0; x < 10; x++)
// {
//     if (numeros[x] > promedio)
//         Console.WriteLine("Los números mayores al promedio son: " + numeros[x]);
// }



// EJERCICIO 3 -------------------------------------------
// 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
// El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
// Mostrar el resultado en pantalla. Ejemplo:
//  CADENA FUENTE: “La mar estaba serena"
//  CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
//  CADENA RESULTADO: “Li mir estibi sereni"

// char[] frase = new char[30];

// int indice = 0;
// char letraActual;
// char letraNueva;


// char letra;
// Console.WriteLine("Ingrese una letra: ");
// letra = char.Parse(Console.ReadLine());

//// creo un primer ciclo para ir guardando cada letra dentro del vector en ese índice, y luego aumento el índice.
// while (letra != '0' && indice < 30)
// {
//     // guardo la letra dentro del vector frase.
//     frase[indice] = letra;
//     Console.WriteLine("Ingrese otra: ");
//     letra = char.Parse(Console.ReadLine());
//     indice++;
// }
// // por si cargo una frase menor a 30 caracteres para que finalice.
// frase[indice] = '\0';

// Console.WriteLine("La frase completa es: ");
//// para mostrar, creo un nuevo ciclo, inicializo nuevamente el índice, imprime lo que escribimos hasta el momento, y aumento el índice.
// indice = 0;
// while (frase[indice] != '\0')
// {
//     Console.Write(frase[indice]);
//     indice++;
// }

//// pido las letras a modificar y las asigno en cada variable.
// Console.WriteLine("Ingrese letra a reemplazar: ");
// letraActual = char.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la letra nueva: ");
// letraNueva = char.Parse(Console.ReadLine());


//// creo un nuevo ciclo para hacer el reemplazo 
// indice = 0;
// while (frase[indice] != '\0')
// {
//     if(frase[indice] == letraActual)
//         frase[indice] = letraNueva;
//     indice++;
// }


//// creo otro ciclo para mostrar la frase modificada, inicializo el índice y muestro dentro del ciclo.
// Console.WriteLine("La frase nueva es: ");
// indice = 0;
// while (frase[indice] != '\0')
// {
//     Console.Write(frase[indice]);
//     indice++;
// }



// Y ÉSTA ES LA FORMA SENCILLA DE HACERLO =================================

// string frase;
// char letraActual;
// char letraNueva;
// Console.WriteLine("Ingrese la frase: ");
// frase = Console.ReadLine();
// Console.WriteLine("Ingrese la letra a reemplazar: ");
// letraActual = char.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la letra nueva: ");
// letraNueva = char.Parse(Console.ReadLine());

// // frase.replace es una función
// frase = frase.Replace(letraActual, letraNueva);

// Console.WriteLine(frase);




// EJERCICIO 4 ---------------------------------------------
// 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
//  - Número de Artículo (1 a 15)
//  - Cantidad Vendida 
// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
// Se pide determinar e informar:
//  a) El número de artículo que más se vendió en total.
//  b) Los números de artículos que no registraron ventas.
//  c) Cuantas unidades se vendieron del número de artículo 10.


// int codigo, vendido;
// int[] totalCantidadVendida = new int[15];

// for (int x = 0; x < 15; x++)
// {
//     // da las 15 vueltas e inicializa a todos los elementos en cero.
//     totalCantidadVendida[x] = 0;
// }

// Console.WriteLine("Ingrese el Código de artículo: ");
// codigo = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la cantidad vendida: ");
// vendido = int.Parse(Console.ReadLine());

// while (codigo != 0)
// {
//     // mientras el código sea distinto de cero, ingresa y carga la cantidad vendida, al total en la posición -1;
//     totalCantidadVendida[codigo-1] += vendido;

//     Console.WriteLine("Ingrese el codigo de artículo: ");
//     codigo = int.Parse(Console.ReadLine());
//     Console.WriteLine("Ingrese la cantidad vendida: ");
//     vendido = int.Parse(Console.ReadLine());
// }

// // punto a

// // la primer venta cargada en el total, la asigno como máxima provisoria.
// int maxCantidad = totalCantidadVendida[0];
// int numeroMaximo = 1;
// for (int x = 0; x < 15; x++)
// {
//     // si el total ingresado en cada posición es mayor al máximo, asigno un nuevo máximo y aumento el codigo 1 posición.
//     if(totalCantidadVendida[x] > maxCantidad){
//         maxCantidad = totalCantidadVendida[x];
//         codigo = x + 1;
//     }
// }

// Console.WriteLine("El producto mas vendido es el : " + codigo + " con la cantidad de: " + maxCantidad);

// // punto b
// for (int x = 0; x < 15; x++)
// {
//     if (totalCantidadVendida[x] == 0)
//     {
//         Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas.");
//     }
// }


// // punto c

// Console.WriteLine("La cantidad vendida del articulo 10 es: " + totalCantidadVendida[9]);