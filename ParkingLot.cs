namespace ParkingLotSystem;

public class ParkingLot
{
    //singleton design pattern
    private static ParkingLot instance;
    private readonly List<Levels> levels;

    private ParkingLot()
    {
        levels=new List<Levels>();
    }

    public static ParkingLot GetInstance()
    {
        if(instance == null)
            instance = new ParkingLot();
        return instance;
    }

    public void AddLevel(Levels level)
    {
        levels.Add(level);
    }

    public bool ParkingVehicle(Vehicle vehicle)
    {
        foreach (var level in levels)
        {
            if (level.ParkingVehicle(vehicle))
            {
                Console.WriteLine("Vehicle parked successfully.");
                return true;
            }
        }
        Console.WriteLine("Could not park vehicle.");
        return false;
    }

    public bool UnparkingVehicle(Vehicle vehicle)
    {
        foreach (var level in levels)
        {
            if (level.UnparkingVehicle(vehicle))
            {
                return true;
            }
        }
        return false;
    }
    
    public void DisplayAvailability()
    {
        foreach (var level in levels)
        {
            level.DisplayAvailability();
        }
    }
}