using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class Training : GymSession
    {
        #region Properties

        [ForeignKey("GymProgram")]
        public int GymProgramId { get; set; }
        public GymProgram GymProgram { get; set; }
        [DisplayName("Estimated Duration")]
        public int EstimatedDuration { get; set; }
        #endregion

        #region Constructor

        public Training() : base() { }

        #endregion

        #region Methods

        public Training Clone(Training original)
        {
            ScheduleId = original.ScheduleId;
            StartTime = original.StartTime;
            IsComplete = false;
            BurnedCalories = original.BurnedCalories;
            GymProgramId = original.GymProgramId;
            EstimatedDuration = original.EstimatedDuration;
            return this;
        }

        /*
            Neka imamo Clone metodu unutar Schedule kontrolera:
                public async Task<IActionResult> Clone(int id)
                {
                    var originalTraining = _context.Training.Find(id);
                    var clone = new Training();
                    clone = clone.clone(originalTraining);
                    _context.Add(clone);
                    _context.SaveChanges();
                    var CloneID = clone.Id;
                    var activities = _context.GymActivityChoice.Where(g => g.TrainingId == id).ToList();
                    list<GymActivityChoice> clonedActivities;
                    foreach(var activity in activities)
                    {
                        GymActivityChoice clonedActivity = new GymActivityChoice();
                        clonedActivity.clone(activity, -1, CloneID);
                        clonedActivities.add(clonedActivity);
                    }
                    foreach(var activity in clonedActivities)
                    {
                        _context.Add(activity);
                    }
                    _context.SaveChanges();
                    ....
                }
        */

        #endregion
    }
}
