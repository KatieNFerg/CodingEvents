using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
	public class AddEventViewModel
	{
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string? Description { get; set; }

		[EmailAddress]
		public string? ContactEmail { get; set; }

        [Required(ErrorMessage = "Location information is required.")]
        public string? Location {get; set; }

        [Required(ErrorMessage = "Please enter the number of attendees")]
        [StringLength(100000, ErrorMessage = "Any number between 0 and 100,000")]
        public string? NumberOfAttendees {get; set; }
	}
}
