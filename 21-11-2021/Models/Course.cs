using System;
using Microsoft.AspNetCore.Http;

namespace _21_11_2021.Models
{
    public class Course
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int Continious { get; set; }
        public CourseStatus Status  { get; set; }

        public bool IsAvailableToWatch()
        {
            return Status == CourseStatus.Recruiting || Status == CourseStatus.InProgress;
        }
        
        

    }
}