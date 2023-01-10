﻿
namespace Task1Candidates
{
    public class Address
    {
        const int MAX_APPARTMENT = 120;
        private int _appartment;
        private int _house;
        public string City { get; set; }
        public string Street { get; set; }
        public int House { 
            get
            {
                return _house;
            }

            set
            { 
                if (value > 0)
                {
                    _house = value;
                }
            }
        }
        public int Appartment
        {
            get
            {
                return _appartment;
            }

            set
            {
                if (value <= MAX_APPARTMENT)
                {
                    _appartment = value;
                }
            }
        }

        public Address (string city, string street, int house, int appartment)
        {
            City = city;
            Street = street;
            House = house;
            Appartment = appartment;
        }
    }
}
