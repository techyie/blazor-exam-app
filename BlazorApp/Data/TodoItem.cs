using BlazorApp.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
	public class TodoItem
	{
		public int ID { get; set; }

		[Required]
		[StringLength(100)]
		[MinLength(5)]
		public string? Title { get; set; }
		[Required]
		[StringLength(300)]
		public string? Description { get; set; }
		public string? Status { get; set; }
		public string? DateAdded { get; set; }
		public string? DateUpdated { get; set; }
		public string UUID { get; set; }

	}
}
