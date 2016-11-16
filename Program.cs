using System;

namespace TreehouseDefense
{
    public class Program
    {
        public static void Main()
        {
            Map map = new Map(8,5);
        //    MapLocation point = new MapLocation(4,2);
        //    Point p = point;
        //     map.OnMap(new MapLocation(0,0));
        //     Console.WriteLine(point.DistanceTo(5,5));
        //     Console.WriteLine(point is MapLocation);
        //     Console.WriteLine(point is Point);
            try{
                MapLocation[] path= {
                    new MapLocation(0,2, map),                                        
                    new MapLocation(1,2, map),
                    new MapLocation(2,2, map),
                    new MapLocation(3,2, map),
                    new MapLocation(4,2, map),
                    new MapLocation(5,2, map),
                    new MapLocation(6,2, map),
                    new MapLocation(7,2, map)
                };
                // Invader invader = new Invader();
                // MapLocation location = new MapLocation(0,0,map);

                // invader.Location = location;
                // location = invader.Location;
            MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        catch(TreeHouseDefenseException ex)
        {
        
            }
        }
    }
    }

