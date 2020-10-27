using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_GIBDD.Models
{
    public class Auto
    {
        [Display(Name = "Код автомобиля")]
        public long ID { get; set; }

        [Display(Name = "Регистрационный номер")]
        public string RegNum { get; set; }

        [Display(Name = "Номер кузова")]
        public string NumberCarBody { get; set; }

        [Display(Name = "Номер двигателя")]
        public string EngineNumber { get; set; }

        [Display(Name = "Номер техпаспорта")]
        public string NumTechPass { get; set; }

        [Display(Name = "Дата выпуска")]
        public DateTime DateOfIssue { get; set; }

        [Display(Name = "Дата регистрации")]
        public DateTime DateOfRegistration { get; set; }

        [Display(Name = "Цвет")]
        public string COLOR { get; set; }

        [Display(Name = "Технический осмотр")]
        public string TechInspection { get; set; }

        [Display(Name = "Дата технического осмотра")]
        public DateTime DateTechInspection { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "код марки")]
        public long? BrandAutoID { get; set; }

        [Display(Name = "Марка машины")]
        public DbSet<BrandAuto> BrandAuto { get; set; }

        [Display(Name = "Код сотрудника")]
        public long? StaffID { get; set; }

        [Display(Name = "Сотрудник")]
        public DbSet<Staff> Staff { get; set; }

        [Display(Name = "Код водителя")]
        public long? DriverID { get; set; }

        [Display(Name = "Водитель")]
        public DbSet<Driver> Driver { get; set; }

    }
}
