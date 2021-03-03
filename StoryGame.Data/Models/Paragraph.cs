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
		/// Paragraph's ID
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Paragraph's number
		/// </summary>
		[Range(1, int.MaxValue, ErrorMessage = "New number required")]
		public int Number { get; set; }

		/// <summary>
		/// Paragraph's title
		/// </summary>
		[Required(AllowEmptyStrings = false, ErrorMessage = "Title required")]
		public string Title { get; set; }

		/// <summary>
		/// Paragraph's description
		/// </summary>
		[Required(AllowEmptyStrings = false, ErrorMessage = "Description required")]
		public string Description { get; set; }

		/// <summary>
		/// Question related to the paragraph
		/// </summary>
		public Question RelatedQuestion { get; set; }

		#endregion
	}
}

