using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using QonaqWebApp.Models.ViewModel;
using System.Linq;

namespace QonaqWebApp.Controllers
{
    public class MenuController : Controller
    {
        public readonly IRepository<AppDetail> appDetailRepo;
        public readonly IRepository<MenuItemGroup> menuItemGroupRepo;

        public MenuController(IRepository<AppDetail> appDetailRepo,
                                IRepository<MenuItemGroup> menuItemGroupRepo)
        {
            this.appDetailRepo = appDetailRepo;
            this.menuItemGroupRepo = menuItemGroupRepo;
        }

        public IActionResult Index()
        {
            MenuVM menuVM = new MenuVM(appDetailRepo.GetAll(x => x.Id == 10).ToList(), menuItemGroupRepo.GetAll().Include(x => x.menuItems).Where(x => x.menuItems.Any()).ToList());
            return View(menuVM);
        }
    }
}
