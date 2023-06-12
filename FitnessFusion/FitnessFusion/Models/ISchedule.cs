namespace FitnessFusion.Models
{
    public interface ISchedule
    {
        #region Methods

        public ISchedule AddGymSession(GymSession session);

        #endregion
    }
}
