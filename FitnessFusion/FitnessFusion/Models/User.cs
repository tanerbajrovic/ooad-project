using System;
using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class User : Person 
    {
        #region Attributes

        private List<HealthIssue> healthIssues;
        private List<CreditCard> creditCards;
        private List<BasicParameters> results;
        private BasicParameters personalBest;
        private double activityCoefficient;
        private Schedule schedule;
        private GymProgram activityProgram;

        #endregion

        #region Properties

        public List<HealthIssue> HealthIssues { get => healthIssues; set => healthIssues = value; }
        public List<CreditCard> CreditCards { get => creditCards; set => creditCards = value; }
        public List<BasicParameters> Results { get => results; set => results = value; }
        public BasicParameters PersonalBest { get => personalBest; set => personalBest = value; }
        public double ActivityCoefficient { get => activityCoefficient; set => activityCoefficient = value; }
        public Schedule Schedule { get => schedule; set => schedule = value; }
        public GymProgram ActivityProgram { get => activityProgram; set => activityProgram = value; }

        #endregion

        #region Constructor

        public User(int id, string firstName, string lastName, char sex, DateTime dateOfBirth, string address, 
                    string username, string password, string email, List<HealthIssue> healthIssues, List<CreditCard> creditCards, 
                    List<BasicParameters> results, BasicParameters personalBest, double activityCoefficient, Schedule schedule, 
                    GymProgram activityProgram) 
           : base(id, firstName, lastName, sex, dateOfBirth, address, username, password, email)
        {
            HealthIssues = healthIssues;
            CreditCards = creditCards;
            Results = results; 
            PersonalBest = personalBest;
            ActivityCoefficient = activityCoefficient;
            Schedule = schedule;
            ActivityProgram = activityProgram;
        }

        public User() : base() 
        {
        
        }

        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
