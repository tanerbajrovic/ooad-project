using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class Training
    {
        #region Attributes

        private int id;
        private int duration;
        private List<Activity> activities;

        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int Duration { get => duration; set => duration = value; }
        public List<Activity> Activities { get => activities; set => activities = value; }

        #endregion

        #region Consturctor

        public Training(int id, int duration, List<Activity> activities) 
        {
            Id = id;
            Duration = duration;
            Activities = activities;
        }

        #endregion

        #region Methods

        #endregion
    }
}
