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

        public HybridParameters(int id, double benchPress, double squat, int absTest,
            int pushUps, double sprintRunning, double running, double verticalJump, 
            double horizontalJump) : base(id) 
        { 
            BenchPress = benchPress;
            Squat = squat;
            AbsTest = absTest;
            PushUps = pushUps;
            Running = running;
            VerticalJump = verticalJump;
            HorizontalJump = horizontalJump;
        }

        public HybridParameters() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
