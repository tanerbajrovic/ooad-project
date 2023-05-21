using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public abstract class Parameters
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int IDUser { get; set; }
        [ForeignKey("ParametersChoice")]
        public int IDParametersChoice { get; set; }

        #endregion

        #region Constructor

        public Parameters() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
