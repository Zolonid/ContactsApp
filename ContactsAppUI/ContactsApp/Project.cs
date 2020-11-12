using System;
using System.Collections.Generic;

namespace ContactsApp
{
    /// <summary>
    /// Wrapper class for contacts
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Holds existing contacts
        /// </summary>
        public List<Contact> ContactList;

        /// <summary>
        /// Default contructor with no parameters
        /// </summary>
        public Project()
        {
            ContactList = new List<Contact>(200);
        }

        /// <summary>
        /// Constructor that assigns specified contact list
        /// </summary>
        /// <param name="contactList">Maximim count of items in list is 200.</param>
        public Project(List<Contact> contactList)
        {
            if (contactList.Count > 200)
            {
                throw new ArgumentException("Contact list is too big.");
            }
            else
            {
                ContactList = contactList;
            }
        }
    }
}
