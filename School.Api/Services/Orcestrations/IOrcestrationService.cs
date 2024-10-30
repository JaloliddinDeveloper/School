//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using School.Api.Models.Foundations;
using School.Api.Models.Foundations.Groups;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Services.Orcestrations
{
    public interface IOrcestrationService
    {
        ValueTask<IQueryable<GroupStudent>> RetrieveAllGroupsWithStudentsAsync();
    }
}
