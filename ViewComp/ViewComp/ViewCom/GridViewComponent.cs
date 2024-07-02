using Microsoft.AspNetCore.Mvc;
using ViewComp.Models;

namespace ViewComp.ViewCom
{
    public class GridViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid)
        {
            
            return View(grid); //invokes a partial Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
