using System;

namespace Events
{
    public delegate void AlarmDelegate();
    class Alarm
    {
        public event AlarmDelegate onFire;

        public void FireDetect()
        {
            Console.WriteLine("Fire Detected");
            onFire?.Invoke();
        }
    }

    class SafetySystem
    {
        public void Siren()
        {
            Console.WriteLine("WE-OO-WE-!!!");
        }

        public void FireFighters()
        {
            Console.WriteLine("Calling Fire Fighters");
        }
    }

    internal class Events
    {
        static void Main(string[] args)
        {
            Alarm a = new Alarm();
            SafetySystem s = new SafetySystem();
            a.onFire += s.Siren;
            a.onFire += s.FireFighters;
            a.FireDetect();
        }
    }

}
