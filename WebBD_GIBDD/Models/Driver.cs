using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_GIBDD.Models
{
    public class Driver
    {
        [Display(Name = "Код водителя")]
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }
        [Display(Name = "Номер водительского удостоверения")]
        public long DriversLicenseNum { get; set; }
        [Display(Name = "Дата выдачи удостоверения")]
        public DateTime DateIssueCertificate { get; set; }
        [Display(Name = "Дата окончания удостоверения")]
        public DateTime EndDateCertificate { get; set; }
        [Display(Name = "Категория удостоверения")]
        public string CategoryCertificate { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Код сотрудника")]
        public long StaffID { get; set; }
        [Display(Name = "Сотрудник")]
        public Staff Staff { get; set; }
        public IList<Auto> Auto { get; set; }


    }
}
