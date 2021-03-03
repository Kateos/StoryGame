using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryGame.Data.Models
{
	[Table("Question")]
	public class Question
	{
		#region Properties

		/// <summary>
		/// Question's ID
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Question's title
		/// </summary>
		[Required(AllowEmptyStrings = false, ErrorMessage = "Title required")]
		public string Title { get; set; }

		/// <summary>
		/// Paragraph's ID related to this question
		/// </summary>
		public int ParagraphId { get; set; }

		/// <summary>
		/// Possible answers to this question
		/// </summary>
		public List<Answer> Answers { get; set; }

		#endregion
	}
}

