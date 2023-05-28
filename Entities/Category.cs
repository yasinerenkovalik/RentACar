using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Categoryİd { get; set; }
        public string Name { get; set; }
        public int SubCategory { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}
