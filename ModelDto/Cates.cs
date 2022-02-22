using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering.ModelDto
{
    public class Cate
    {
        public string Id { get; set; }
        public string parentId { get; set; }
        public string name { get; set; }
        public List<Cate> cates { get; set; }
    }
}
