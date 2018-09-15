using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const double kmToau = 0.000000006685;
                const double kmTomile = 0.621371192;
                const double lightSpeed = 186000d;   // miles per second
                double lighttime, sunto, dis, sum;
                char k;
                do
                {

                    Console.Write("\nPlease Distance KM = ");
                    dis = double.Parse(Console.ReadLine());
                    sum = dis * kmToau;      // แปลงเป็น A.U
                    Console.WriteLine("DistanceToSun = {0:F4} A.U", sum);
                    sunto = dis * kmTomile;    // หาระยะห่างจากดาวถึงดวงอาทิตย์เป็นหน่วย Mile
                    Console.WriteLine("DistanceMile = {0:F4} Mile", sunto);
                    lighttime = sunto / lightSpeed;  // ระยะห่าง(ไมล์) * ความเร็วแสง (ไมล์ต่อวิ) = ระยะเวลาของแสงจากดาวถึงอาทิตย์ (ต่อวิ)
                    Console.WriteLine("LightSpeedTime = {0:F2} Minutes", lighttime / 60);// ระยะเวลาของแสงจากดาวถึงอาทิตย์(ต่อนาที)

                    k = Console.ReadKey().KeyChar;
                }
                while ((k == 'Y') || (k == 'y'));
            }
        }
    }
}
