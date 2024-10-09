//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------

using Microsoft.EntityFrameworkCore;
using School.Api.Models.Foundations.Groups;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Group> Groups { get; set; }

        public async ValueTask<Group> InsertGroupAsync(Group group) =>
           await InsertAsync(group);

        public IQueryable<Group> SelectAllGroups() =>
            SelectAll<Group>().AsQueryable();

        public async ValueTask<Group> SelectGroupByIdAsync(Guid groupId) =>
           await SelectAsync<Group>(groupId);

        public async ValueTask<Group> UpdateGroupAsync(Group group) =>
           await UpdateAsync(group);

        public async ValueTask<Group> DeleteGroupAsync(Group group) =>
           await DeleteAsync(group);
    }
}
