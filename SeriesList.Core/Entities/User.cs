using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesList.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public ICollection<UserSerie> UserSeries { get; set; }

    }
}
