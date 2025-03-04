﻿namespace ParkingLotSystem;

public class ParkingSpot
{
    private readonly VehicleType vehicleType;
    private Vehicle parkedVehicle;
    protected int spotNumber;
    
    public ParkingSpot(int spotNumber, VehicleType vehicleType)
    {
        this.spotNumber = spotNumber;
        this.vehicleType = vehicleType;
    }
    public bool IsAvailable()
    {
        return parkedVehicle == null;
    }

    public void ParkVehicle(Vehicle vehicle)
    {
        if (IsAvailable() && vehicle.GetVehicleType() == vehicleType)
        {
            parkedVehicle = vehicle;
        }
        else
        {
            throw new ArgumentException("Invalid vehicle type or spot already occupied.");
        }
    }

    public void UnparkVehicle()
    {
        parkedVehicle = null;
    }

    public VehicleType GetVehicleType()
    {
        return vehicleType;
    }

    public Vehicle GetParkedVehicle()
    {
        return parkedVehicle;
    }

    public int GetSpotNumber()
    {
        return spotNumber;
    }
}