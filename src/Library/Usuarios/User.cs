using System;
using TwitterUCU;

namespace RideShare;


public abstract class User
{

    string Name { get; set; }
    string LastName { get; set; }
    string CI { get; set; }
    Rating Rating { get; set; }
    string Password { get; set; }


    public void RateUser(User user, int rating)
    {
        user.Rating.AddRating(rating);

        Console.WriteLine($"El promedio de calificaciones de {user.GetName()} es {user.Rating.AverageRating}");
    }

    public string GetName()
    {
        return this.Name;
    }

    public abstract void PostOnTwitter();
}