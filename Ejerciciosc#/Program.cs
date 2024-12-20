// See https://aka.ms/new-console-template for more informati

//Métodos:
//: Clase Calculadora
//Crea una clase llamada Calculadora con:
//Sumar(double a, double b) → Devuelve la suma de a y b.
//Restar(double a, double b) → Devuelve la resta de a y b.
//Multiplicar(double a, double b) → Devuelve el producto de a y b.
//Dividir(double a, double b) → Devuelve la división de a entre b (verifica que no se divida entre 0).
//En el método Main:


//El Get y Set es para probar su funcionalidad.

class Calculadora
{
    private double primerValor;
    private double segundoValor;

    public double PrimerValor
    {
        get { return primerValor; }
        set { primerValor = value; }
    }


    public double SegundoValor
    {
        get { return segundoValor; }
        set { segundoValor = value; }
    }

    public Calculadora() : this(10, .3) { } // Constructor


    public Calculadora(double primerValor, double segundoValor)
    {
        PrimerValor = primerValor;
        SegundoValor = segundoValor;
    }

    ///Metodos
    public double Suma()
    {
        return primerValor + segundoValor;
    }


    public double Resta()
    {
        return primerValor - segundoValor;
    }


    public double Producto()
    {
        return primerValor * segundoValor;
    }


    public double Division()
    {
        if (segundoValor != 0)
        {
            return primerValor / segundoValor;

        }
        else
        {
            throw new DivideByZeroException("El divisor no puede ser cero.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora myCalculadora = new Calculadora();

            Console.WriteLine(myCalculadora.Suma());
            Console.WriteLine(myCalculadora.Resta());
            Console.WriteLine(myCalculadora.Producto());
            Console.WriteLine(myCalculadora.Division());
        }
    }
}