namespace LambdaWithDelegate
{
    public class Player
    {
        private int points = 0;
        public int Id { get; set; }
        public string? PlayerName { get; set; }

        public Player(int id, string pName, int point)
        {
            Id = id;
            PlayerName = pName;
            points = point;
        }

        // geter seter menggunakan lambda expression
        public int Points
        {
            get => points;
            set => points = value;
        }

        // mehod dari kelas dasar menggunakan lambda expression
        public override string ToString() => $"Player ID : {Id}, Player name : {PlayerName} and Points : {points}";
    }
}