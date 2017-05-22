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

        public string Message { get; set; }
        public double Countdown { get; set; }
    }

    namespace v3
    {
        public class GoodByeWorldModel
        {
            public GoodByeWorldModel()
            {
                Message = "From a battle I come, to a battle I ride.";
                Countdown = 20.0;
                Locale = new Location { X = 0, Y = 10, Z = 20  };
            }

            public GoodByeWorldModel(string message, double countdown)
            {
                Message = message;
                Countdown = countdown;
                Locale = new Location { X = 0, Y = 10, Z = 20 };
            }

            public string Message { get; set; }
            public double Countdown { get; set; }
            public Location Locale { get; set; }

            public class Location
            {
                public int X { get; set; }
                public int Y { get; set; }
                public int Z { get; set; }
            }
        }
    }
}