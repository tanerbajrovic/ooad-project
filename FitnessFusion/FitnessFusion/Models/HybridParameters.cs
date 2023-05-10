using System;

namespace FitnessFusion.Models
{
    public class HybridParameters : BasicParameters
    {
        #region Attributes

        private double benchPress;
        private double squat;
        private int absTest;
        private int pushUps;
        private double sprintRunning;
        private double running;
        private double verticalJump;
        private double horizontalJump;

        #endregion

        #region Properties

        public double BenchPress { get => benchPress; set => benchPress = value; }
        public double Squat { get => squat; set => squat = value; }
        public int AbsTest { get => absTest; set => absTest = value; }
        public int PushUps { get => pushUps; set => pushUps = value; }
        public double SprintRunning { get => sprintRunning; set => sprintRunning = value; }
        public double Running { get => running; set => running = value; }
        public double VerticalJump { get => verticalJump; set => verticalJump = value; }
        public double HorizontalJump { get => horizontalJump; set => horizontalJump = value; }

        #endregion

        #region Constructor

        public HybridParameters(int id, int calories, double mass, double height, Tuple<double, double> waist,
                               double benchPress, double squat, int absTest, int pushUps, double sprintRunning,
                               double running, double verticalJump, double horizontalJump)
           : base(id, calories, mass, height, waist)
        {
            BenchPress = benchPress;
            Squat = squat;
            AbsTest = absTest;  
            PushUps = pushUps;
            Running = running;
            VerticalJump = verticalJump;
            HorizontalJump = horizontalJump;
        }

        public HybridParameters() : base()
        { 
        
        } 

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
