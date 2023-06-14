using System;
using System.Collections.Generic;
using System.Text;

namespace SIRH_DataBase.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; } = DateTime.UtcNow.AddDays(7);
        public bool IsExpired => DateTime.Now >= Expires;
        public DateTime? Revoked { get; set; }
        public bool IsActvie => Revoked == null && !IsExpired;
    }
}
