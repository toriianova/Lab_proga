using laba_5;
class Program
{
    static void Main()
    {
        BookingSystem system = new BookingSystem();

        system.AddBooking(new HotelBooking(1, 1000, 3));
        system.AddBooking(new CarBooking(2, 500, 4, 200));
        system.AddBooking(new RoomBooking(3, 300, 5, 1.5));

        system.ShowAll();

        var max = system.GetMostExpensive();
        Console.WriteLine("\nMost expensive booking:");
        Console.WriteLine(max.GetInfo());

        Console.WriteLine($"\nAverage cost: {system.GetAverageCost()}");
    }
}