﻿using System;

namespace Wilson.Web.Areas.Scheduler.Models.PayrollViewModels
{
    public class PaycheckViewModel
    {
        public DateTime Date { get; set; }
        
        public DateTime From { get; set; }
        
        public DateTime To { get; set; }
        
        public int Hours { get; set; }
        
        public int HourOnBusinessTrip { get; set; }
        
        public int HourOnHolidays { get; set; }
        
        public int ExtraHours { get; set; }
        
        public int PaidDaysOff { get; set; }
        
        public int UnpaidDaysOff { get; set; }
        
        public int SickDaysOff { get; set; }
        
        public decimal PayForHours { get; set; }
        
        public decimal PayBusinessTrip { get; set; }
        
        public decimal PayForExtraHours { get; set; }
        
        public decimal PayForHolidayHours { get; set; }
        
        public decimal PayForPayedDaysOff { get; set; }
        
        public decimal Total { get; set; }
    }
}