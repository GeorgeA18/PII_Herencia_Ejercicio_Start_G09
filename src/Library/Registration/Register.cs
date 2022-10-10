using System;
using System.Collections.Generic;

namespace RideShare;

//           UML
// ---------------------------
// + GeneratedID: int
// + PassengersList: List<Passenger>
// + ConductorsList: List<Conductor>
// + ConductorsPoolList: List<ConductorPool>
// ---------------------------
// + SaveData()
// + ValidateData()

// + GeneratingID()
// + AddPassenger()
// + AddConductor()
// + AddConductorPool()
// ---------------------------

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
        return GeneratingID();
    }

    public static int AddConductor(Conductor conductor)
    {
        ConductorsList.Add(conductor);
        return GeneratingID();
    }

    public static int AddConductorPool(ConductorPool conductor)
    {
        ConductorsPoolList.Add(conductor);
        return GeneratingID();
    }

}