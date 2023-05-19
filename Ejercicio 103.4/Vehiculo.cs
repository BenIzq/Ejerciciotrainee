public class vehiculo
{
    private int Ruedas;
    private int Puertas;

    public vehiculo()
    {
        Ruedas = 0;
        Puertas = 0;
    }

    public vehiculo(int ruedas, int puertas)
    {
        Ruedas = ruedas;
        Puertas = puertas;
    }

    public vehiculo(int ruedas)
    {
        Ruedas = ruedas;
        Puertas = 4;
    }

    public int GetRuedas()
    {
        return Ruedas;
    }

    public int GetPuertas()
    {
        return Puertas;
    }
}