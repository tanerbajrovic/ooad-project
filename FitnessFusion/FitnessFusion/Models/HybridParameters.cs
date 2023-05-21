using System;

namespace FitnessFusion.Models
{
    public class HybridParameters : Parameters
    {
        #region Properties

        public double BenchPress { get; set; }
        public double Squat { get; set; }
        public int AbsTest { get; set; }
        public int PushUps { get; set; }
        public double SprintRunning { get; set; }
        public double Running { get; set; }
        public double VerticalJump { get; set; }
        public double HorizontalJump { get; set; }

        #endregion

        #region Constructor

        public HybridParameters() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
