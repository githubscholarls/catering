using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    public class option
    {
        [Key]
        public int Id { get; set; }

        public int categoryId { get; set; }
        public category category { get; set; }
        [Column(TypeName =("nvarchar(450)"))]
        public string name { get; set; }
    }
}
