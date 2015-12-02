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
		static generator()
		{
			companyParts = new[] { company_1, company_2, company_3, company_4 };
		}

		private static string[] firstnames = new[] { "Ada", "Alice", "Amanda", "Amy", "Andrea", "Angel", "Angelia", "Angelita", "Angie", "Augusta", "Avis", "Baker", "Banks", "Barnes", "Battle", "Beach", "Bennett", "Betty", "Black", "Bolton", "Bowen", "Bradley", "Brooks", "Bruce", "Bullock", "Bush", "Carmen", "Carroll", "Cassandra", "Cathryn", "Chambers", "Chavez", "Cheri", "Christi", "Cindy", "Cleveland", "Coleman", "Contreras", "Cooke", "Corinne", "Cox", "Craft", "Curry", "Dale", "Dana", "Daphne", "Davenport", "Deann", "Deanne", "Debbie", "Dena", "Dennis", "Diaz", "Dina", "Dixie", "Dolores", "Dora", "Doreen", "Dunlap", "Durham", "Elliott", "Eloise", "Elva", "English", "Erna", "Espinoza", "Estela", "Eva", "Ewing", "Faye", "Fern", "Florence", "Florine", "Franklin", "Frieda", "Frost", "Fulton", "Galloway", "Gamble", "Gardner", "Gena", "George", "Glass", "Glenda", "Goff", "Gonzalez", "Goodman", "Greene", "Gross", "Guadalupe", "Hardin", "Harrington", "Harrison", "Hawkins", "Hazel", "Heidi", "Henderson", "Hensley", "Herring", "Hilda", "Holland", "Hood", "Horton", "House", "Hughes", "Hull", "Hurst", "Ina", "Isabel", "Jaclyn", "Jami", "Janell", "Janie", "Jean", "Jeannette", "Jefferson", "Jenny", "Jessie", "Jewell", "Jo", "Jodi", "Johanna", "Joyce", "Judith", "Kathryn", "Keisha", "Keith", "Kelley", "Kennedy", "Kerri", "Kim", "Klein", "Kristi", "Kristie", "Kristin", "Kristina", "Lamb", "Lambert", "Lancaster", "Lane", "Lawrence", "Leola", "Lewis", "Lillian", "Lillie", "Lindsey", "Little", "Lloyd", "Loretta", "Lowe", "Lowery", "Luella", "Macias", "Mack", "Madge", "Mara", "Maria", "Marie", "Marilyn", "Marquez", "Maureen", "Mccray", "Mckay", "Mcmahon", "Mcneil", "Megan", "Melanie", "Melba", "Mendez", "Mercer", "Meredith", "Meyer", "Miles", "Millie", "Minerva", "Miranda", "Molina", "Moon", "Morin", "Mullen", "Muriel", "Myrtle", "Nadia", "Nancy", "Nelda", "Nicole", "Nielsen", "Noble", "Noemi", "Norma", "Ochoa", "Odom", "Odonnell", "Olive", "Ora", "Owens", "Pam", "Parker", "Patterson", "Patton", "Patty", "Paul", "Pauline", "Peck", "Pitts", "Polly", "Pratt", "Pruitt", "Pugh", "Rachelle", "Randall", "Randi", "Raquel", "Reba", "Reese", "Renee", "Reyna", "Rhonda", "Rios", "Rivera", "Robert", "Rojas", "Rose", "Rowland", "Sadie", "Sampson", "Sandra", "Sanford", "Savannah", "Selena", "Sellers", "Serena", "Sharpe", "Sheila", "Short", "Snyder", "Solis", "Sonja", "Sosa", "Spencer", "Stacie", "Stanley", "Stefanie", "Stone", "Susan", "Talley", "Tami", "Tamra", "Tania", "Tara", "Terrell", "Therese", "Thompson", "Tiffany", "Tina", "Tisha", "Todd", "Toni", "Tracy", "Tran", "Tricia", "Valeria", "Vance", "Vanessa", "Vasquez", "Velma", "Vivian", "Ward", "Ware", "Watkins", "Weiss", "Wells", "Wendy", "Whitney", "Witt", "Wood", "Woods", "Yolanda", "Zelma" };
		private static string[] lastnames = new[] { "Adams", "Adkins", "Aguilar", "Albert", "Alston", "Alvarado", "Alvarez", "Andrews", "Ayers", "Bailey", "Ball", "Barnett", "Barrera", "Barron", "Barry", "Beach", "Bell", "Bernard", "Best", "Bishop", "Blair", "Blake", "Blevins", "Bond", "Booth", "Bowen", "Boyd", "Boyer", "Boyle", "Brennan", "Briggs", "Britt", "Burgess", "Burnett", "Burns", "Burton", "Calhoun", "Camacho", "Cameron", "Cantrell", "Carney", "Carrillo", "Carroll", "Case", "Casey", "Castaneda", "Castro", "Chase", "Clark", "Clarke", "Clemons", "Cole", "Coleman", "Combs", "Conrad", "Contreras", "Copeland", "Cote", "Cox", "Craig", "Cross", "Cruz", "Cummings", "Curtis", "Dalton", "Dejesus", "Delaney", "Delgado", "Dennis", "Dodson", "Dorsey", "Douglas", "Dudley", "Duran", "Durham", "Dyer", "England", "Everett", "Ewing", "Farrell", "Faulkner", "Ferrell", "Floyd", "Fowler", "Francis", "Frazier", "Frederick", "Frost", "Gallegos", "Galloway", "Gamble", "Garza", "Gay", "Gentry", "Gibson", "Gilmore", "Glass", "Glenn", "Glover", "Gordon", "Green", "Greer", "Guthrie", "Hahn", "Haley", "Hamilton", "Hancock", "Harding", "Harris", "Hartman", "Harvey", "Hawkins", "Hayes", "Haynes", "Hebert", "Hendricks", "Herman", "Herrera", "Herring", "Hicks", "Holder", "Hood", "Hooper", "Hopkins", "Hopper", "House", "Howard", "Hubbard", "Huber", "Hudson", "Huffman", "Hurst", "Hutchinson", "Jacobs", "Jefferson", "Jennings", "Jimenez", "Johnson", "Juarez", "Kaufman", "Kent", "Kirby", "Kline", "Koch", "Lancaster", "Leblanc", "Lee", "Leon", "Lewis", "Logan", "Long", "Lowe", "Lynn", "Macias", "Maddox", "Marsh", "Marshall", "Martin", "Mason", "Massey", "Matthews", "Maynard", "Mcbride", "Mcclain", "Mcclure", "Mcconnell", "Mccoy", "Mccullough", "Mcfadden", "Mcgee", "Mcintosh", "Mcintyre", "Mckee", "Mcmahon", "Mcmillan", "Mendoza", "Mercado", "Meyers", "Montgomery", "Mooney", "Morgan", "Morris", "Morrison", "Morrow", "Mueller", "Mullins", "Munoz", "Nielsen", "Nolan", "Norton", "Obrien", "Oconnor", "Odonnell", "Oliver", "Osborne", "Owen", "Pace", "Palmer", "Payne", "Pennington", "Pittman", "Pitts", "Poole", "Pope", "Price", "Ramirez", "Reed", "Reese", "Reyes", "Richard", "Riddle", "Rios", "Rivera", "Robbins", "Robertson", "Robinson", "Robles", "Rocha", "Rodgers", "Rosa", "Rose", "Roth", "Rowe", "Rush", "Santos", "Sawyer", "Sellers", "Sharp", "Shaw", "Shepherd", "Singleton", "Skinner", "Sloan", "Sosa", "Soto", "Stafford", "Stanley", "Stark", "Steele", "Stein", "Stephens", "Stewart", "Stuart", "Sweeney", "Sykes", "Tate", "Thornton", "Tillman", "Vance", "Vaughn", "Velazquez", "Villarreal", "Vincent", "Vinson", "Wade", "Wall", "Walsh", "Waters", "Watts", "Weaver", "Webb", "Webster", "Weiss", "Wilkerson", "Wilkins", "Williamson", "Wolfe", "Wood", "Woodward", "Workman", "York", "Zamora" };

		//private string[] company_1 = new[] { "Initech", "Kineticut", "Power Drivers", "Ingenious","Nurali","Inventure","Premiant","Ceprene","Luxuria","Solgan","Rockabye","Slax","Cytrek","Exotechno","Zipak","Qot","Synkgen","Kyaguru","Rodemco","Asimiline","Ebidco","Podunk","Enteroflex","Xiix","Verbus","Nipaz","Biotica","Matrixity","Kaggle","Undertap","Extragene","Jamnation","Elentrix","Ovium","Spacewax","Comvene","Empirica","Stralum","Heliko","Kage","Idealis","Atomica","Geeknet","Emtrak","Exerta","Geekol","Infotrips","Locazone","Micronaut","Tourmania","Neocent","Zerbina","Calcula","Multiflex","Datagene","Comveyer","Schoolio","Netagy" };
		private static string[] company_1 = new[] { "Ini", "Kinet", "Pow", "Ingen", "Nur", "Invent", "Prem", "Ce", "Lux", "Sol", "Rock", "Sla", "Cy", "Exo", "Zi", "Synk", "Rod", "Ver", "Ni", "Bio", "Matri", "Under", "Extra", "Jam", "Elen", "Space", "Emp", "Com", "Stra", "Geek", "Em", "Data", "Po", "Multi", "Net", "Calc", "Zerb"  };
		private static string[] company_2 = new[] { "tech", "icut", "ious", "ture", "iant", "prene", "ure", "uria", "gan", "bye", "trek", "techno", "pak", "gen", "guru", "emco", "line", "co", "dunk", "flex", "bus", "itas", "tica", "paz", "xity", "tap", "gene", "nation", "trix", "wax", "vene", "irica", "lum", "iko", "ica", "ula", "ina" };
		private static string[] company_3 = new[] { "Enterprises", "Company", "Solutions", "Industries" };
		private static string[] company_4 = new[] { "Inc", "LLC", "" };
		private static string[][] companyParts;

		Random _Random;

		public string firstName()
		{
			return random(firstnames);
		}
		public string surName()
		{
			return random(lastnames);
		}
		public string company(int length = 3)
		{
			if(length <= 1)
				return random(company_1) + random(company_2);
			else
			{
				//bounds
				if(length > 4) length = 4;

				StringBuilder sb = new StringBuilder();
				
				//if(_Random.Next(1)==0)
				//	sb.Append(this.surName());
				//else
				sb.Append(random(companyParts[0]))
					.Append(random(companyParts[1]));

				for(int i = 1; i < length-1; i++)
				{
					string part = random(companyParts[i+1]);
					if(part != "") sb.Append(" ").Append(part);
				}

				return sb.ToString();
			}
		}

		private int _index = -1;
		public int index()
		{
			System.Threading.Interlocked.Add(ref _index, 1);
			return _index++;
		}

		public Guid guid()
		{
			return Guid.NewGuid();
		}


		/// <summary>
		/// Returns a random string from the given array of strings
		/// </summary>
		/// <param name="items"></param>
		/// <returns></returns>
		public string random(params string[] items)
		{
			if(items == null || items.Length == 0) return "";
			int randomIndex = _Random.Next(items.Length);
			return items[randomIndex];
		}
		/// <summary>
		/// Returns a random integer from the given array of integers
		/// </summary>
		/// <param name="items"></param>
		/// <returns></returns>
		public int random(params int[] items)
		{
			if(items == null || items.Length == 0) return default(int);
			int randomIndex = _Random.Next(items.Length);
			return items[randomIndex];
		}
		/// <summary>
		/// Returns a random item T from the given array of items T
		/// </summary>
		/// <param name="items">an array of items of <typeparam name="T" /></param>
		/// <returns>a randomly selected item <typeparam name="T" /></returns>
		public T random<T>(params T[] items) 
		{
			if(items == null || items.Length == 0) return default(T);
			int randomIndex = _Random.Next(items.Length);
			return items[randomIndex];
		}

		public string random(int max)
		{
			return _Random.Next(max).ToString();
		}
		public string random(int min, int max)
		{
			return _Random.Next(min, max).ToString();
		}

		/// <summary>
		/// Returns date in a range between the dates (specified as a string)
		/// </summary>
		/// <param name="min">minimum date (as a string)</param>
		/// <param name="max">maximum date (as a string)</param>
		/// <returns>DateTime</returns>
		public DateTime date(string min = null, string max = null)
		{
			DateTime? mindate = min != null ? DateTime.Parse(min) : (DateTime?)null;
			DateTime? maxdate = max != null ? DateTime.Parse(max) : (DateTime?)null;
			
			return date(mindate, maxdate);
		}

		/// <summary>
		/// Returns date between the range specified by min and max
		/// </summary>
		/// <param name="min">minimum of the range</param>
		/// <param name="max">maximum of the range</param>
		/// <returns>DateTime</returns>
		public DateTime date(DateTime? min = null, DateTime? max = null)
		{
			if(min == null) min = new DateTime(1970, 1, 1);
			if(max == null) max = DateTime.Now.AddYears(1000);

			TimeSpan tspan = max.Value - min.Value;

			int randomDaysFromMin = _Random.Next(tspan.Days);

			return min.Value.AddDays(randomDaysFromMin);
		}

		/// <summary>
		/// Returns an integer between the range specified by min and max
		/// </summary>
		/// <param name="min">minimum of the range</param>
		/// <param name="max">maximum of the range</param>
		/// <returns>integer</returns>
		public int integer(int min, int max)
		{
			return _Random.Next(min, max);
		}
		/// <summary>
		/// Returns an integer between 0 and max.
		/// </summary>
		/// <param name="max">maximum of the range</param>
		/// <returns>integer</returns>
		public int integer(int max)
		{
			return integer(0, max);
		}

	}

}
