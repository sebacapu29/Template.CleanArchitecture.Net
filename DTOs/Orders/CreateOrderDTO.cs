using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Orders
{
    public class CreateOrderDTO
    {
        public int CustomerId { get; set; }
        public string ShipAdress { get; set; } = string.Empty;
        public string ShipCity { get; set; } = string.Empty;
        public string ShipCounty { get; set; } = string.Empty;
        public List<CreateOrderDetailDTO> OrderDetails { get; set; } 
    }
}
