using System;
using TwitterUCU;

namespace RideShare;

public class Conductor : User
{
    string Name { get; set; }
    string LastName { get; set; }
    string CI { get; set; }
    public Rating Rating { get; set; }
    int ID { get; }
    string Password { get; set; }
    string Vehiculo { get; set; }
    string Bio { get; set; }

    public Conductor(string name, string lastName, string ci, string vehiculo, string password, string bio)
    {
        this.Name = name;
        this.LastName = lastName;
        this.CI = ci;
        this.Password = password;
        this.Vehiculo = vehiculo;
        this.Bio = bio;
        this.Rating = new Rating();
        this.ID = Register.AddConductor(this);

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