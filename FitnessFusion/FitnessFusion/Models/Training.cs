using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class Training : GymSession
    {
        #region Properties

        [ForeignKey("GymProgram")]
        public int GymProgramId { get; set; }
        public GymProgram GymProgram { get; set; }
        public int EstimatedDuration { get; set; }
        #endregion

        #region Constructor

        public Training() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
