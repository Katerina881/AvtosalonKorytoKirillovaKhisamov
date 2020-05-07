using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorytoService.BindingModel
{
    public class OrderBindingModel
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public decimal TotalSum { get; set; }

        public virtual List<OrderCarBindingModel> OrderCars { get; set; }
    }
}
