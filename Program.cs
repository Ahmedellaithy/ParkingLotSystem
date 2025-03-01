namespace ParkingLotSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ParkingLot parkingLot = ParkingLot.GetInstance();
            parkingLot.AddLevel(new Levels(1, 100));
            parkingLot.AddLevel(new Levels(2, 80));

            Vehicle car = new Car("ABC123");
            Vehicle truck = new Truck("XYZ789");
            Vehicle handyCapped = new HandyCapped("M1234");

            
            parkingLot.ParkingVehicle(car);
            parkingLot.ParkingVehicle(truck);
            parkingLot.ParkingVehicle(handyCapped);

            
            parkingLot.DisplayAvailability();

            
            parkingLot.UnparkingVehicle(handyCapped);

            
            parkingLot.DisplayAvailability();
        }
    }
}
