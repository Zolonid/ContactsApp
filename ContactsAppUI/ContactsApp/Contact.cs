using System;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Contact class that contains person's name, phone number, birthday, email and vk id.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Contains Person's First name => [0], Middle name => [1] and Last name => [2]
        /// </summary>
        public string[] Name { get; private set; }

        /// <summary>
        /// Contains Person's number
        /// </summary>
        public PhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Person's birtday
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Email (get is public,Set email through SetEmail())
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// VK ID (get is public,Set ID through SetVKID())
        /// </summary>
        public string VKID { get; private set; }

        /// <summary>
        /// Contact's constructor
        /// </summary>
        public Contact(string firstName, string middleName, string lastName, PhoneNumber number, DateTime birthdayDate)
        {
            //Initialization
            PhoneNumber = new PhoneNumber();
            Name = new string[3];
            for (int i = 0; i < 3; i++)
                Name[i] = "";
            Birthday = DateTime.MinValue;
            Email = "";
            VKID = "";

            SetName(firstName, middleName, lastName);
            SetBirthday(birthdayDate);
            PhoneNumber = number;
        }

        /// <summary>
        /// Contructor for json Serialization
        /// </summary>
        /// <param name="name">First name => [0], Middle name => [1] and Last name => [2]</param>
        /// <param name="number">Phone Number</param>
        /// <param name="birthdayDate"></param>
        /// <param name="email"></param>
        /// <param name="vkid"></param>
        [JsonConstructor]
        public Contact(string[] name, PhoneNumber number, DateTime birthdayDate, string email, string vkid)
        {
            Name = name;
            PhoneNumber = number;
            Birthday = birthdayDate;
            Email = email;
            VKID = vkid;
        }

        /// <summary>
        /// Default contructor with no parametrs
        /// </summary>
        public Contact()
        {
            //Initialization
            PhoneNumber = new PhoneNumber();
            Name = new string[3];
            for (int i = 0; i < 3; i++)
                Name[i] = "";
            Birthday = DateTime.MinValue;
            Email = "";
            VKID = "";
        }

        /// <summary>
        /// Sets name Must be less than 50 symbols each
        /// </summary>
        public void SetName(string firstName, string middleName, string lastName)
        {
            //Maximum length of any name is 50 symbols
            if (firstName.Length > 50 || middleName.Length > 50 || lastName.Length > 50)
                throw new Exception("Name is too long.");

                //String tranformation from "AaAaAaAa" to "Aaaaaaaa"
            Name = new string[3];
            if (firstName != string.Empty)
                Name[0] = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();
            if (middleName != string.Empty)
                Name[1] = middleName.Substring(0, 1).ToUpper() + middleName.Substring(1).ToLower();
            if (lastName != string.Empty)
                Name[2] = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();
        }

        /// <summary>
        /// Set's date of birth idk
        /// </summary>
        /// <param name="date">Birthday date</param>
        public void SetBirthday(DateTime date)
        {
            /*//Can't be later than now or sooner than 20 century
            if (date.Year < 1900)
                throw new Exception("Birthday date cannot be sooner than 20 century.");
            if (date > DateTime.Now)
                throw new Exception("Birthday date cannot be later than now.");*/

            Birthday = date;
        }

        /// <summary>
        /// Sets email
        /// </summary>
        /// <param name="email">Pretty self explanatory</param>
        public void SetEmail(string email)
        {
            //Maximum length of email is 50 symbols
            if (email.Length > 50)
                throw new Exception("Email is too long.");

            Email = email;
        }

        /// <summary>
        /// Sets VK ID
        /// </summary>
        /// <param name="vkid">copies everything after vk.com\</param>
        public void SetVKID(string vkid)
        {
            //Maximum length of email is 50 symbols
            if (vkid.Length > 15)
                throw new Exception("VK ID is too long.");

            VKID = vkid;
        }

        /// <summary>
        /// Clone function for ISerializible
        /// </summary>
        /// <returns></returns>
        public Contact Clone()
        {
            Contact clone = new Contact(Name, PhoneNumber, Birthday, Email, VKID);
            return clone;
        }
    }
}