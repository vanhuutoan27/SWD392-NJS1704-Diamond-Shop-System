namespace DiamonShop.Core.Models.auth
{
    public class SendMailRequest
    {
        public IEnumerable<string> ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
