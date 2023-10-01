using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaAnalyis.Entities.Models
{
    [Table("FifaTweets")]
    public class Fifa
    {
        [Key]
        public int Id { get; set; }
        public string? TweetLanguage { get; set; }
        public DateTime Date { get; set; }
        public string? TweetSource { get; set; }
        public int? LenghtOfTweet { get; set; }
        public string? Tweet { get; set; }
        public int? Likes { get; set; }
        public int? ReTweet { get; set; }
        public string? HashTags { get; set; }
        public string? UserName { get; set; }
        public string? Location { get; set; }
        public int? FollowersCount { get; set; }
        public int? FriendsCount { get; set; }

    }
}
