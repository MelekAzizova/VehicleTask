using System.Numerics;

namespace TaskVehicle;

internal class Car : Vehicle, IEngine, IWheel, ITransmission
{
    public int DoorCount;
    public string WinCode;
    private string transmissionkind;
    int count;
    string wincode;
    

    public Car(int path, int time, int doorCount, string winCode, string transmissionkind)
    {
        DrivePath = path;
        DriveTime = time;
        DoorCount = doorCount;
        WinCode = winCode;
        this.transmissionkind = transmissionkind;
    }

    public int Count
    {
        get { return count; }
        set
        {
            while (value<0)
            {
                Console.WriteLine("Invalid Input!!!");
                value = Convert.ToInt32(Console.ReadLine());
            }
            count = value;
        }

    }
    public string Wincode
    {
        get { return wincode; }
        set
        {
            wincode = value;
            
            
        }

    }
    public override int AverageSpeed()
    {
        
        return DrivePath / DriveTime;
        
    }


    public string Transmissionkind
    {
        get { return transmissionkind; }
        set
        {
            transmissionkind = value;
        }
    }




    public float CurrentOil()
    {
        throw new NotImplementedException();
    }

    public string FeulType()
    {
        throw new NotImplementedException();
    }

    public int HorsePower()
    {
        throw new NotImplementedException();
    }

    public void RemainOilAmount()
    {
        throw new NotImplementedException();
    }

    public float TankSize()
    {
        throw new NotImplementedException();
    }

    public string TransmissionKind()
    {
        return "Auto or Manuel";
    }

    public int WheelThickness()
    {
        throw new NotImplementedException();
    }
}
