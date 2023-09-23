namespace tp1;
public class Cliente
{
    private string nombre;
    private string direccion;
    private int telefono;
    private string refe;

    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Refe { get; set; }


    public Cliente (string _nombre, string _direccion, int _telefono, string _refe)
    {
        nombre = _nombre;
        telefono = _telefono;
        direccion = _direccion;
        refe = _refe;
    }

    public void DatosCliente()
    {
        Console.WriteLine("Ingrese nombre del cliente:");
        Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese dirección del cliente:");
        Direccion = Console.ReadLine();
        Console.WriteLine("Ingrese teléfono del cliente:");
        Telefono = Console.ReadLine();
        Console.WriteLine("Ingrese referencia del cliente:");
        Refe = Console.ReadLine();
    }

    public void getDireccion()
    {
        Console.WriteLine(direccion);
    }
    
    public void ListarDatos()
    {
        Console.WriteLine(nombre);
        Console.WriteLine(telefono);
        Console.WriteLine(direccion);
        Console.WriteLine(refe);
    }
}