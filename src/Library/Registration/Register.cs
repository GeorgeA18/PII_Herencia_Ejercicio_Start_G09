using System;
using System.Collections.Generic;
using TwitterUCU;

namespace RideShare;


// 
public class Register
{
    public static int GeneratedID = 0;
    static List<Passenger> PassengersList = new List<Passenger>();
    static List<Conductor> ConductorsList = new List<Conductor>();
    static List<ConductorPool> ConductorsPoolList = new List<ConductorPool>();

    public static int GeneratingID()
    {

        GeneratedID += GeneratedID;

        return GeneratedID;
    }

    public static int AddPassenger(Passenger passenger)
    {
        PassengersList.Add(passenger);
        passenger.PostOnTwitter();
        return GeneratingID();
    }

    public static int AddConductor(Conductor conductor)
    {
        ConductorsList.Add(conductor);
        conductor.PostOnTwitter();
        return GeneratingID();
    }

    public static int AddConductorPool(ConductorPool conductorPool)
    {
        ConductorsPoolList.Add(conductorPool);
        conductorPool.PostOnTwitter();
        return GeneratingID();
    }


}