using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_GIBDD.Models
{
    public class CarsStolen
    {
        public long ID { get; set; }
        [Display(Name = "Дата угона")]
        public DateTime DateStolen { get; set; }
        [Display(Name = "Дата обращения")]
        public DateTime DateAppeal { get; set; }
        [Display(Name = "Обстоятельства угона")]
        public string Circumstances { get; set; }
        [Display(Name = "Отметка об нахождении")]
        public Boolean MarkFind { get; set; }
        [Display(Name = "Дата нахождения")]
        public DateTime DateFind { get; set; }
        [Display(Name = "Сотрудник")]
        public DbSet<Staff> Staff { get; set; }
        [Display(Name = "Код сотрудника")]
        public long? StaffID { get; set; }
        [Display(Name = "Автомобиль")]
        public DbSet<Auto> Auto { get; set; }
        [Display(Name = "Код автомобиля")]
        public long? AutoID { get; set; }
        [Display(Name = "Водитель")]
        public DbSet<Driver> Driver { get; set; }
        [Display(Name = "Код водителя")]
        public long? DriverID { get; set; }

    }
}
