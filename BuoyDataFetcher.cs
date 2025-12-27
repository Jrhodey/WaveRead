using System.Net.Http;
namespace Buoys
{
    public class BuoyService
    {
        public async Task<string> GetBuoyData (string BuoyId)
        {
            HttpClient client = new HttpClient();
            string url = $"https://www.ndbc.noaa.gov/data/realtime2/{BuoyId}.txt";
            string data = await client.GetStringAsync(url);
            return data;
        }
    }
}