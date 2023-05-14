using System;
using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class User : Person 
    {
        #region Properties

        public List<HealthIssueType> HealthIssues { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        public List<Parameters> Results { get; set; }
        public double ActivityCoefficient { get; set; }
        public Schedule Schedule { get; set; }
        public GymProgram ActivityProgram { get; set; }

        #endregion

        #region Constructor

        public User(int id, string firstName, string lastName, char sex, DateTime dateOfBirth, string address, 
            string username, string password, string email, List<HealthIssueType> healthIssues,
            List<CreditCard> creditCards, List<Parameters> results, double activityCoefficient, 
            Schedule schedule, GymProgram activityProgram) : base(id, firstName, lastName, sex, dateOfBirth, 
                address, username, password, email)
        {
            HealthIssues = healthIssues;
            CreditCards = creditCards;
            Results = results;
            ActivityCoefficient = activityCoefficient;
            Schedule = schedule;
            ActivityProgram = activityProgram;
        }

        public User() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
