using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace catering.Models
{
    /// <summary>
    /// 商品
    /// </summary>
    public class product
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [MaxLength(225)]
        public string name { get; set; }
        /// <summary>
        /// 商品小标题
        /// </summary>
        [MaxLength(225)]
        public string subTitle { get; set; }
        
        /// <summary>
        ///初始价格
        /// </summary>
        public float originalPrice { get; set; }
        /// <summary>
        /// 优惠价格
        /// </summary>
        public float promotePrice { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public int stock { get; set; }
        /// <summary>
        /// 商品所属分类id
        /// </summary>
        public int? categoryId { get; set; }
        public category category { get; set; }
        public DateTime creatDate { get; set; }
    }
}
