using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dto - data transfer objects

namespace OnlineShop.Models.Dtos
{
    public class CartItemToAddDto
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}
