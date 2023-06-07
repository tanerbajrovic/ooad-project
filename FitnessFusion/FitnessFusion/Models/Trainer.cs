using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class Trainer
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
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
