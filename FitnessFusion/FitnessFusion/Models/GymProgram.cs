﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class GymProgram
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Program name cannot be longer than 50 characters.")]
        public string Name { get; set; }
        [Required]
        [StringLength(125, ErrorMessage = "Description cannot be longer than 125 characters.")]
        public string Description { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Overview cannot be longer than 50 characters.")]
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
