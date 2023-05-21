using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class Training : GymSession
    {
        #region Properties

        public int EstimatedDuration { get; set; }
        [ForeignKey("GymProgram")]
        public int IDGymProgram { get; set; }

        #endregion

        #region Constructor

        public Training() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
