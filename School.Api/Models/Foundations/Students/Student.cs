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
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
    }
}
