using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Models
{
    internal class Education
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Institution Institution { get; set; }
        public string Name { get; set; }
        public Degree Degree { get; set; }
  
    }
    
}
