namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x,y)
        {
            if(!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries");
            }
        }
        public bool inRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}