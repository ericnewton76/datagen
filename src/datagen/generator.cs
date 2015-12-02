using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datagen
{
	public class generator
	{

		public generator(int seed)
		{
			_Random = new Random(seed);
		}
		public generator()
		{
			_Random = new Random();
		}

		private string[] firstnames = new[] { "Ada", "Alice", "Amanda", "Amy", "Andrea", "Angel", "Angelia", "Angelita", "Angie", "Augusta", "Avis", "Baker", "Banks", "Barnes", "Battle", "Beach", "Bennett", "Betty", "Black", "Bolton", "Bowen", "Bradley", "Brooks", "Bruce", "Bullock", "Bush", "Carmen", "Carroll", "Cassandra", "Cathryn", "Chambers", "Chavez", "Cheri", "Christi", "Cindy", "Cleveland", "Coleman", "Contreras", "Cooke", "Corinne", "Cox", "Craft", "Curry", "Dale", "Dana", "Daphne", "Davenport", "Deann", "Deanne", "Debbie", "Dena", "Dennis", "Diaz", "Dina", "Dixie", "Dolores", "Dora", "Doreen", "Dunlap", "Durham", "Elliott", "Eloise", "Elva", "English", "Erna", "Espinoza", "Estela", "Eva", "Ewing", "Faye", "Fern", "Florence", "Florine", "Franklin", "Frieda", "Frost", "Fulton", "Galloway", "Gamble", "Gardner", "Gena", "George", "Glass", "Glenda", "Goff", "Gonzalez", "Goodman", "Greene", "Gross", "Guadalupe", "Hardin", "Harrington", "Harrison", "Hawkins", "Hazel", "Heidi", "Henderson", "Hensley", "Herring", "Hilda", "Holland", "Hood", "Horton", "House", "Hughes", "Hull", "Hurst", "Ina", "Isabel", "Jaclyn", "Jami", "Janell", "Janie", "Jean", "Jeannette", "Jefferson", "Jenny", "Jessie", "Jewell", "Jo", "Jodi", "Johanna", "Joyce", "Judith", "Kathryn", "Keisha", "Keith", "Kelley", "Kennedy", "Kerri", "Kim", "Klein", "Kristi", "Kristie", "Kristin", "Kristina", "Lamb", "Lambert", "Lancaster", "Lane", "Lawrence", "Leola", "Lewis", "Lillian", "Lillie", "Lindsey", "Little", "Lloyd", "Loretta", "Lowe", "Lowery", "Luella", "Macias", "Mack", "Madge", "Mara", "Maria", "Marie", "Marilyn", "Marquez", "Maureen", "Mccray", "Mckay", "Mcmahon", "Mcneil", "Megan", "Melanie", "Melba", "Mendez", "Mercer", "Meredith", "Meyer", "Miles", "Millie", "Minerva", "Miranda", "Molina", "Moon", "Morin", "Mullen", "Muriel", "Myrtle", "Nadia", "Nancy", "Nelda", "Nicole", "Nielsen", "Noble", "Noemi", "Norma", "Ochoa", "Odom", "Odonnell", "Olive", "Ora", "Owens", "Pam", "Parker", "Patterson", "Patton", "Patty", "Paul", "Pauline", "Peck", "Pitts", "Polly", "Pratt", "Pruitt", "Pugh", "Rachelle", "Randall", "Randi", "Raquel", "Reba", "Reese", "Renee", "Reyna", "Rhonda", "Rios", "Rivera", "Robert", "Rojas", "Rose", "Rowland", "Sadie", "Sampson", "Sandra", "Sanford", "Savannah", "Selena", "Sellers", "Serena", "Sharpe", "Sheila", "Short", "Snyder", "Solis", "Sonja", "Sosa", "Spencer", "Stacie", "Stanley", "Stefanie", "Stone", "Susan", "Talley", "Tami", "Tamra", "Tania", "Tara", "Terrell", "Therese", "Thompson", "Tiffany", "Tina", "Tisha", "Todd", "Toni", "Tracy", "Tran", "Tricia", "Valeria", "Vance", "Vanessa", "Vasquez", "Velma", "Vivian", "Ward", "Ware", "Watkins", "Weiss", "Wells", "Wendy", "Whitney", "Witt", "Wood", "Woods", "Yolanda", "Zelma" };
		private string[] lastnames = new[] { "Adams", "Adkins", "Aguilar", "Albert", "Alston", "Alvarado", "Alvarez", "Andrews", "Ayers", "Bailey", "Ball", "Barnett", "Barrera", "Barron", "Barry", "Beach", "Bell", "Bernard", "Best", "Bishop", "Blair", "Blake", "Blevins", "Bond", "Booth", "Bowen", "Boyd", "Boyer", "Boyle", "Brennan", "Briggs", "Britt", "Burgess", "Burnett", "Burns", "Burton", "Calhoun", "Camacho", "Cameron", "Cantrell", "Carney", "Carrillo", "Carroll", "Case", "Casey", "Castaneda", "Castro", "Chase", "Clark", "Clarke", "Clemons", "Cole", "Coleman", "Combs", "Conrad", "Contreras", "Copeland", "Cote", "Cox", "Craig", "Cross", "Cruz", "Cummings", "Curtis", "Dalton", "Dejesus", "Delaney", "Delgado", "Dennis", "Dodson", "Dorsey", "Douglas", "Dudley", "Duran", "Durham", "Dyer", "England", "Everett", "Ewing", "Farrell", "Faulkner", "Ferrell", "Floyd", "Fowler", "Francis", "Frazier", "Frederick", "Frost", "Gallegos", "Galloway", "Gamble", "Garza", "Gay", "Gentry", "Gibson", "Gilmore", "Glass", "Glenn", "Glover", "Gordon", "Green", "Greer", "Guthrie", "Hahn", "Haley", "Hamilton", "Hancock", "Harding", "Harris", "Hartman", "Harvey", "Hawkins", "Hayes", "Haynes", "Hebert", "Hendricks", "Herman", "Herrera", "Herring", "Hicks", "Holder", "Hood", "Hooper", "Hopkins", "Hopper", "House", "Howard", "Hubbard", "Huber", "Hudson", "Huffman", "Hurst", "Hutchinson", "Jacobs", "Jefferson", "Jennings", "Jimenez", "Johnson", "Juarez", "Kaufman", "Kent", "Kirby", "Kline", "Koch", "Lancaster", "Leblanc", "Lee", "Leon", "Lewis", "Logan", "Long", "Lowe", "Lynn", "Macias", "Maddox", "Marsh", "Marshall", "Martin", "Mason", "Massey", "Matthews", "Maynard", "Mcbride", "Mcclain", "Mcclure", "Mcconnell", "Mccoy", "Mccullough", "Mcfadden", "Mcgee", "Mcintosh", "Mcintyre", "Mckee", "Mcmahon", "Mcmillan", "Mendoza", "Mercado", "Meyers", "Montgomery", "Mooney", "Morgan", "Morris", "Morrison", "Morrow", "Mueller", "Mullins", "Munoz", "Nielsen", "Nolan", "Norton", "Obrien", "Oconnor", "Odonnell", "Oliver", "Osborne", "Owen", "Pace", "Palmer", "Payne", "Pennington", "Pittman", "Pitts", "Poole", "Pope", "Price", "Ramirez", "Reed", "Reese", "Reyes", "Richard", "Riddle", "Rios", "Rivera", "Robbins", "Robertson", "Robinson", "Robles", "Rocha", "Rodgers", "Rosa", "Rose", "Roth", "Rowe", "Rush", "Santos", "Sawyer", "Sellers", "Sharp", "Shaw", "Shepherd", "Singleton", "Skinner", "Sloan", "Sosa", "Soto", "Stafford", "Stanley", "Stark", "Steele", "Stein", "Stephens", "Stewart", "Stuart", "Sweeney", "Sykes", "Tate", "Thornton", "Tillman", "Vance", "Vaughn", "Velazquez", "Villarreal", "Vincent", "Vinson", "Wade", "Wall", "Walsh", "Waters", "Watts", "Weaver", "Webb", "Webster", "Weiss", "Wilkerson", "Wilkins", "Williamson", "Wolfe", "Wood", "Woodward", "Workman", "York", "Zamora" };

		Random _Random;

		public string firstName()
		{
			return random(firstnames);
		}
		public string surName()
		{
			return random(lastnames);
		}

		private int _index = -1;
		public int index()
		{
			System.Threading.Interlocked.Add(ref _index, 1);
			return _index++;
		}

		public string random(params string[] items)
		{
			if(items == null || items.Length == 0) return "";
			return items[_Random.Next(items.Length - 1)];
		}

		public string random(int max)
		{
			return _Random.Next(max).ToString();
		}
		public string random(int min, int max)
		{
			return _Random.Next(min, max).ToString();
		}

		//public string date(string min, string max)
		//{
		//	throw new NotImplementedException();
		//}

		public DateTime date(DateTime? min = null, DateTime? max = null)
		{
			if(min == null) min = new DateTime(1970, 1, 1);
			if(max == null) max = DateTime.Now.AddYears(1000);

			TimeSpan tspan = max.Value - min.Value;

			int randomDaysFromMin = _Random.Next(tspan.Days);

			return min.Value.AddDays(randomDaysFromMin);
		}

		public int integer(int min, int max)
		{
			return _Random.Next(min, max);
		}
	}

}
