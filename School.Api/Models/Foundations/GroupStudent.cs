//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Models.Foundations.Groups;
using School.Api.Models.Foundations.Students;
using System.Collections.Generic;

namespace School.Api.Models.Foundations
{
    public class GroupStudent
    {
        public Group Group { get; set; }
        public List<Student> Students { get; set; }
    }
}
