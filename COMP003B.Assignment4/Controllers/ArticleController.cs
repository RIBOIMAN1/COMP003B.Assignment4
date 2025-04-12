using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

public class ArticlesController : Controller
{
	public IActionResult Index()
	{
		var articles = new List<Article>
		{
			new Article {
				Id = 1,
				Title = "Super Smash Bros. Melee",
				Summary = "Old but gold; travel back in time and see one of if not the most iconic fighting games of all time, and the very intricate legacy that followed and is continuing for over 20 years!",
				VideoUrl = "https://www.youtube.com/watch?v=-3HiXYdFz38&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N"
			},
			new Article {
				Id = 2,
				Title = "Super Smash Bros. Ultimate",
				Summary = "Delve into the modern era of Smash Bros, the place where 'Everyone is Here!'",
				VideoUrl = "https://www.youtube.com/watch?v=6r_YIdFxx_s&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=2"
			},
			new Article {
				Id = 3,
				Title = "Street Fighter 6",
				Summary = "Learn about one of the longest standing fighting game series to date, and how it still revolutionizes the fighting game space even today!",
				VideoUrl = "https://www.youtube.com/watch?v=icmEx7QQnFE&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=3"
			},
			new Article {
				Id = 4,
				Title = "Tekken 8",
				Summary = "One of the most boundary-pushing 3D fighting games of all time, Tekken 8 has an extensive history and playerbase!",
				VideoUrl = "https://www.youtube.com/watch?v=7_dlHgwAzcU&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=4"
			},
			new Article {
				Id = 5,
				Title = "Dragon Ball FighterZ",
				Summary = "If you enjoy anime, then this very fast paced fighting game featuring a plethora of Dragon Ball characters is just for you!",
				VideoUrl = "https://www.youtube.com/watch?v=TLxeYt_F1Kk&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=5"
			},
		};

		return View(articles);
	}

	public IActionResult Details(int id)
	{
		var articles = new List<Article>
		{
			new Article {
				Id = 1,
				Title = "Super Smash Bros. Melee",
				Summary = "Old but gold; travel back in time and see one of if not the most iconic fighting games of all time, and the very intricate legacy that followed and is continuing for over 20 years!",
				VideoUrl = "https://www.youtube.com/watch?v=-3HiXYdFz38&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N"
			},
			new Article {
				Id = 2,
				Title = "Super Smash Bros. Ultimate",
				Summary = "Delve into the modern era of Smash Bros, the place where 'Everyone is Here!'",
				VideoUrl = "https://www.youtube.com/watch?v=6r_YIdFxx_s&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=2"
			},
			new Article {
				Id = 3,
				Title = "Street Fighter 6",
				Summary = "Learn about one of the longest standing fighting game series to date, and how it still revolutionizes the fighting game space even today!",
				VideoUrl = "https://www.youtube.com/watch?v=icmEx7QQnFE&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=3"
			},
			new Article {
				Id = 4,
				Title = "Tekken 8",
				Summary = "One of the most boundary-pushing 3D fighting games of all time, Tekken 8 has an extensive history and playerbase!",
				VideoUrl = "https://www.youtube.com/watch?v=7_dlHgwAzcU&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=4"
			},
			new Article {
				Id = 5,
				Title = "Dragon Ball FighterZ",
				Summary = "If you enjoy anime, then this very fast paced fighting game featuring a plethora of Dragon Ball characters is just for you!",
				VideoUrl = "https://www.youtube.com/watch?v=TLxeYt_F1Kk&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=5"
			},
		};
		var article = articles.FirstOrDefault(a => a.Id == id);
		if (article == null)
		{
			article = new Article { Id = id, Title = $"Article {id}", Summary = "These fighting games have a very extensive story behind them. Click to learn more:" };
		}

		return View(article);
	}
	public IActionResult Search(string keyword)
	{
		var allArticles = new List<Article>
		{
			new Article {
				Id = 1,
				Title = "Super Smash Bros. Melee",
				Summary = "Old but gold; travel back in time and see one of if not the most iconic fighting games of all time, and the very intricate legacy that followed and is continuing for over 20 years!",
				VideoUrl = "https://www.youtube.com/watch?v=-3HiXYdFz38&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N"
			},
			new Article {
				Id = 2,
				Title = "Super Smash Bros. Ultimate",
				Summary = "Delve into the modern era of Smash Bros, the place where 'Everyone is Here!'",
				VideoUrl = "https://www.youtube.com/watch?v=6r_YIdFxx_s&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=2"
			},
			new Article {
				Id = 3,
				Title = "Street Fighter 6",
				Summary = "Learn about one of the longest standing fighting game series to date, and how it still revolutionizes the fighting game space even today!",
				VideoUrl = "https://www.youtube.com/watch?v=icmEx7QQnFE&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=3"
			},
			new Article {
				Id = 4,
				Title = "Tekken 8",
				Summary = "One of the most boundary-pushing 3D fighting games of all time, Tekken 8 has an extensive history and playerbase!",
				VideoUrl = "https://www.youtube.com/watch?v=7_dlHgwAzcU&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=4"
			},
			new Article {
				Id = 5,
				Title = "Dragon Ball FighterZ",
				Summary = "If you enjoy anime, then this very fast paced fighting game featuring a plethora of Dragon Ball characters is just for you!",
				VideoUrl = "https://www.youtube.com/watch?v=TLxeYt_F1Kk&list=PLQtYZ1umUDV1e-u77724W1nQrbsw7ha1N&index=5"
			},
		};
		if (string.IsNullOrEmpty(keyword))
		{
			return View(allArticles);
		}

		var filteredArticles = allArticles.Where(a =>
			a.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
			a.Summary.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

		return View(filteredArticles);
	}
}