using System;

namespace FitnessFusion.Models
{
    public class CardioParameters : BasicParameters
    {
        #region Attributes

        private double sprintRunning;
        private double running;
        private double verticalJump;
        private double horizontalJump;

        #endregion

        #region Properties

        public double SprintRunning { get =>  sprintRunning; set => sprintRunning = value; }
        public double Running { get => running; set => running = value; }
        public double VerticalJump { get => verticalJump; set => verticalJump = value; }
        public double HorizontalJump { get => horizontalJump; set => horizontalJump = value; }

        #endregion

        #region Constructor

        public CardioParameters(int id, int calories, double mass, double height, 
                                Tuple<double, double> waist, double sprintRunning,
                                double running, double verticalJump, double horizontalJump)
            : base(id, calories, mass, height, waist)
        {
            SprintRunning = sprintRunning;
            Running = running;
            VerticalJump = verticalJump;
            HorizontalJump = horizontalJump;
        }

        public CardioParameters()
        {

        }

        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
