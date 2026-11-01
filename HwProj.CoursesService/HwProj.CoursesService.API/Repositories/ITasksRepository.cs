using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HwProj.CoursesService.API.Models;
using HwProj.Models.CoursesService.ViewModels;
using HwProj.Repositories.Net8;

namespace HwProj.CoursesService.API.Repositories
{
    public interface ITasksRepository : ICrudRepository<HomeworkTask, long>
    {
        Task<HomeworkTask> GetWithHomeworkAsync(long id);
        Task<long?> GetCourseIdAsync(long id);
        Task<CourseSummaryDTO?> GetCourseSummaryByTaskAsync(long id);
        Task UpdateAsync(long id, Expression<Func<HomeworkTask, HomeworkTask>> updateFunc, List<Criterion> criteria);
        Task<HomeworkTask> GetWithHomeworkAndCriteriaAsync(long id);
    }
}
