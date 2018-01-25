using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewFinder.Models
{
    [Table("Contacts")]
    public class Contact
    {
        public Contact(string contactEmail, string contactEmailHash, string contactTwitter, string contactPhone, string contactFullName, 
                       string contactAgeRange, string contactGender, string contactLocation, string contactTitle, string contactOrganization, 
                      string contactLinkedIn, string contactFacebook, string contactBio, string contactAvatar, string contactWebsite, int contactId)
        {
            contactId = id;
            contactEmail = Email;
            contactEmailHash = EmailHash;
            contactTwitter = Twitter;
            contactPhone = PhoneNumber;
            contactFullName = Name;
            contactAgeRange = AgeRange;
            contactGender = Gender;
            contactLocation = Location;
            contactTitle = JobTitle;
            contactOrganization = Organization;
            contactLinkedIn = LinkedIn;
            contactFacebook = Facebook;

        }

        public Contact()
        {
            
        }

        [Key]
        public int id { get; set; }
		public string Email { get; set; }
		public string EmailHash { get; set; }
        public string Twitter { get; set; }
		public string PhoneNumber { get; set; }
		public string Name { get; set; }
		public string AgeRange { get; set; }
		public string Gender { get; set; }
		public string Location { get; set; }
		public string JobTitle { get; set; }
		public string Organization { get; set; }
		public string LinkedIn { get; set; }
		public string Facebook { get; set; }
    }
    //public static List<Contact> GetContacts() 
    //{
    //    //var client = new RestClient("")
    //}
}