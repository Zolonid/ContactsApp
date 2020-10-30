using System;
using System.Collections.Generic;

namespace ContactsApp
{
    public class Project
    {
        /// <summary>
        /// List of contacts (up to 200) for serialization
        /// </summary>
        public List<Contact> ContactList { get; set; }

        /// <summary>
        /// Contructor
        /// </summary>
        public Project()
        {
            ContactList = new List<Contact>(200);
        }
    }
}
