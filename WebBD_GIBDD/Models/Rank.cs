using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_GIBDD.Models
{
    public class Rank
    {
        [Display(Name = "Код звания")]
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string NameRank { get; set; }
        [Display(Name = "Надбавка")]
        public int Salary { get; set; }
        [Display(Name = "Обязанности")]
        public string Duties { get; set; }

        [Display(Name = "Требования")]
        public string Requirements { get; set; }

    }
}
