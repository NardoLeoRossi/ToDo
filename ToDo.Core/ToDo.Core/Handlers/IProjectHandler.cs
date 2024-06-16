using ToDo.Core.Models;
using ToDo.Core.Requests.Projects;
using ToDo.Core.Responses;

namespace ToDo.Core.Handlers;

public interface IProjectHandler
{
    Task<Response<Project?>> CreateAsync(CreateProjectRequest request);
}
