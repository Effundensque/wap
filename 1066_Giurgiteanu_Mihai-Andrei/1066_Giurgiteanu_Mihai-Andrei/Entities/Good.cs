using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066_Giurgiteanu_Mihai_Andrei.Entities
{
    [Serializable]
    public class Good
    {
        public int Id { get; set; }
        public string nameGood { get; set; }
        public int pricePerGood { get; set; }
        
    }
}
