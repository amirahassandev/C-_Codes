namespace DesignPattern;

internal class program
{
    static void Main(String[] args)
    {




        #region Pub&Sub

        Sensor sensor1 = new Sensor();
        Alarm alarm = new Alarm(sensor1);
        sensor1.ChangeTemp(16);
        sensor1.ChangeTemp(22);
        sensor1.ChangeTemp(12);
        sensor1.ChangeTemp(40);




        // System.Console.WriteLine();
        
        #endregion
    }
}
