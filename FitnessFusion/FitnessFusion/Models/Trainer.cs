using System;
using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class Trainer : Person
    {
        #region Properties

        public Experience Experience { get; set; }
        public List<Result> TraineeResults { get; set; }

        #endregion

        #region Constructor

        public Trainer(int id, string firstName, string lastName, char sex, DateTime dateOfBirth, string address,
           string username, string password, string email, Experience experience, List<Result> traineeResults) 
            : base(id, firstName, lastName, sex, dateOfBirth, address, username, password, email)
        {
            Experience = experience;
            TraineeResults = traineeResults;
        }

        public Trainer() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
