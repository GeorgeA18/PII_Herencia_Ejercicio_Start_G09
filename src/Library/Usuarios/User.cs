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

/* 
Los Conductores tendran ciertos atributos mínimos, como ser Nombre, Apellido, Cédula, un Vehículo1 Calificación como conductor y una breve bio.

Los Pasajeros tendran sus propios atributos, como ser Cédula, Nombre, Apellido, calificación como Pasajero.2
*/



// 
public abstract class User
{
    // * Atributos
    string Name { get; set; }
    string lastName { get; set; }
    string CI { get; set; }
    string Vehiculo { get; set; }
    public abstract Rating Rating { get; set; }
    int ID { get; }
    string Password { get; set; }

    // * Metodos
    public abstract void Login();
    public virtual void RateUser(User user,int rating)
    {
        user.Rating.AddRating(rating);
    }

    public abstract string getName();
}