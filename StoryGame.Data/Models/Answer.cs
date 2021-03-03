using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StoryGame.Data.Models
{
	[Table("Answer")]
	public class Answer
	{
		#region Properties

		/// <summary>
		/// Answer's ID
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Answer's description
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// ID of the question related with this answer
		/// </summary>
		public int QuestionId { get; set; }

		#endregion

	}
}
