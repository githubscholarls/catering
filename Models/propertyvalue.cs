using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    /// <summary>
    /// 商品属性值
    /// </summary>
    public class propertyvalue
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品Id
        /// </summary>
        public int? productId { get; set; }
        public product product { get; set; }
        /// <summary>
        /// 商品属性Id
        /// </summary>
        public int? propertyId { get; set; }
        public productProperty property { get; set; }
        /// <summary>
        /// 值
        /// </summary>
         [Column(TypeName =("nvarchar(128)"))]
        public string value { get; set; }
    }

}
