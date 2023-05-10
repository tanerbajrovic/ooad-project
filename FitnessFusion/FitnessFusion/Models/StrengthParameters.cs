using System;

namespace FitnessFusion.Models
{
    public class StrengthParameters : BasicParameters
    {
        #region Attributes

        private double benchPress;
        private double squat;
        private int absTest;
        private int pushUps;

        #endregion

        #region Properties

        public double BenchPress { get => benchPress; set => benchPress = value; }
        public double Squat { get => squat; set => squat = value; }
        public int AbsTest { get => absTest; set => absTest = value; }
        public int PushUps { get => pushUps; set => pushUps = value; }

        #endregion

        #region Constructor

        public StrengthParameters(int id, int calories, double mass, double height,
                                  Tuple<double, double> waist, double benchPress, 
                                  double squat, int absTest, int pushUps)
            : base(id, calories, mass, height, waist)
        {
            BenchPress = benchPress;
            Squat = squat;
            AbsTest = absTest;
            PushUps = pushUps;
        }

        public StrengthParameters() : base() 
        {
        
        }

        #endregion

        #region Methods

        #endregion
    }
}
