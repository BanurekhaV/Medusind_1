//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Day3ModelFirstPrj
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Duration { get; set; }
        public string Cost { get; set; }
        public int StudentId { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
