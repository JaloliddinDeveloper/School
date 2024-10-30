// Services/Orcestrations/OrcestrationService.cs
using School.Api.Models.Foundations;
using School.Api.Services.Foundations.Groups;
using School.Api.Services.Foundations.Students;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Services.Orcestrations
{
    public class OrcestrationService : IOrcestrationService
    {
        private readonly IGroupService groupService;
        private readonly IStudentService studentService;

        public OrcestrationService(
            IGroupService groupService,
            IStudentService studentService)
        {
            this.groupService = groupService;
            this.studentService = studentService;
        }

        public async ValueTask<IQueryable<GroupStudent>> RetrieveAllGroupsWithStudentsAsync()
        {
            // Fetch all groups and students separately
            var groups = (await this.groupService.RetrieveAllGroupsAsync()).ToList();
            var students = (await this.studentService.RetrieveAllStudentsAsync()).ToList();

            // Link students to their respective groups in memory
            var groupStudents = groups.Select(group => new GroupStudent
            {
                Group = group,
                Students = students.Where(student => student.GroupId == group.Id).ToList()
            });

            return groupStudents.AsQueryable();
        }
    }
}
