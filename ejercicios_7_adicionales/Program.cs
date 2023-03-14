// EJERCICIOS DE LA GUÍA ----------------------------------

// 1 --------------------------------------------
// 1. Hacer un programa que solicite 50 números enteros y los guarde en un vector.
// Luego recorrer el vector y determinar e informar cuál es la suma de los valores del mismo.
// Nota: usar dos ciclos: uno para guardar los números en el vector y otro para recorrerlo y leerlo.

// int[] vNum = new int[50];

// for (int x = 0; x < 50; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     vNum[x] = int.Parse(Console.ReadLine());
// }

// int acu = 0;

// for (int x = 0; x < 50; x++)
// {
//     acu+=vNum[x];
// }

// Console.WriteLine("La suma es: " + acu);


// 2 -----------------------------------------------
// 2. Hacer un programa que solicite 50 números enteros y los guarde en un vector.
// Luego recorrer todos los elementos del vector y determinar cuál es el valor
// máximo y su posición dentro del vector.

// int[] vNum = new int[50];

// for (int x = 0; x < 50; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     vNum[x] = int.Parse(Console.ReadLine());
// }

// int max = 0, pos = 1;

// for (int x = 0; x < 50; x++)
// {
//     if(vNum[x] > max){
//         max = vNum[x];
//         pos = x + 1;
//     }
// }

// Console.WriteLine("El valor máximo es: " + max + " y fue ingresado en la posición " + pos);


// 3 --------------------------------------------------
// 3. Hacer un programa que solicite 100 números enteros y los guarde en un vector. 
// Luego recorrer ese vector para calcular el promedio. Mostrar por
// pantalla los valores del vector que son mayores al promedio calculado.

// int[] vNum = new int[100];

// for (int x = 0; x < 100; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     vNum[x] = int.Parse(Console.ReadLine());
// }

// int acu = 0, con = 0, promedio;

// for (int x = 0; x < 100; x++)
// {
//     con++;
//     acu+=vNum[x];
// }

// promedio = acu / con;
// Console.WriteLine("El promedio es: " + promedio);

// for (int x = 0; x < 100; x++)
// {
//     if(vNum[x] > promedio)
//         Console.WriteLine(vNum[x] + " es mayor al promedio.");
// }


// 4 ---------------------------------------------------------
// 4. Dada una lista de 10 números enteros, cargarlos en un vector. Luego,
// determinar e informar si el vector está ordenado en forma creciente

// int[] vNum = new int[10];

// for (int x = 0; x < 10; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     vNum[x] = int.Parse(Console.ReadLine());
// }

// int min = vNum[0], ban = 1;

// for (int x = 0; x < 10; x++)
// {
//    if (vNum[x] >= min)
//         min = vNum[x];         
//    else
//         ban = 0;
// }

// if (ban == 1)
//     Console.WriteLine("Está ordenado.");
// else
//     Console.WriteLine("No está ordenado.");



// 6 -----------------------------------------------
// 6. Dada una lista de 10 números, cargarlos en un vector. Luego detectar si en el
// vector hay algún elemento repetido. De haberlo, indicarlo con un cartel
// aclaratorio “Hay repetidos”, de lo contrario indicar “No hay repetidos”.
// Pista: usar ciclos combinados.

int[] numeros = new int[10];
int repetidos = 0;

for (int x = 0; x < 10; x++)
{
    Console.WriteLine("Ingrese un número: ");
    numeros[x] = int.Parse(Console.ReadLine());   
}


for (int x = 0; x < 10; x++)
{

}



if (repetidos != 0)
    Console.WriteLine("Hay repetidos: ");   
else
    Console.WriteLine("No hay repetidos: ");

