using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class ParametersChoice
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        [ForeignKey("Result")]
        public int IDResult { get; set; }
        public Result Result { get; set; }
        [ForeignKey("Parameters")]
        public int IDParameters { get; set; }
        public Parameters Parameters { get; set; }

        #endregion

        #region Constructor

        public ParametersChoice() {  }
       
        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
