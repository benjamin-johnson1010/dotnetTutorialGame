namespace TreehouseDefense
{
    class TreeHouseDefenseException : System.Exception
    {
        public TreeHouseDefenseException()
        {
            
        }
        public TreeHouseDefenseException(string message) : base(message)
        {
    }
    }
    class OutOfBoundsException : TreeHouseDefenseException
    {
        public OutOfBoundsException()
        {

        }
                OutOfBoundsException(string message) : base(message)
                {
    }
    
    }
}