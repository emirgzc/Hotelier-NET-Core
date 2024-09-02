using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
	public class AdminMailController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(AdminMailViewModel model)
		{
			MimeMessage mimeMessage = new MimeMessage();
			// (Mailin kim tarafından gönderildiği, gönderen mail adresi)
			MailboxAddress mailboxAddress = new MailboxAddress("HotelierAdmin", "muhammetkjkj@gmail.com");
			mimeMessage.From.Add(mailboxAddress);

			// (Mailin alıcısı, alıcı mail)
			MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
			mimeMessage.To.Add(mailboxAddressTo);

			//mesaj içeriği
			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = model.Body;
			mimeMessage.Body = bodyBuilder.ToMessageBody();

			mimeMessage.Subject = model.Subject;

			SmtpClient client = new SmtpClient();
			client.Connect("smtp.gmail.com", 587, false);
			client.Authenticate("muhammetkjkj@gmail.com", "zgzcmnckodcksgub");
			client.Send(mimeMessage);
			client.Disconnect(true);

			// Gönderilen mailin veritabanına kaydedilmesi

			return View();
		}
	}
}
