namespace FitnessFusion.Models
{
    public class ExtraGymSessionDecorator : ScheduleDecorator
    {
        #region Constructor

        public ExtraGymSessionDecorator(ISchedule schedule) : base(schedule)
        {
        }

        #endregion

        #region Methods

        public override ISchedule AddGymSession(GymSession session)
        {
            return decoratedSchedule;
        }

        #endregion
    }
}
