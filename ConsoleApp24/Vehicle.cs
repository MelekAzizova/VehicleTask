namespace TaskVehicle;

internal abstract class Vehicle
{
    public int time;
    public int path;

   

    public int DrivePath
    {
        get { return path; }
        set
        {
            path=value;
        }
    }

    public int DriveTime
    {
        get { return time; }
        set
        {
            time=value;
        }
    }

    public abstract int AverageSpeed();
}
