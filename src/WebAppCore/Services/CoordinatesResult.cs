namespace YourAppName.Services
{
    public class CoordinatesResult
    {
        public string Message { get; internal set; }
        public bool Success { get; internal set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}