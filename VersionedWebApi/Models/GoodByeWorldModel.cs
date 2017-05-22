namespace VersionedWebApi.Model
{
    public class GoodByeWorldModel 
    {
        public GoodByeWorldModel()
        {
            Message = "So long and thanks for all the fish";
            Countdown = 10.0;
        }
        
        public GoodByeWorldModel(string message, double countdown)
        {
            Message = message;
            Countdown = countdown;
        }

        public string Message{ get; set; }
        public double Countdown{ get; set; }
    }
    
}