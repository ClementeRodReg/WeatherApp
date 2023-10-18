namespace WeatherApp
{
    public class EndPoints
    {
        public static string GetGeoApifyEndPoint(string cityName)
        {
            //return $"https://api.geoapify.com/v1/geocode/search?text=bilbao&format=json&apiKey=fa735f63a7194a57b23820d8343024b9";
            return $"https://api.geoapify.com/v1/geocode/search?text={cityName}&format=json&apiKey={Config.GeoApifyKey}";
        }

        public static string getWeatherEndPoint(float lat, float lon)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,apparent_temperature,is_day,weathercode&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Europe%2FLondon";
            url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,apparent_temperature,is_day,weathercode&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Europe%2FLondon";
            return url;
        }
    }
}


