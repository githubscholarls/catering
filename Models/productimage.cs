using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    public class productimage
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public int? productId { get; set; }
        public product product { get; set; }
        
        [Column(TypeName = ("nvarchar(32)"))]
        public string imageSource { get; set; }
    }
}
