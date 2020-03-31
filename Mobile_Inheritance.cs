using System;

namespace Mobile_Inheritance
{
    public class Mobile
    {
       
        public readonly int _Ram;
        public readonly int _Rom;
        public readonly int _BatteryCapacity;
        public Mobile(int Ram,int Rom,int BatteryCapacity)
        {
            this._Ram = Ram;
            this._Rom = Rom;
            this._BatteryCapacity = BatteryCapacity;
        }
        
        
    }
    public class RedmiNote4 : Mobile
    {
        private readonly long _IMEI_number;
        public RedmiNote4(long  IMEI_number, int Ram, int Rom, int BatteryCapacity): base(Ram, Rom, BatteryCapacity)
        {
            
            this._IMEI_number = IMEI_number;
        }

        public void GetProcessorDetails()
        {
            Console.WriteLine("2-GHZ , Qualcomm SnapDragon 625");
        }

        public void GetAllDetails()
        {
            Console.WriteLine("IMEI number :"+this._IMEI_number);
            Console.WriteLine("RAM :" + this._Ram+" GB");
            Console.WriteLine("Rom :"+this._Rom+" GB");
            Console.WriteLine("Battery Capacity :" + this._BatteryCapacity+" mAh");
        }
    }
    class User
    {
        static void Main(string[] args)
        {
            RedmiNote4 omkar = new RedmiNote4(865405034456785, 4, 32, 4100);
            omkar.GetProcessorDetails();
            omkar.GetAllDetails();
            Console.ReadLine();
        }
    }
}
