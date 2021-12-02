using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        public String name { get; set; }

        public String imgURL { get; set; }

        public String country { get; set; }

        public String description { get; set; }
    }

}
