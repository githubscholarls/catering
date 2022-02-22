using catering.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering.ModelDto
{
    public class ShoppingDto:IShopping
    {
        public int Id { get; set; }
        public int Number { get; set; }
    }
}
