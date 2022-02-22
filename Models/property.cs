using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    /// <summary>
    /// 商品属性
    /// </summary>
    public class productProperty
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 分类选项Id
        /// </summary>
        public int? optionId { get; set; }
        public option  option { get; set; }
        /// <summary>
        /// 商品属性名称
        /// </summary>
        [Column(TypeName = ("nvarchar(450)"))]
        public string name { get; set; }
    }
}
