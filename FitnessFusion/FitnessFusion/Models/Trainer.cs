using System;
using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class Trainer : Person
    {
        #region Attributes
        
        private Experience experience;
        private List<User> trainees;

        #endregion

        #region Properties

        public Experience Experience { get => experience; set => experience = value; }
        public List<User> Trainees { get => trainees; set => trainees = value; }

        #endregion

        #region Constructor

        public Trainer(int id, string firstName, string lastName, char sex, DateTime dateOfBirth,
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
    }
}
