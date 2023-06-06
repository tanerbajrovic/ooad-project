using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace FitnessFusion.Models
{
    public class Schedule
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey("ApplicationUser")]
        public string TrainerId { get; set; }
        public ApplicationUser Trainer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #endregion

        #region Constructors

        public Schedule() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
