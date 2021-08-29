using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class RegistractionModel
    {
        public int ProjectId { get; set; }
        [Required]
        public string ProjName { get;set;}
        [Required]
        public int ProjValue { get;set;}
        public  DateTime ApplicationDate { get; set; }
        public string ProjSponser { get; set; }
        public string ProjStatus { get; set; }
        public int Targets { get; set; }
        public DateTime ProjStartDate { get; set; }
        public DateTime ProjEndDate { get; set; }
        public int  TotalDays { get; set; }
        public string ReservationAllowed { get; set; }
        public string Scheme { get; set; }
        public string States { get; set; }
        public string Districts { get; set; }
        public string Gender { get; set; }
        public string Caste { get; set; }


    }
}


