using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using TodoModule.Todos;
using Abp.Web.Mvc.Controllers;
using System.Web.Mvc;

namespace TodoModule.Web.Controllers
{
    public class TodosController : AbpController
    {
        private readonly ITodoAppService _todoAppService;

        public TodosController(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _todoAppService.GetAll(
                new PagedAndSortedResultRequestDto()
            );

            return View(output);
        }
    }
}
