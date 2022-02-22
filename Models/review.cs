using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    /// <summary>
    /// 评论
    /// </summary>
    public class review
    {
        public int Id { get; set; }
        [Column(TypeName = ("nvarchar(450)"))]
        public string content { get; set; }

        [Column(TypeName = ("nvarchar(450)"))]
        public user user { get; set; }
        public int? productId { get; set; }
        public product product { get; set; }
        public DateTime createTime { get; set; }

    }
}
