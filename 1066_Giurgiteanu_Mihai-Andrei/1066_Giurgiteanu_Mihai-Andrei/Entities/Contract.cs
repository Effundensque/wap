using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066_Giurgiteanu_Mihai_Andrei.Entities
{
    [Serializable]
    public class Contract
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public int SupplierId { get; set; }
        public int quantity { get; set; }
        public int finalPrice { get; set; }

        
    }
}

