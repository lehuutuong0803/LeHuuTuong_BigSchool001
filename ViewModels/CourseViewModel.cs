using LeHuuTuong_BigSchool001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeHuuTuong_BigSchool001.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            string dateString = Date +" "+Time;
            DateTime date3 = DateTime.ParseExact(dateString, @"d/M/yyyy HH:mm",
                System.Globalization.CultureInfo.InvariantCulture);

            return date3;
        }
    }
}