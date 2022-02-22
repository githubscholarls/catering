using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    /// <summary>
    /// 商品类
    /// </summary>
    public class category
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        [Column(TypeName =("varchar(16)"))]
        public string currentId { get; set; }
        /// <summary>
        /// 商品分类的父类，默认为商品的第一级类别
        /// </summary>
        [Column(TypeName =("varchar(16)"))]
        public string parentId { get; set; } = "0";
        /// <summary>
        /// 商品分类名称
        /// </summary>
        [Required]
        [Column(TypeName = ("nvarchar(32)"))]
        public string name { get; set; }
        
    }
}
