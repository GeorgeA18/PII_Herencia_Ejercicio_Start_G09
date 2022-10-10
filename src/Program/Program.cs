using System;
using System.Collections;

namespace RideShare
{
    class Program
    {
        static void Main(string[] args)
        {

            Passenger passenger1 = new Passenger("Jorge","Avila","123","Ford","0000");
            Passenger passenger2 = new Passenger("Jose","Avila","123","Ford","0000");

            Conductor conductor1 = new Conductor("Jesus","Avila","456","Ford","Soy un increible conductor","0000");
            Conductor conductor2 = new Conductor("Jesus","Avila","456","Ford","Soy un increible conductor","0000");

            ConductorPool conductorPool1 = new ConductorPool("Jesus","Avila","456","Ford","Soy un increible conductor","0000");
            ConductorPool conductorPool2 = new ConductorPool("Jesus","Avila","456","Ford","Soy un increible conductor","0000");





            passenger1.RateUser(passenger2,5);
            passenger1.RateUser(passenger2,3);
            passenger1.RateUser(passenger2,4);



            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }
}
