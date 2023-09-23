namespace tp1;
public class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private int telefono;
    // private List<Pedido> listaPedidos;

    public Cadete(int id, string nombre, string direccion, int telefono)
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    // public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    // public void AgregarPedido(Pedido nuevoPedido)
    // {
    //     nuevoPedido.Estado = "EnCamino";
    //     ListaPedidos.Add(nuevoPedido);
    //     Console.WriteLine("El cadete ha recibido el pedido y esta " + nuevoPedido.Estado + ".");
    // }
    // public double JornalACobrar()
    // {
    //     int cantPedidosEntregados = 0;
    //         const int precioPorEnvio = 500;
    //         foreach (Pedido pedido in ListaPedidos)
    //         {
    //             if (pedido.Estado == "Entregado")
    //             {
    //                 cantPedidosEntregados++;
    //             }
    //         }
    //         return cantPedidosEntregados*precioPorEnvio;
    // }
}