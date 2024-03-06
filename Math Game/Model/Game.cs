namespace Math_Game.Model
{
    internal class Game
    {
        public int Score { get; set; }
        public DateTime Date { get; set; }
        public GameType Type { get; set; }

        public GameLevel Level { get; set; }
    }
    internal enum GameType
    {
        Addition,
        Subtraction,
        Division,
        Multiplication
    }
    internal enum GameLevel
    {
        Easy,
        Normal,
        Hard
    }
}
