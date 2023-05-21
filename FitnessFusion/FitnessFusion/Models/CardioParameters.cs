using System;

namespace FitnessFusion.Models
{
    public class CardioParameters : Parameters
    {
        #region Properties

        public double SprintRunning { get; set; }
        public double Running { get; set; }
        public double VerticalJump { get; set; }
        public double HorizontalJump { get; set; }

        #endregion

        #region Constructor

        public CardioParameters() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
