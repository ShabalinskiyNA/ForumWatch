using MagicTable.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicTable.Services
{
    public class TableService 
    {
        public TableService() { }

        public string Get(string dataKind)
        {
            string json = File.ReadAllText($"AppData/{dataKind}.json");          
            
            return json;
        }

    }

    
}
