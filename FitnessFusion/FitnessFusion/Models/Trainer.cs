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
                       string address, string username, string password, string email, 
                       Experience experience, List<User> trainees) 
            : base(id, firstName, lastName, sex, dateOfBirth, address, username, password, email)
        {
            Experience = experience;
            Trainees = trainees;
        }

        public Trainer() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
