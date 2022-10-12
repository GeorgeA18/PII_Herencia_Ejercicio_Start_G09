using System;
using TwitterUCU;

namespace RideShare;

public class ConductorPool : User, IConductor
{
    string Name { get; set; }
    string LastName { get; set; }
    string CI { get; set; }
    public Rating Rating { get; set; }
    string Password { get; set; }
    public string Vehicle { get; set; }
    public string Bio { get; set; }
    public int MaxPassenger {get;set;}

    public ConductorPool(string name, string lastName, string ci, string vehicle, string password, string bio, int maxPassenger)
    {
        this.Name = name;
        this.LastName = lastName;
        this.CI = ci;
        this.Password = password;
        this.Vehicle = vehicle;
        this.Bio = bio;
        this.Rating = new Rating();
        this.MaxPassenger = maxPassenger;

    }

    public string GetBio()
    {
        return this.Bio;
    }
    public override void PostOnTwitter()
    {
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter($"New Employee, Welcome {this.Name}! Bio: {this.Bio}.", @"CambiodeCielo2.jpg"));

        var twitterDirectMessage = new TwitterMessage();
        Console.WriteLine(twitterDirectMessage.SendMessage("Hello I am a new Conductor!", "846862265022328832"));
    }
}