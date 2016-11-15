using System.Collections.Generic;

namespace JobBoard.Objects
{
    public class JobOpening
    {
        private string _title;
        private string _description;
        private ContactInfo _contact;
        private static List<JobOpening> _instances = new List<JobOpening> {};

        public JobOpening(string jobTitle, string jobDescription)
        {
            _title = jobTitle;
            _description = jobDescription;
        }

        public void SetTitle(string jobTitle)
        {
            _title = jobTitle;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetDescription(string jobDescription)
        {
            _description = jobDescription;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetContact(ContactInfo contact)
        {
            _contact = contact;
        }

        public ContactInfo GetContact()
        {
            return _contact;
        }

        public void Save()
        {
            _instances.Add(this);
        }

        public static List<JobOpening> GetAll()
        {
            return _instances;
        }
    }
}
