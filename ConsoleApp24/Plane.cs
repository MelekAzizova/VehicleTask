namespace TaskVehicle;

internal class Plane : Vehicle, IEngine, ITransmission
{
    public int WingLength;

    public Plane(int path, int time)
    {
        DriveTime= time;
        DrivePath = path;
    }

    public override int AverageSpeed()
    {
        return DrivePath / DriveTime;
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
        throw new NotImplementedException();
    }
}
