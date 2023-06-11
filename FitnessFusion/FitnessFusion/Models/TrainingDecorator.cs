namespace FitnessFusion.Models
{
    public class TrainingDecorator : ScheduleDecorator
    {
        #region Constructor
        public TrainingDecorator(ISchedule schedule) : base(schedule)
        {
        }

        #endregion

    }
}
