using MagicTable.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        public TableController() { }


        [Route("{data}")]
        public string Get(string data)
        {
            var content = new TableService().Get(data);
            
            return content;
        }

        
    }
}
