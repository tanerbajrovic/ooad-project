using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace FitnessFusion.Models
{
    public class ExtraGymSession : GymSession
    {
        #region Properties

        // Maximum duration is 3hr = 180 minutes
        [Range(1, 180, ErrorMessage = "Session cannot be longer than 3 hours.")]
        public int Duration { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Note cannot be longer than 100 characters.")]
        public string Note { get; set;}

        #endregion

        #region Constructor

        public ExtraGymSession() : base() { }

        #endregion

        #region Methods

        public ExtraGymSession Clone(ExtraGymSession original)
        {
            ScheduleId = original.ScheduleId;   
            StartTime = original.StartTime;
            IsComplete = false;
            BurnedCalories = original.BurnedCalories;
            Duration = original.Duration;
            Note = original.Note;
            return this;
        }

        /*
            Neka imamo Clone metodu unutar Schedule kontrolera:
                public async Task<IActionResult> Clone(int id)
                {
                    var originalExtraGymSession = _context.ExtraGymSession.Find(id);
                    var clone = new ExtraGymSession();
                    clone = clone.clone(originalExtraGymSession);
                    _context.Add(clone);
                    _context.SaveChanges();
                    var CloneID = clone.Id;
                    var activities = _context.GymActivityChoice.Where(g => g.ExtraGymSessionId == id).ToList();
                    list<GymActivityChoice> clonedActivities;
                    foreach(var activity in activities)
                    {
                        GymActivityChoice clonedActivity = new GymActivityChoice();
                        clonedActivity.clone(activity, CloneID);
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
