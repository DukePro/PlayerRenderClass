namespace MyProgramm
{
    class Programm
    {
        static void Main()
        {
            Player player = new Player();
            DrawPlayer draw = new DrawPlayer();
            draw.DrawPlayerIcon(player);
        }
    }

    class Player
    {
        public char _playerChar { get; private set; }
        private int _health { get; set; }
        private int _damage { get; set; }
        public int _playerPositionX { get; private set; }
        public int _playerPositionY { get; private set; }

        public Player(char playerChar, int health, int damage, int playerPositionX, int playerPositionY)
        {
            _playerChar = playerChar;
            _health= health;
            _damage= damage;
            _playerPositionX = playerPositionX;
            _playerPositionY = playerPositionY;
        }

        public Player()
        {
            _playerChar = (char)02;
            _health = 100;
            _damage = 20;
            _playerPositionX = 5;
            _playerPositionY = 5;
        }
    }

    class DrawPlayer
    {
        public void DrawPlayerIcon(Player player)
        {
            Console.SetCursorPosition(player._playerPositionX, player._playerPositionY);
            Console.Write(player._playerChar);
        }
    }
}