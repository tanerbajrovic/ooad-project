using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace FitnessFusion.Models
{
    public class Result
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int IDUser { get; set; }
        [ForeignKey("Trainer")]
        public int IDTrainer { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public double Mass { get; set; }
        public double Height { get; set; }  
        // public List<double> Circumferences { get; set; }
        public double WaistCircumference { get; set; }

        #endregion

        #region Constructor

        public Result() { }

        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
