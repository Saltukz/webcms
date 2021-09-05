using System;
using System.Collections.Generic;
using System.Text;

namespace entity
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public int Kampanya { get; set; }

        public DateTime Tarih { get; set; }
    }
}
