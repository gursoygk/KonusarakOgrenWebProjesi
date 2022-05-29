using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Core.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public int CreatedAppUserId { get; set; }
        public int UpdatedAppUserId { get; set; }
        public AppUser? CreatedAppUser { get; set; }
        public AppUser? UpdatedAppUser { get; set; }

    }
}
