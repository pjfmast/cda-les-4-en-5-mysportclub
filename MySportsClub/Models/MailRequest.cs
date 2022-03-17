namespace MySportsClub.Models
{
    // todo lesson 6-02: data for MailRequest
    public class MailRequest
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public List<IFormFile> Attachments { get; set; }
    }
}
