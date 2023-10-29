using TaskVehicle;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Car car = null;
            Plane plane = null;
            Bicycle bicycle = null;

            








            Console.WriteLine("1->Create a new Car");
            Console.WriteLine("2->Create a new Plane");
            Console.WriteLine("3->Create a new Bicycle");
            Console.WriteLine("4->See all Vehicle");
            Console.WriteLine("5->Delete Vehicle");
            int Enter = Convert.ToInt32(Console.ReadLine());






            switch (Enter)
            {
                case 1:
                    Console.WriteLine("Enter door count: ");
                    int doorCount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter road(km): ");
                    int carDrivePath = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter time(hours): ");
                    int carDriveTime = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter wincode: ");
                    string carWinCode= Console.ReadLine();

                    Console.WriteLine("Enter transmission kind(Auto or Manual): ");
                    string carTransmission = Console.ReadLine();




                    car = new Car(doorCount, carDrivePath, carDriveTime, carWinCode, carTransmission);
                    car.Count = doorCount;
                    car.DrivePath = carDrivePath;
                    car.DriveTime = carDriveTime;
                    car.Wincode = carWinCode;
                    car.Transmissionkind = carTransmission;

                    Console.WriteLine("\n Door count: " + car.Count + "\n Speed (km/h): "+ car.AverageSpeed() + "\n Car win code: " + car.Wincode +"\n Transmission kind: "+car.TransmissionKind());
                   

                    break;



                case 2:
                    

                    Console.WriteLine("Enter road(km): ");
                    int planeDrivePath = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter time(hours): ");
                    int planeDriveTime = Convert.ToInt32(Console.ReadLine());

             
                    plane = new Plane(planeDrivePath, planeDriveTime);
                   
                    plane.DrivePath = planeDrivePath;
                    plane.DriveTime = planeDriveTime;

                    Console.WriteLine("\n Speed: " + plane.AverageSpeed());





                    break;



                case 3:
                    Console.WriteLine("Enter path(km): ");
                    int bicycleDrivePath= Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter time(hours): ");
                    int bicycleDriveTime= Convert.ToInt32(Console.ReadLine());

                    bicycle = new Bicycle(bicycleDrivePath, bicycleDriveTime);

                    bicycle.DrivePath = bicycleDrivePath;
                    bicycle.DriveTime = bicycleDriveTime;



                    Console.WriteLine("\n Speed(km/h): " + bicycle.AverageSpeed());







                   
                    break;





            }





















        }

    

        
    }
}