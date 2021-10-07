namespace assignment1.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponse(GuestReponse response)
        {
            
        }
    }
}