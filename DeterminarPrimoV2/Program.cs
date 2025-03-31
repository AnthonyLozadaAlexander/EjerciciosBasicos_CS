int countDivisores;
bool esPrimo;
for (int i = 1; i <= 100; i++) // dividendos
{
    countDivisores = 0; // reset por cada iteracion de los dividendos
    for (int d = 1; d <= i; d++)
    {
        if (i % d == 0) // si los dividendos del 1 al 100 % d tienen un residuo igual a 0 entonces countDivisores se ira acumulando en 1
        {
            countDivisores++;
        }

    }
    if (countDivisores == 2) // si countDivisores llega a 2 entonces es primo, si no, no
    {
        esPrimo = true;
        Console.WriteLine($"El numero {i} es Primo? = {esPrimo}");
    }
    else
    {
        esPrimo = false;
        Console.WriteLine($"El numero {i} es Primo? = {esPrimo}");
    }
}
