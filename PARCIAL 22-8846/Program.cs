try
// 1. El programa debe solicitar al usuario que ingrese un número entero positivo N mayor que cero.
{
    Console.Write("Ingrese un número entero positivo mayor que cero: ");
    int n = int.Parse(Console.ReadLine());

    // 2. Utilizando una estructura de control adecuada
    // el programa debe calcular el cuadrado de todos los números enteros positivos menores
    // o iguales que N y almacenar cada resultado en un arreglo.
    int[] cuadrado = new int[n];
    for (int i = 1; i <= n; i++)
    {
        cuadrado[i - 1] = i * i;
    }

    // 3. Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla
    // todos los números enteros positivos menores o iguales que N que sean primos.

    Console.Write("\n\nNúmeros primos menores o iguales que N:\n");
    for (int i = 2; i <= n; i++)
    {
        bool primo = true;
        for (int m = 2; m < i; m++)
        {
            if (i % m == 0)
            {
                primo = false;
                break;
            }
        }
        if (primo)
        {
            Console.Write(i + "\n");
        }
    }

    // 4.  Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla
    // todos los números enteros positivos menores o iguales que N que sean múltiplos de 4.
    Console.Write("\n\nMúltiplos de 4 menores o iguales que N: \n");
    for (int i = 4; i <= n; i += 4)
    {
        Console.Write(i + " \n");
    }

    // 5. Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla la secuencia de números
    // enteros positivos que comienzan en 1 y se incrementan en 3 hasta que se alcance un valor mayor que N.
    Console.Write("\n\nSecuencia de números que se incrementan en 3:\n");

    int x = 1;
    while (x <= n)
    {
        Console.Write(x + "\n");
        x += 3;
    }

    Console.Write(x);


    // 6. El programa debe imprimir en la pantalla todos los valores del arreglo que contiene
    // los cuadrados de los números enteros menores o iguales que N.
    Console.Write("\n\nCuadrados de los números menores o iguales que N:\n");
    for (int i = 0; i < n; i++)
    {
        Console.Write(cuadrado[i] + "\n");
    }

    Console.ReadKey();

}
catch (Exception e)
{
    Console.WriteLine("era un numero positivo.");
    Console.WriteLine(e.Message);
}

