using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class Trainer : ApplicationUser
    {
        #region Properties

        [Display(Name = "Trainer's Experience")]
        public Experience Experience { get; set; }

        #endregion

        #region Constructor

        public Trainer() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
