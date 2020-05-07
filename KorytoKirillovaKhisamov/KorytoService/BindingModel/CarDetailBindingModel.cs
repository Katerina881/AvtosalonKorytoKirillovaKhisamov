using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorytoService.BindingModel
{
    public class CarDetailBindingModel
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int DetailId { get; set; }

        public int Amount { get; set; }
    }
}
