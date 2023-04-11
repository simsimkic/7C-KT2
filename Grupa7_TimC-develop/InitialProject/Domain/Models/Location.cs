using InitialProject.Domain.Models;
using InitialProject.Repositories;
using InitialProject.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.Domain.Models
{
    public class Location : ISerializable
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Location() { }

        public Location(int id, string country, string city)
        {
            Id = id;
            Country = country;
            City = city;
        }
        public string[] ToCSV()
        {
            string[] csvValues =
            {
                Id.ToString(),
                Country,
                City
            };
            return csvValues;
        }

        public void FromCSV(string[] values)
        {
            Id = Convert.ToInt32(values[0]);
            Country = values[1];
            City = values[2];
        }
    }
}
