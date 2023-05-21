using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class GymProgram
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Overview { get; set; }
        public GymProgramType Type { get; set; }

        #endregion

        #region Constructor

        public GymProgram() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
