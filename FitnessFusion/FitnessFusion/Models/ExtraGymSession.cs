using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace FitnessFusion.Models
{
    public class ExtraGymSession : GymSession
    {
        #region Properties

        // Maximum duration is 3hr = 180 minutes
        [Range(1, 180, ErrorMessage = "Session cannot be longer than 3 hours.")]
        public int Duration { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Note cannot be longer than 100 characters.")]
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
