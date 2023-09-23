using Microsoft.AspNetCore.Mvc;

namespace tp1;

[ApiController]
[Route("[controller]")]

public class CadeteriaController : ControllerBase{
    private Cadeteria cadeteria;

    private readonly ILogger<CadeteriaController>_logger;

    public CadeteriaController(ILogger<CadeteriaController> logger){
        _logger = logger;
        cadeteria = Cadeteria.GetCadeteria();
    }

    [HttpGet]
    public ActionResult<string> GetNombreCadeteria()
    {
        return Ok(cadeteria.Nombre);
    }

    [HttpGet]
    [Route("Pedidos")]

    public ActionResult<IEnumerable<Pedido>> GetPedidos()
    {
        var pedidos = cadeteria;
        return Ok(pedidos);
    }

    [HttpPost("AddPedido")] //agrega datos
    public ActionResult<Pedido> AddPedido(Pedido pedido)
    {
        var nuevoPedido = cadeteria.AddPedido(pedido);
        return Ok(nuevoPedido);
    }

    [HttpPut("UpdatePedido")] //modifica datos
    public ActionResult<Pedido> UpdatePedido(Pedido pedido)
    {
        var updPed = cadeteria.UpdPedido(pedido);
        return Ok(updPed);
    }
   
}

