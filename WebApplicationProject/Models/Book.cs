using System;

namespace WebApplicationProject.Models
{
    public class Book
    {
        public string bookName { get; set; }
        public string author { get; set; }
        public int pageNumber { get; set; }
        public DateTime dueDate { get; set; }
        public TimeSpan remainingTime { get; set; }
    }
}


