using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Order
    {

        //[Column("Id")]
        public Guid OrderId { get; set; }

        //[MaxLength(100)]
        public string Name { get; set; }

        //[Column(TypeName = "Date")]
        //[Required]
        public DateTime Create {  get; set; }

        //[Column(TypeName = "Date")]
        public DateTime Update { get; set; }

        //[MaxLength(300)]
        public string Description { get; set; }

        //[Column("AlterId")]
        //[Required]
        public int OrderAlterId { get; set; }
    }
}
