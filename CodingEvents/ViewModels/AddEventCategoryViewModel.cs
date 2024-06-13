using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
	public class AddEventCategoryViewModel
	{
		[Required(ErrorMessage ="Please add an event category name")]
		[StringLength(20, MinimumLength =3, ErrorMessage ="Category name should be between 3-20 characters")]
		public string? Name { get; set; }
	}
}

