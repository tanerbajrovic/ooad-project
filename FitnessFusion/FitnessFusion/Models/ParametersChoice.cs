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
        public int ResultID { get; set; }
        [ForeignKey("Parameters")]
        public int ParametersID { get; set; }

        #endregion

        #region Constructor
        
        public ParametersChoice(int id, int resultId, int parametersId)
        {
            ID = id;
            ResultID = resultId;
            ParametersID = parametersId;
        }

        public ParametersChoice() {  }
       
        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
