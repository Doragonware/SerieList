using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class SerieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Episodes { get; set; }
        public DateTime Aired { get; set; }
    }
}
