using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace FitnessFusion.Models
{
    public class Result
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public double Mass { get; set; }
        public double Height { get; set; }  
        public List<double> Circumferences { get; set; }
        public List<Parameters> AdditionalResults { get; set; }

        #endregion

        #region Constructor

        public Result(int id, int calories, DateTime date, double mass, double height,
            List<double> circumferences, List<Parameters> additionalResults)
        {
            ID = id;
            Calories = calories;
            Date = date;
            Mass = mass;
            Height = height;
            Circumferences = circumferences;
            AdditionalResults = additionalResults;
        }

        public Result() { }

        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
