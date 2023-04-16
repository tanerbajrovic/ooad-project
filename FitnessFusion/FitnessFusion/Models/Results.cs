using System.Numerics;

namespace FitnessFusion.Models
{
    public class Results
    {
        #region Attributes

        private double mass;
        private double height;
        private Vector<double> waist;
        private double benchPress;
        private double squat;

        #endregion

        #region Properties

        public double Mass { get =>  mass; set => mass = value; }
        public double Height { get => height; set => height = value; } 
        public Vector<double> Waist { get => waist; set => waist = value; }
        public double BenchPress { get => benchPress; set => benchPress = value; }
        public double Squat { get => squat; set => squat = value; }

        #endregion

        #region Constructor
        
        // Primary constructor -- Probably use BuilderPattern
        public Results(double mass, double height)
        {
            Mass = mass;
            Height = height;
        }

        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
