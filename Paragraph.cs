using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryGame.Data.Models
{
	[Table("Paragraph")]
	public class Paragraph
	{
		#region Properties

		/// <summary>
		/// Adventure's ID
		/// </summary>
		public int id { get; set; }

		/// <summary>
		/// Adventure's title
		/// </summary>
		[Required(AllowEmptyStrings = false, ErrorMessage = "Title required")]
		public string title { get; set; }

		#endregion

	}
}

