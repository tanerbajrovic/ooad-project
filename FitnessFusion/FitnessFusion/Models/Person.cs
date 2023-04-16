using System;

namespace FitnessFusion.Models
{
    public abstract class Person
    {
        #region Attributes

        private int id;
        private string firstName;
        private string lastName;
        private char sex;
        private DateTime dateOfBirth;
        private string username;
        private string password;
        private string email;

        #endregion

        #region Properties

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public char Sex { get => sex; set => sex = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        #endregion

        #region Methods
        // TODO

        #endregion
    }
}
