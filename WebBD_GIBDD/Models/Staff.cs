using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_GIBDD.Models
{
    public class Staff
    {
        [Display(Name = "Код сотрудника")]
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Возраст")]
        public short Age { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Номер телефона")]
        public long Phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }
        public long? PositionID { get; set; }
        [Display(Name = "Должность")]
        public Position Position { get; set; }
        public long? RankID { get; set; }
        [Display(Name = "Звание")]
        public Rank Rank { get; set; }
        public IList<Auto> Auto { get; set; }
        public IList<Driver> Driver { get; set; }
        public IList<CarsStolen> CarsStolen { get; set; }

    }
}
