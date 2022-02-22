
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    public class ordersummary
    {
        public int Id { get; set; }
        /// <summary>
        /// 商品图片Id
        /// </summary>
        public int? productimageId { get; set; }
        public productimage productimage { get; set; }
        /// <summary>
        /// 订单Id
        /// </summary>
        public int? orderId { get; set; }
        public order order { get; set; }
        /// <summary>
        /// 用户Id(AspNetUser    Id)
        /// </summary>
        [Column(TypeName ="nvarchar(450)")]
        public string userId { get; set; }
        public user user { get; set; }
        /// <summary>
        /// 订单汇总数
        /// </summary>
        public int number { get; set; }

    }
}
