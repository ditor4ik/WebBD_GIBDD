using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_GIBDD.Models
{
    public class BrandAuto
    {
        [Display(Name = "Код марки")]
        public long ID { get; set; }
        [Display(Name = "Фирма производитель")]
        public string CompanyManufacturer { get; set; }
        [Display(Name = "Страна производитель")]
        public string CountryManufacturer { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Дата начала производства")]
        public DateTime StartProduction { get; set; }
        [Display(Name = "Дата окончания производства")]
        public DateTime EndProduction { get; set; }
        [Display(Name = "Категория")]
        public string Specifications { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        public List<Auto> Auto { get; set; }
    }
}
