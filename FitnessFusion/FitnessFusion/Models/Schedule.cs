using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace FitnessFusion.Models
{
    public class Schedule
    {
        #region Attributes

        private DateTime startDate;
        private DateTime endDate;
        private List<GymSession> gymSessions;

        #endregion

        #region Properties

        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public List<GymSession> GymSessions { get => gymSessions; set => gymSessions = value; }

        #endregion

        #region Constructors

        public Schedule(DateTime startDate,  DateTime endDate, List<GymSession> gymSessions)
        {
            StartDate = startDate;
            EndDate = endDate;
            GymSessions = gymSessions;
        }

        public Schedule()
        {

        }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
