﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHealthCareDesktopApp.Models
{
    public class MedicationViewModel
    {
        public int Id { get; set; }
        public string MedicationName { get; set; }
        public string Strength { get; set; }
        public string Dose { get; set; }
        public string HowTaken { get; set; }
        public string ReasonForTaking { get; set; }
        public string Notes { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }  
    }
}