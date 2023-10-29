namespace TaskVehicle;

internal interface IEngine
{
    public int HorsePower();
    public float TankSize();
    public float CurrentOil();
    public string FeulType();

    


    public abstract void RemainOilAmount();
}
