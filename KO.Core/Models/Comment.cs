using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Core.Models
{
    public class Comment : BaseEntity
    {
        public string? Message { get; set; }

        public int ProdcutId { get; set; }
        public Product? Product { get; set; }

    }
}
