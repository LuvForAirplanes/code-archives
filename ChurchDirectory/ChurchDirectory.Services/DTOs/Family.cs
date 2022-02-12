using ChurchDirectory.DbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChurchDirectory.Services.DTOs
{
    public class Family
    {
        public string Id { get; set; }

        public string RecordNumber { get; set; }

        public string FamilyName
        {
            get
            {
                if (Spouse == null)
                {
                    var fathersName = Regex.Match(FirstName, @"(\w)+").Value.ToLower();
                    fathersName = fathersName.First().ToString().ToUpper() + fathersName.Substring(1);

                    var lastName = LastName.ToLower();
                    lastName = lastName.First().ToString().ToUpper() + lastName.Substring(1);

                    return fathersName + " " + lastName;
                }
                else
                {
                    var fathersName = Regex.Match(FirstName, @"(\w)+").Value.ToLower();
                    fathersName = fathersName.First().ToString().ToUpper() + fathersName.Substring(1);

                    var motherName = Regex.Match(Spouse, @"(\w)+").Value.ToLower();
                    motherName = motherName.First().ToString().ToUpper() + motherName.Substring(1);

                    var lastName = LastName.ToLower();
                    lastName = lastName.First().ToString().ToUpper() + lastName.Substring(1);

                    return fathersName + " & " + motherName + " " + lastName;
                }
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ParentId { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? DeathDate { get; set; }

        public DateTime? MarriedDate { get; set; }

        public string Spouse { get; set; }

        public string SpouseId { get; set; }

        public DateTime? SpouseBirthDate { get; set; }

        public DateTime? SpouseDeathDate { get; set; }

        public string Line1 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Member { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Comment1 { get; set; }

        public string Comment2 { get; set; }

        public string SearchFamily
        {
            get
            {
                string search = FamilyName.ToLower() + " " + Line1.ToLower() + " " + City.ToLower() + " " + State.ToLower() + " " + Zip.ToLower() + " " + MarriedDate.Value.Date.ToShortDateString().ToString();
                return search;
            }
        }

        public List<Child> Children { get; set; } = new List<Child>();
    }
}
