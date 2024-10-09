//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Models.Foundations.Groups;
using System;

namespace School.Api.Models.Foundations.Students
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
