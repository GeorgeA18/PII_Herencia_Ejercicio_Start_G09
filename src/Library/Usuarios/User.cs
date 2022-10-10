using System;
using TwitterUCU;

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
// + RateUser()
// + GetNombre()
// ---------------------------

/* 
Los Conductores tendran ciertos atributos mínimos, como ser Nombre, Apellido, Cédula, un Vehículo1 Calificación como conductor y una breve bio.

Los Pasajeros tendran sus propios atributos, como ser Cédula, Nombre, Apellido, calificación como Pasajero.2
*/



// 
public abstract class User
{
    // * Atributos
    string Name { get; set; }
    string LastName { get; set; }
    string CI { get; set; }
    Rating Rating { get; set; }

    int ID { get; }
    string Password { get; set; }

    // * Metodos
    public void Login()
    {

    }
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