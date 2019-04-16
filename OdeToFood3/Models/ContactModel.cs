using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood2.Models
{
    public class ContactModel
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
    }
}