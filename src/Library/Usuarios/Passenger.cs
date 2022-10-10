using System;

namespace RideShare;

//           UML
// ---------------------------
// + ID: int 
// + Name: String
// + lastName: String
// + CI: string
// + Vehiculo: string
// + Rating: Rating

// ---------------------------
// + Login()
// + DeleteUser()
// ?+ RateUser()
// ---------------------------

// 
public class Passenger : User
{
    public string Name { get; set; }
    string LastName { get; set; }
    string CI { get; set; }
    string Vehiculo { get; set; }
    public override Rating Rating { get; set; }
    int ID { get; }
    string Password { get; set; }

    public Passenger(string name, string lastName, string ci, string vehiculo, string password)
    {
        this.Name = name;
        this.LastName = lastName;
        this.CI = ci;
        this.Vehiculo = vehiculo;

        this.Password = password;

        this.Rating = new Rating();

        this.ID = Register.AddPassenger(this);

    }

    public override void Login()
    {

    }
    
    public override void RateUser(User user, int rating)
    {
        user.Rating.AddRating(rating);

        Console.WriteLine($"El promedio de calificaciones de {user.getName()} es {user.Rating.AverageRating}");
    }

    public override string getName()
    {
        return this.Name;
    }
}