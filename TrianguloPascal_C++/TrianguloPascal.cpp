#include <iostream>
#include <cstdio>
#include <iostream>
#include <ctime>
#include <chrono>

using namespace std;

// elemento (i,j) del triangulo (i sobre j)

int pascal_aux(int i, int j)
{
    int result;

    if ((j == 0) || (i == j)) // bordes del triangulo
    {
        result = 1;
    }
    else
    {
        result = pascal_aux(i - 1, j - 1) + pascal_aux(i - 1, j);
    }

    return result;
}

int pascal(int i, int j)
{
    int result;

    if (i >= j && j >= 0)
    {
        result = pascal_aux(i, j);
    }
    else
    {
        cerr << "pascal: parametros erroneos" << endl;
    }

    return result;
}

int main()
{
    int nFilas;
    printf("Ingrsa N° de Filas: ");
    scanf("%d", &nFilas);

    auto start = std::chrono::steady_clock::now();

    for (int f = 0; f < nFilas; f++)
    {
        int contador = f - 18;
        for (int i = contador; i < nFilas / 2; i++)
        {
            printf("  ");
            contador++;
        }
        for (int c = 0; c <= f; c++)
        {
            printf("%d    ", pascal(f, c));
        }
        puts("");
    }

    auto finish = std::chrono::steady_clock::now();
    double elapsed = std::chrono::duration_cast<std::chrono::duration<double> >(finish - start).count() * 1000;
    printf("Tiempo de ejecucion: %f milisegundos\n", elapsed);
    return 0;
}