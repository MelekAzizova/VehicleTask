namespace TaskVehicle;


internal class Bicycle : Vehicle, IWheel
{
    public string PedalKind; 

    public Bicycle(int path, int time)
    {
        DrivePath = path;
        DriveTime = time;
    }

    public override int AverageSpeed()
    {
        return DrivePath / DriveTime;
    }

    public int WheelThickness()
    {
        throw new NotImplementedException();
    }
}
