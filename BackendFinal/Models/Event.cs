using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendFinal.Models
{
    public class Event : BaseEntity
    {
               
        public string Adress { get; set; }
        [StringLength(2500)]
        public string information { get; set; }
        [StringLength(2500)]

        public string UseFullink { get; set; }
        [StringLength(2500)]
        public string Sosialmedya { get; set; }
        [StringLength(2500)]

        public string Number { get; set; }
        [StringLength(255)]
        public string Lesson { get; set; }
        [StringLength(2500)]

        public string LessonTime { get; set; }
        [StringLength(2500)]

        public string LessonLocation { get; set; }

    }
}
