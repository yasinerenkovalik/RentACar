using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Feature
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Featureİd { get; set; }
        public int Cateegoryİd { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Valu { get; set; }
        public string EnteredValue { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}
