// See https://aka.ms/new-console-template for more informati



class NumeroMayor
{
    public int tamaño;
    public int[] arrayNumeros;

    public NumeroMayor(int tamaño)
    {
        this.tamaño = tamaño;
        arrayNumeros = new int[tamaño];
    }

    //Metodo para llenar el array con numeros 

    public void AgregarNumeros ()
    {
        for(int i = 0; i < tamaño; i ++) // El bucle se ejecuta *tamaño* veces
        {
            Console.Write($"Ingrese número {i + 1}: "); // En cada iteracion del bucle se muestra en consola el numero de la vuelta para ir pidiendo los datos ordenados

            arrayNumeros[i] = Convert.ToInt32(Console.ReadLine()); // el numero en la posicion i == lo que se ingrese en la consola convertido con *convert.Toint*
        }

    }


    //Metodo para mostrar todos los numeros ingresados

    public void MostrarArray ()
    {
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            Console.WriteLine(arrayNumeros[i]); //En cada iteracion del bucle se van a mostrar los datos ingresados.
        }
    }



    //Metodo para encontrar el maximo numero

    public int EncontrarNumeroMayor ()
    {
        int elementoMaximo = arrayNumeros[0]; // el numero 0 hace referencia a la posicion del primer elemento , se asume que el primer elemento es el mayor.

        for(int i = 1; i < tamaño - 1; i ++)
        {
            if (arrayNumeros[i] > elementoMaximo)
            {
                elementoMaximo = arrayNumeros[i];
            }

            return elementoMaximo;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int tamaño = 10; // Definir el tamaño del arreglo
            NumeroMayor numeroMayor = new NumeroMayor(tamaño); // Crear instancia

            numeroMayor.AgregarNumeros(); // Llenar el arreglo
            numeroMayor.MostrarArray(); // Imprimir el arreglo

            //Mostrar el numero mas grande
            int mayor = numeroMayor.EncontrarNumeroMayor();
            Console.WriteLine($"El número más grande es: {mayor}");
        }
    }
}
