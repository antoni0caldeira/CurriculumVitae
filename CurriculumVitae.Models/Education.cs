using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Models
{
    internal class Experience
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Institution Institution { get; set; }
        public Title Title { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
    }
    
}
