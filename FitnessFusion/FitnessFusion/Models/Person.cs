using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessFusion.Models
{
    public abstract class Person
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public char Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        #endregion

        #region Constructor

        public Person(int id, string firstName, string lastName, char sex,
           DateTime dateOfBirth, string address, string username, string password, 
           string email)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            DateOfBirth = dateOfBirth;
            Address = address;
            Username = username;
            Password = password;
            Email = email;
        }

        public Person() { }

        #endregion

        #region Methods
        
        // TODO

        #endregion
    }
}
