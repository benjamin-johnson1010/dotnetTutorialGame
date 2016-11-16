namespace TreehouseDefense
{
    class Invader
    {   
        private readonly Path _path;
        private int _pathStep = 0;        
        // public MapLocation GetLocation()
        // {
        //     return _location;
        // }
        // public void SetLocation(MapLocation value)
        // {
        //     _location = value;
        // }
        public MapLocation Location{get; private set;} 

        public Invader(Path path)
        {
            _path = path;
            Location = path.GetLocationAt(_pathStep);
        }
        //     get{
        //     return _location;
        // }
        //     private set{
        //         _location = value;
        //         System.Console.WriteLine("location changed");
        //     }
    //}
    public void Move()
    {
        _pathStep += 1;
        Location = _path.GetLocationAt(_pathStep);
    }
}
}