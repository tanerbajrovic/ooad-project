using System;

namespace FitnessFusion.Models
{
    public abstract class Parameters
    {
        #region Properties

        public int ID { get; set; }

        #endregion

        #region Constructor

        public Parameters(int id)
        {
            ID = id;
        }

        public Parameters() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
