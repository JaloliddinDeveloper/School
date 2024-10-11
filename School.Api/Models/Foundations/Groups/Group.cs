//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Models.Foundations.Students;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace School.Api.Models.Foundations.Groups
{
    public class Group
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        [JsonIgnore]
        public IEnumerable<Student> Students { get; set; }
    }
}
