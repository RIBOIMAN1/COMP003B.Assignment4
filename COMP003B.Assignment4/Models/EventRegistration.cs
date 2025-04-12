using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment4.Models
{
	public class EventRegistration
	{
		[Required]
		[Display(Name = "Full Name")]
		public string FullName { get; set; }
		[Required]
		[EmailAddress]
		[Display(Name = "Email Address")]
		public string Email { get; set; }
		[Required]
		[Display(Name = "Event Code")]
		public string EventCode { get; set; }
		[Required]
		[Range(1, 10)]
		[Display(Name = "Number of Tickets")]
		public int Tickets { get; set; }
		[Display(Name = "Referral Code (Optional)")]
		public string ReferralCode { get; set; }
	}
}