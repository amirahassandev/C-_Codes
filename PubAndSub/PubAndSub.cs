
namespace PubAndSub;

public class TempInfoEventArgs : EventArgs
{
    private int temperature { get; set; }
    public TempInfoEventArgs(int temp)
    {
        temperature = temp;
    }


}

public class Sensor
{
    public event EventHandler<TempInfoEventArgs> IsChangeTempEvent;
    private int Temperature;

    public void ChangeTemp(int newTemp)
    {
        if (newTemp != Temperature)
        {
            Temperature = newTemp;
            IsChangeTempEvent.Invoke(this, new TempInfoEventArgs(newTemp));
        }
    }
    
    public int DisplayTemp()
    {
        return Temperature;
    }
}


public class Alarm
{
    public Alarm(Sensor sensor){
        sensor.IsChangeTempEvent += CallAlarm;
    }
    public void CallAlarm(object sender, TempInfoEventArgs temp)
    {
        Sensor sensor = (Sensor)sender;
        if(sensor.DisplayTemp() >= 20)
        {
            Console.WriteLine($"Alarm: temp is {sensor.DisplayTemp()}");
        }
    }

}