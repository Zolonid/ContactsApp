using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Contact class that contains person's name, phone number, birthday, email and vk id.
    /// </summary>
    public class Contact
    {
        private string[] _name;
        private PhoneNumber _phoneNumber;
        private DateTime _birthday;
        private string _email;
        private string _vkid;

        /// <summary>
        /// Contains contact's First name => [0], Middle name => [1] and Last name => [2] up to 50 characters.
        /// </summary>
        public string[] Name
        {
            get => _name;
            set
            {
                if (_name == null)
                    _name = new string[3] {"", "", ""};

                for (int i = 0; i < 3; i++)
                {
                    if (value[i] != null)
                    {
                        if (value[i].Length > 50)
                            throw new Exception("Name is too long.");

                        if (value[i] != string.Empty)
                            _name[i] = value[i].Substring(0, 1).ToUpper() + value[i].Substring(1).ToLower();
                    }
                }
            }

        }

        /// <summary>
        /// Contains contact's number.
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        /// <summary>
        /// Contact's birtday (01.01.1900 to now).
        /// </summary>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                //Date must be beetwen 01.01.1900 and now
                if (value.Year < 1900 || value > DateTime.Now)
                    throw new Exception("Birthday date cannot be sooner than 20 century.");

                _birthday = value;
            }
        }

        /// <summary>
        /// Contact's email (up to 50 characters).
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (value.Length > 50)
                    throw new Exception("Email is too long.");

                _email = value;
            }
        }

        /// <summary>
        /// VK ID (everything after "vk.com/").
        /// </summary>
        public string VKID
        {
            get => _vkid;
            set
            {
                if (value.Length > 15)
                    throw new Exception("VK ID is too long.");

                _vkid = value;
            }
        }

        /// <summary>
        /// Contructor with all parameters
        /// </summary>
        /// <param name="name">First name => [0], Middle name => [1] and Last name => [2], up to 50 characters.</param>
        /// <param name="phoneNumber">Phone Number</param>
        /// <param name="birthday">From 01.01.1900 to now.</param>
        /// <param name="email">Up to 50 characters.</param>
        /// <param name="vkid">Up to 15 characters.</param>
        public Contact(string[] name, PhoneNumber phoneNumber, DateTime birthday, string email, string vkid)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Email = email;
            VKID = vkid;
        }

        /// <summary>
        /// Default contructor with no parametrs
        /// </summary>
        public Contact()
        {

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