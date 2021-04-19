using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HudanSpace.Models
{
    public class Course
    {
        //Property
        public string _CourseName;
        public string _CourseLevel;
        public string _CourseRating;

        //definisi property
        [Key]
        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }
        public string CourseLevel
        {
            get { return _CourseLevel; }
            set { _CourseLevel = value; }
        }
        public string CourseRating
        {
            get { return _CourseRating; }
            set { _CourseRating = value; }
        }
    }
}


