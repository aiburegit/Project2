using GameDataService.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataService.Models
{
    public class Genre : BaseEnty
    {
       public int id { get; set; }
       public string Name { get; set; }
       public List<Game> Games { get; set; } = new();
       
    }
}
