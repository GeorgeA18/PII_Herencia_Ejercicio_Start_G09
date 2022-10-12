using System;
using TwitterUCU;

namespace RideShare;

public class Conductor : User, IConductor
{
    string Name { get; set; }
    string LastName { get; set; }
    string CI { get; set; }
    public Rating Rating { get; set; }
    string Password { get; set; }
    public string Vehicle { get; set; }
    public string Bio { get; set; }
    public int MaxPassenger {get; set;}


    //MaxPassenger se inicializa siempre en 1, siendo que este tipo de conductores solo pueden llevar 1 pasajero
    public Conductor(string name, string lastName, string ci, string vehicle, string password, string bio)
    {
        this.Name = name;
        this.LastName = lastName;
        this.CI = ci;
        this.Password = password;
        this.Vehicle = vehicle;
        this.Bio = bio;
        this.Rating = new Rating();
        this.MaxPassenger = 1;

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