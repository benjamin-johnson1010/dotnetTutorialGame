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
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        // {
        //     get{
        //         return _path.GetLocationAt(_pathStep);
        // }  
        // }
        public int Health{get; private set;} = 2;
        
        public bool HasScored{get{return _pathStep >= _path.Length;}}
        public bool IsNeutralized => Health <= 0;
        public Invader(Path path)
        {
            _path = path;
            // Location = path.GetLocationAt(_pathStep);
        }
        //     get{
        //     return _location;
        // }
        //     private set{
        //         _location = value;
        //         System.Console.WriteLine("location changed");
        //     }
    //}
    public void Move() => _pathStep += 1;

        // Location = _path.GetLocationAt(_pathStep);
    public void DecreaseHealth(int factor)
    {
        Health -= factor;
    }
}
}