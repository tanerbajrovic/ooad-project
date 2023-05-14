using System;

namespace FitnessFusion.Models
{
    public class StrengthParameters : Parameters
    {
        #region Properties

        public double BenchPress { get; set; }
        public double Squat { get; set; }
        public int AbsTest { get; set; }
        public int PushUps { get; set; }

        #endregion

        #region Constructor

        public StrengthParameters(int id, double benchPress, double squat, int absTest,
           int pushUps) : base(id)
        {
            BenchPress = benchPress;
            Squat = squat;
            AbsTest = absTest;
            PushUps = pushUps;
        }

        public StrengthParameters() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
