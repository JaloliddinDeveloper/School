//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.EntityFrameworkCore;
using School.Api.Models.Foundations.Groups;

namespace School.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Group> Groups { get; set; }
    }
}
