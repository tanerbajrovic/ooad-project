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
        public int ID { get; set; }
        [ForeignKey("ApplicationUser")]
        public int IDUser { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey("ApplicationUser")]
        public int IDTrainer { get; set; }
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
