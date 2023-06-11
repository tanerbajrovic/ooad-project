using System;

namespace FitnessFusion.Models
{
    public abstract class ScheduleDecorator : ISchedule
    {
        #region Attributes

        protected ISchedule decoratedSchedule;

        #endregion

        #region Constructor

        public ScheduleDecorator(ISchedule schedule) 
        { 
            decoratedSchedule = schedule;
        }

        #endregion

        #region Methods

        public virtual ISchedule AddGymSession(GymSession session)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
