using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

public class ArticlesController : Controller
{
	public IActionResult Index()
	{
		var articles = new List<Article>
		{
			new Article { Id = 1, Title = "Super Smash Bros. Melee", Summary = "Old but gold; travel back in time and see one of if not the most iconic fighting games of all time, and the very intricate legacy that followed and is continuing for over 20 years!"},
			new Article { Id = 2, Title = "Super Smash Bros. Ultimate", Summary = "Delve into the modern era of Smash Bros, the place where 'Everyone is Here!'"},
			new Article { Id = 3, Title = "Street Fighter 6", Summary = "Learn about one of the longest standing fighting game series to date, and how it still revolutionizes the fighting game space even today!"},
			new Article { Id = 4, Title = "Tekken 8", Summary = "One of the most boundary-pushing 3D fighting games of all time, Tekken 8 has an extensive history and playerbase!"},
			new Article { Id = 5, Title = "Dragon Ball FighterZ", Summary = "If you enjoy anime, then this very fast paced fighting game is just for you!"},
		};

		return View(articles);
	}

	public IActionResult Details(int id)
	{
		var article = new Article { Id = id, Title = $"Article {id}", Summary = "Detailed content coming soon." };
		return View(article);
	}
}