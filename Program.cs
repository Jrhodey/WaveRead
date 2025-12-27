using System;
using System.Threading.Tasks;
using System.IO.Pipelines;
using Buoys;
using System.Text;
namespace program{
    class Program
    {
        int i = 0;
        static async Task Main (string[] args)
        {
            BuoyService test = new BuoyService();
            string result = await test.GetBuoyData("SSBN7");
            string[] lines = result.Split('\n');

            for (int i = 2; i< lines.Length; i++)
            {
            Console.WriteLine(lines[i]);
            string[] data = lines[i].Split(' ');

            string waveHeight = data[5];
            //DPD = Dominant Wave Period
            string DPD = data[9];
            //APD = avg wave period
            string APD = data[10];
            string waveDir = data[11];
            string waterTemp = data[15];

            double waveHeightMeters = double.Parse(waveHeight);
            double DPDSecs = double.Parse(DPD);
            double APCSecs = double.Parse(APD);
            double waveDirUnit = double.Parse(waveDir);
            double waterTempCelcius = double.Parse(waterTemp);
            }
        }

    }
}