using GZCTF.Middlewares;
using GZCTF.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace GZCTF.Controllers;

/// <summary>
/// 练习相关接口
/// </summary>
[RequireUser]
[ApiController]
[Route("api/[controller]")]
[ProducesResponseType(typeof(RequestResponse), StatusCodes.Status401Unauthorized)]
[ProducesResponseType(typeof(RequestResponse), StatusCodes.Status403Forbidden)]
public class ExerciseController(
    ILogger<ExerciseController> logger,
    IExerciseInstanceRepository exerciseInstanceRepository,
    IStringLocalizer<Program> localizer) : ControllerBase
{
}