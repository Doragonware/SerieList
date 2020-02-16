using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesList.Core.Entities
{
    public class Serie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Episodes { get; set; }
        public DateTime Aired { get; set; }

    }
}
