namespace EspacioCalculadora{

public class Calculadora
{
    public double dato = 0.0;

    public void Sumar(double termino)
    {
        dato = dato + termino;
    }
    public void Restar(double termino)
    {
        dato = dato - termino;
    }
    public void Multiplicar(double termino)
    {
        dato = dato * termino;
    }
    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            dato = dato / termino;
        } else {
            Console.WriteLine("No es posible dividir en cero");
        }
    }
    public void Limpiar()
    {
        dato = 0.0;
    }

    public double resultado{
        get{
            return dato;
        }
    }
}

}