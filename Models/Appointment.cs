using System;

namespace ToDoAPI.Models
{
    public class Appointment
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string With { get; set; }
    }
}