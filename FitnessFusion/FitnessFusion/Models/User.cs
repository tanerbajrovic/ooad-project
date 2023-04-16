using System;
using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class User : Person 
    {
        #region Attributes

        private string address;
        private List<HealthIssue> healthIssues;
        private Results results;
        private ActivityProgram activityProgram;
        private CreditCard creditCard;

        #endregion

        #region Properties

        public string Address { get =>  address; set => address = value; }
        public List<HealthIssue> HealthIssues { get => healthIssues; set => healthIssues = value; }
        public Results Results { get => results; set => results = value; } 
        public ActivityProgram ActivityProgram { get => activityProgram; set => activityProgram = value; }
        public CreditCard CreditCard { get => creditCard; set => creditCard = value; }

        #endregion

        #region Constructor
        public User(int id, string firstName, string lastName, char sex, DateTime dateOfBirth, 
            string username, string password, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            DateOfBirth = dateOfBirth; 
            Username = username;
            Password = password;
            Email = email;
        }

        #endregion

        #region Methods

        // TODO
        
        #endregion

    }
}
