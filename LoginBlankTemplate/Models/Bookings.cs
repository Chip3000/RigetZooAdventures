namespace LoginBlankTemplate.Models
{
    public class Bookings
    {
        private static int _idCounter = 0;

        public string Id { get; private set; }
        public string RoomType { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }
        public decimal Price { get; private set; }

        public Bookings()
        {
            Id = GenerateId();
        }

        private string GenerateId()
        {
            _idCounter++;
            return _idCounter.ToString();
        }
    }
}