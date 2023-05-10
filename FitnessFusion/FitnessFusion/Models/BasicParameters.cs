using System;

namespace FitnessFusion.Models
{
    public class BasicParameters
    {
        #region Attributes

        private int id;
        private int calories;
        private double mass;
        private double height;
        private Tuple<double, double> waist; // Relaxed, extended 

        #endregion

        #region Properties

        public int Id { get =>  id; set => id = value; }
        public int Calories { get => calories; set => calories = value; }
        public double Mass { get => mass; set => mass = value; }
        public double Height { get => height; set => height = value; }
        public Tuple<double, double> Waist { get => waist; set => waist = value; }

        #endregion

        #region Constructor

        public BasicParameters(int id, int calories, double mass, double height, Tuple<double, double> waist)
        {
            Id = id;
            Calories = calories;
            Mass = mass;
            Height = height;
            Waist = waist;
        }

        public BasicParameters() 
        {
        
        }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
