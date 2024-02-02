﻿using System.Collections.Generic;
namespace College
{
    /// <summary>
    /// Represent Student
    /// </summary>
    public class Student
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public List<Examination>? examinations { get; set; }
    }

}
