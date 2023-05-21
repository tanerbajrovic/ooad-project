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

        public StrengthParameters() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
