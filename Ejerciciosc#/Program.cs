// See https://aka.ms/new-console-template for more informati



//Ejercicio 8: Desafío de Clases y Métodos
//Crea una clase Tienda que administre un inventario de productos. Define:

//Una clase Producto con:

//Nombre(string)
//Precio(double)
//Cantidad(int)
//Una clase Tienda con:

//Una lista de productos.
//Métodos:
//AgregarProducto(Producto producto)
//MostrarInventario() → Muestra los productos con su cantidad y precio.
//VenderProducto(string nombre, int cantidad) → Reduce la cantidad del producto especificado (verifica que haya suficiente stock).
//CalcularTotalInventario() → Devuelve el valor total de todos los productos.
//En el método Main:

//Crea una tienda.
//Agrega productos.
//Realiza ventas.
//Muestra el inventario y el valor total después de cada operación.


class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }

    public Producto(string nombre, double precio, int cantidad) //Constructor
    {
        this.Nombre = nombre;
        this.Precio = precio;
        this.Cantidad = cantidad;
    }
}


class Tienda
{
    private List<Producto> productos;

    public Tienda()
    {
        productos = new List<Producto>();
    }

    public void AgregarProducto(string nombre, double precio, int cantidad)
    {
        Producto nuevoProducto = new Producto(nombre, precio, cantidad);

        productos.Add(nuevoProducto);
    }


    public void MostrarProducto()
    {
        foreach (var producto in productos)
        {
            Console.WriteLine($"Nombre: {producto.Nombre}, Precio: {producto.Precio}, Cantidad: {producto.Cantidad}");
        }
    }


    public void VenderProducto(string nombre, int cantidad)
    {
        foreach (var producto in productos)
        {

            if (nombre == producto.Nombre && cantidad <= producto.Cantidad)
            {

                producto.Cantidad -= cantidad;
                Console.WriteLine($"has comprado exitosamente {cantidad} {producto.Nombre} ");
                Console.WriteLine($"stock disponible de ese producto {producto.Cantidad}");
                break;

            }
            else if (nombre == producto.Nombre && cantidad < producto.Cantidad)
            {
                Console.WriteLine($"CANTIDAD no disponible de : {producto.Cantidad}");
                break;
            }
        }
    }


    public double ValorTotal()
    {
        double totalTienda = 0;

        double precioProductoActual;

        int cantidadProductoActual;

        foreach (var producto in productos)
        {
            precioProductoActual = producto.Precio;

            cantidadProductoActual = producto.Cantidad;

            totalTienda = precioProductoActual * cantidadProductoActual;

            break;
        }

        Console.WriteLine(totalTienda);

        return totalTienda;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tienda tiendaNueva = new Tienda();

            tiendaNueva.AgregarProducto("Taladro", 5, 200);
            tiendaNueva.AgregarProducto("Taladro", 5, 200);

            tiendaNueva.ValorTotal();
        }
    }
}