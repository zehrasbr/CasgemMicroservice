using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos
{
    public class UpdateOrderDetailDto
    {
        public int OrderDetailID { get; set; }
        public string ProductID { get; set; }
        public string PrdouctName { get; set; }
        public decimal PrdouctPrice { get; set; }
        public int PrdouctAmount { get; set; }
        public int OderID { get; set; }
    }
}
