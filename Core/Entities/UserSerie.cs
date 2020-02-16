using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class UserSerie
    {
        public int Id { get; set; }
        public int Episode { get; set; }
        public int Score { get; set; }
        public int SerieId { get; set; }
        public Serie Serie { get; set; }
        public User User { get; set; }

    }
}
