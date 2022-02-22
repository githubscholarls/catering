using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    public class order
    {
        public int Id { get; set; }
        [Column(TypeName = ("varchar(32)"))]
        public string orderCode { get; set; }
        [Column(TypeName = ("nvarchar(32)"))]
        public string adress { get; set; }
        [Column(TypeName = ("varchar(32)"))]
        
        public string post { get; set; }
        [Column(TypeName = ("nvarchar(32)"))]
        public string receiver { get; set; }

        [Column(TypeName = ("varchar(32)"))]
        public string mobile { get; set; }
        [Column(TypeName = ("nvarchar(32)"))]
        public string useMessage { get; set; }
        public DateTime createDate { get; set; }
        public DateTime payDate { get; set; }
        public DateTime deliveryDate { get; set; }
        public DateTime confirmDate { get; set; }
        
        public user user { get; set; }
        public bool status { get; set; }
    }
}
