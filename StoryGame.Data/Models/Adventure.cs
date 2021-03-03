using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryGame.Data.Models
{
	[Table("Adventure")]
	public class Adventure
	{
		#region Properties

		/// <summary>
		/// Adventure's ID
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Adventure's title
		/// </summary>
		[Required(AllowEmptyStrings = false, ErrorMessage = "Title required")]
		public string Title { get; set; }

		#endregion
	}
}

