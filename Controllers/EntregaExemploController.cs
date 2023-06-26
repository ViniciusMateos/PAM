using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FUSCA_API.Models;

namespace FUSCA_API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EntregaExemploController : ControllerBase
    {
        private static List<Entrega> entregas = new List<Entrega>()
        {
            new Entrega() { Id = 1, Local_Entrega = "Rua São João", Tipo_Entrega = "Sedex", Hr_Entrega = "10:10", Dt_Entrega = "01/05/1760"},
            new Entrega() { Id = 2, Local_Entrega = "Rua Santo Antônio", Tipo_Entrega = "ONG", Hr_Entrega = "11:11", Dt_Entrega = "02/05/1760"},
            new Entrega() { Id = 3, Local_Entrega = "Rua Santa Maria", Tipo_Entrega = "Sedex", Hr_Entrega = "22:22", Dt_Entrega = "03/05/1760"},
            new Entrega() { Id = 4, Local_Entrega = "Rua Josino", Tipo_Entrega = "ONG", Hr_Entrega = "09:09", Dt_Entrega = "04/05/1760"},
            new Entrega() { Id = 5, Local_Entrega = "Rua do Vieira", Tipo_Entrega = "Retirada", Hr_Entrega = "08:08", Dt_Entrega = "05/05/1760"},
        };
    }
}