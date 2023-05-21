using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FitnessFusion.Models
{
    public class ExtraGymSession : GymSession
    {
        #region Properties

        public int Duration { get; set; }
        public string Note { get; set;}

        #endregion

        #region Constructor

        public ExtraGymSession() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
