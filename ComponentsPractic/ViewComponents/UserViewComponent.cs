using ComponentsPractic.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComponentsPractic.ViewComponents
{
	public class UserViewComponent: ViewComponent
	{
		public IViewComponentResult Invoke(User user)
		{


			
			var users = new List<User>
			{
				new User { Name = "Tom", Score = 156 },
				new User { Name = "Bob", Score = 315 },
				new User { Name = "Anna", Score = 250 },
				new User { Name = "Dave", Score = 98 },
				new User { Name = "Eva", Score = 164 },
			
			};
			var topGamers = users.OrderByDescending(u => u.Score).Take(3).ToList();

			return View(topGamers);
		}	
	}
}
