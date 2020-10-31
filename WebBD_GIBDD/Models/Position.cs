using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BD_GIBDD.Models
{
    public class Position
    {
        [Display(Name = "Код должности")]
        public long ID { get; set; }
        [Display(Name = "Наименование должности")]
        public string NamePosition { get; set; }
        [Display(Name = "Оклад")]
        public int Salary { get; set; }
        [Display(Name = "Обязанности")]
        public string Duties { get; set; }
        [Display(Name = "Требования")]
        public string Requirements { get; set; }
        public List<Staff> Staff { get; set; }
    }
}
