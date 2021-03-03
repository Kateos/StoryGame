using Microsoft.EntityFrameworkCore;
using System;

namespace StoryGame.Data
{
	public class DefaultContext: DbContext
	{
		
		public DefaultContext(DbContextOptions<DefaultContext> options): base(options)
		{

		}

		//protected DefaultContext()
		//{

		//}

		#region Properties

		public DbSet<Models.Adventure> Adventures { get; set; }
		public DbSet<Models.Paragraph> Paragraphs { get; set; }
		public DbSet<Models.Question> Questions { get; set; }
		public DbSet<Models.Answer> Answers { get; set; }

		#endregion

	}
}
