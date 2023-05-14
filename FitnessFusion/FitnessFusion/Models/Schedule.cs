using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace FitnessFusion.Models
{
    public class Schedule
    {
        #region Properties

        [Key]
        public int ID { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<GymSession> GymSessions { get; set; }

        #endregion

        #region Constructors

        public Schedule(int id, DateTime startDate,  DateTime endDate, List<GymSession> gymSessions)
        {
            ID = id;
            StartDate = startDate;
            EndDate = endDate;
            GymSessions = gymSessions;
        }

        public Schedule() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
