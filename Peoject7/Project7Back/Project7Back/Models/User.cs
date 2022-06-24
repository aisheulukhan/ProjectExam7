using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project7Back.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Founder { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
