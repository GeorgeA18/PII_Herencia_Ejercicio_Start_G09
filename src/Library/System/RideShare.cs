using System;
using System.Collections.Generic;
using TwitterUCU;

namespace RideShare;


// 
public class RideShare
{
    List<Passenger> PassengersList{get; set;}
    List<IConductor> ConductorsList{get; set;}

    public RideShare(){
        PassengersList = new List<Passenger>();
        ConductorsList = new List<IConductor>();
    }
    public void AddPassenger(Passenger passenger)
    {
        PassengersList.Add(passenger);
        passenger.PostOnTwitter();
    }

    //Se utiliza una lista de tipo IConductor para poder contener todas las implementaciones que funcionarán como conductores
    public void AddConductor(IConductor conductor)
    {
        ConductorsList.Add(conductor);
        conductor.PostOnTwitter();
    }

}