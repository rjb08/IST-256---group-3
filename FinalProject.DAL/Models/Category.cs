namespace FinalProject.DAL.Models
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public string ImageName 
		{ 
			get
			{
				return $"/images/{CategoryName.Replace("/", "").Replace(" ", "")}.webp";
			}
		}

	}
}
