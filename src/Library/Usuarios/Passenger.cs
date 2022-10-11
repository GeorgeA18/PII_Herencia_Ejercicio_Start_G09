using System;
using TwitterUCU;

namespace RideShare;

public class Passenger : User
{
    string Name { get; set; }
    string LastName { get; set; }
    string CI { get; set; }
    public Rating Rating { get; set; }
    int ID { get; }
    string Password { get; set; }

    public Passenger(string name, string lastName, string ci, string password)
    {
        this.Name = name;
        this.LastName = lastName;
        this.CI = ci;
        this.Password = password;
        this.Rating = new Rating();
        this.ID = Register.AddPassenger(this);
    }

    public override void PostOnTwitter()
    {
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter($"New Passanger, Welcome {this.Name}!", @"CambiodeCielo2.jpg"));

    }

}