namespace SocialMediaAnalyis.Shared.DataTransferObjects
{
    public record SocialUsersDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string Interests { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}
