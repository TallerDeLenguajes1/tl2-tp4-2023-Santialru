
namespace tp1;
public class Pedido
{
    private Cliente infoCliente;
    private int nro;
    private string obs;
    private string estado;
    private Cadete elCadete;


    internal Cliente InfoCliente { get => infoCliente; set => infoCliente = value; }
    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public string Estado { get => estado; set => estado = value; }
    public Cadete ElCadete { get => elCadete; set => elCadete = value; }

    public Pedido(int nro)
    {
        this.nro = nro;
        this.obs = null;
        this.infoCliente = CrearClienteAleatorio(); // Crear cliente aleatorio
        Estado = "EnPreparacion";
    }
    

    private Cliente CrearClienteAleatorio()
        {
            Random random = new Random();
            string nombre = "Cliente" + random.Next(1, 100);
            string direccion = "Dirección" + random.Next(1, 100);
            int telefono = random.Next(100000000, 999999999);
            string datosReferenciaDireccion = "Referencia" + random.Next(1, 100);

            return new Cliente(nombre, direccion, telefono, datosReferenciaDireccion);
        }
        public void VerDireccionCliente()
        {
            Console.WriteLine("La direccion del cliente "+ infoCliente.Nombre + "es: "+ infoCliente.Direccion);
        }

        public void VerDatosCliente()
        {
            Console.WriteLine("----Info del Cliente---");
            Console.WriteLine("Nombre: "+ infoCliente.Nombre);
            Console.WriteLine("Telefono: "+ infoCliente.Telefono);
            Console.WriteLine("Direccion: "+ infoCliente.Direccion);
        }
}