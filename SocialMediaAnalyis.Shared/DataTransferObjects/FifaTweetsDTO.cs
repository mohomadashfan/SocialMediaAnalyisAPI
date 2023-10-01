namespace SocialMediaAnalyis.Shared.DataTransferObjects
{
    public record FifaTweetsDTO
    {
        public int Id { get; set; }
        public string? Language { get; set; }
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


public class FifaHashTagCount
{
    public int Count { get; set; }
    public string HasTag { get; set; }
}
public class FifaTweetSourceCountDTO
{
    public int Count { get; set; }
    public string TweetSource { get; set; }
}

public class FifaTweetLanguageCountDTO
{
    public int Count { get; set; }
    public string TweetLanguage { get; set; }
}

public class FollowersCountDTO1
{
    public long? Followers { get; set; }
}
public class TotalLikesDTO
{
    public int? Likes { get; set; }
}
public class TweetCountryDTO
{
    public int Count { get; set; }
    public string CountryName { get; set; }
}

public class TweetsCountDTO
{
    public int? Retweet { get; set; }
}


