using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class ActivityProgram
    {
        #region Attributes

        private int id;
        private string name;
        private string description;
        private string overview;
        private List<Training> trainings;
        private string category;
        private Rating rating;

        #endregion

        #region Properties
        public int Id { get =>  id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Overview { get => overview; set => overview = value; }
        public string Category { get => category; set => category = value; }
        public List<Training> Trainings { get => trainings; set => trainings = value; }
        public Rating Rating { get => rating; set => rating = value; }

        #endregion

        #region Constuctor
        public ActivityProgram(int id, string name, string description, 
            string overview, Rating rating)
        {
            Id = id;
            Name = name;
            Description = description;
            Overview = overview;
        }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
