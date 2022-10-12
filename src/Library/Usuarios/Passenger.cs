using System;
using TwitterUCU;
using System.Drawing;

namespace RideShare;

public class Passenger : User
{
    string Name { get; set; }
    string LastName { get; set; }
    string CI { get; set; }
    public Rating Rating { get; set; }
    string Password { get; set; }
    string PicPath{get;set;}

    public Passenger(string name, string lastName, string ci, string password, string PicPath="default.png")
    {
        this.Name = name;
        this.LastName = lastName;
        this.CI = ci;
        this.Password = password;
        this.Rating = new Rating();
        this.PicPath= PicPath;
    }

    public override void PostOnTwitter()
    {
        //Solo si tiene cara se deja la foto que haya ingresado el usuario, sino se cambia por una default
        CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow);
        cog.Recognize(this.PicPath);
        bool FaceAndSmile = FaceAndSmiles.FoundFace(cog, false);
        if(!FaceAndSmile){
            this.PicPath="default.png";
        }

        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter($"New Passenger, Welcome {this.Name}!", this.PicPath));

    }

}