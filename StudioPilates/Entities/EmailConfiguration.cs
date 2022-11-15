namespace StudioPilates.Entities
{
    public class EmailConfiguration
    {
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Password { get; set; }
        public string EmailServerAddress { get; set; }
        public string EmailServerPort { get; set; }
        public bool UserSsl { get; set; }
    }
}
