using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DTO
{
    public class Customer
    {
        public Customer(string id, string name, DateTime dayOfBirth, string telephone, string email, int gender, string identifyCard)
        {
            this.Id = id;
            this.Name = name;
            this.DayOfBirth = dayOfBirth;
            this.Telephone = telephone;
            this.Email = email;
            this.Gender = gender;
            this.IdentifyCard = identifyCard;
        }

        public Customer(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Name = row["name"].ToString();
            this.DayOfBirth = (DateTime)row["dayofBirth"];
            this.Telephone = row["telephone"].ToString();
            this.Email = row["email"].ToString();
            this.Gender = (int)row["gender"];
            this.IdentifyCard = row["identifyCard"].ToString();
        }

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime dayOfBirth;
        public DateTime DayOfBirth
        {
            get { return dayOfBirth; }
            set { dayOfBirth = value; }
        }

        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int gender;
        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string identifyCard;
        public string IdentifyCard
        {
            get { return identifyCard; }
            set { identifyCard = value; }
        }

    }
}
