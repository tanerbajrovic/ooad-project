using Microsoft.VisualBasic;
using System;

namespace FitnessFusion.Models
{
    public abstract class GymSession
    {

        #region Attributes

        private int id;
        private DateTime dateTime;
        private bool isComplete;
        private int calories;

        #endregion

        #region Properties

        public int Id { get => id; set => id = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }  
        public bool IsComplete { get => isComplete; set => isComplete = value; }
        public int Calories { get => calories; set => calories = value; }

        #endregion

        #region Constructor
        public GymSession(int id, DateTime dateTime, bool isComplete = false, int calories = 0)
        {
            Id = id;
            DateTime = dateTime;
            IsComplete = isComplete;
            Calories = calories;
        }

        public GymSession()
        {

        }

        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
