namespace TreehouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }
        public void FIreOnInvaders(Invader[] invaders)
        {
            // int index = 0;
            // while(index < invaders.Length)
            // {
            //     Invader invader = invaders[index];

            //     index++;
            // }
        // for(int i = 0; i < invaders.Length; i++)
        // {
        //     Invader invader = invaders[1];
        // }
        foreach(Invader invader in invaders)
        {
            if(invader.IsActive && _location.inRangeOf(invader.Location, _range))
            {
                invader.DecreaseHealth(_power);
            }
        }
        }
    }
}