using EspacioCalculadora;

string opcion;
double termino = 0.0;
string numeroIngresado;

Calculadora calculadora = new Calculadora();

void mostrarMenu()
{
    Console.WriteLine("_________________");
    Console.WriteLine("1_ SUMAR");
    Console.WriteLine("2_ RESTAR");
    Console.WriteLine("3_ MULTIPLICAR");
    Console.WriteLine("4_ DIVIDIR");
    Console.WriteLine("5_ LIMPIAR");
    Console.WriteLine("0_ SALIR");
    Console.WriteLine("_________________");
}
string solicitarOpcion()
{
    Console.Write("Ingrese una opción: ");
    string opcion = Console.ReadLine();
    return opcion;
}
string solicitarNumero()
{
    Console.Write("Ingrese un número: ");
    string numeroIngresado = Console.ReadLine();
    return numeroIngresado;
}
void mostrarResultado()
{
    Console.WriteLine("---------------\nRESULTADO: " + calculadora.resultado + "\n---------------");
}

do
{
    mostrarMenu();
    opcion = solicitarOpcion();

    if (opcion == "0")
    {
        Console.WriteLine("FIN DEL PROGRAMA");
    }
    else if (opcion == "5")
    {
        calculadora.Limpiar();
        mostrarResultado();
    }
    else
    {
        numeroIngresado = solicitarNumero();
        if (double.TryParse(numeroIngresado, out termino))
        {
            switch (opcion)
            {
                case "1":
                    calculadora.Sumar(termino);
                    mostrarResultado();
                    break;
                case "2":
                    calculadora.Restar(termino);
                    mostrarResultado();
                    break;
                case "3":
                    calculadora.Multiplicar(termino);
                    mostrarResultado();
                    break;
                case "4":
                    calculadora.Dividir(termino);
                    mostrarResultado();
                    break;
                default:
                    Console.WriteLine("La opción no es válida");
                    break;
            }
        }
    }
} while (opcion != "0");