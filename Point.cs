namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //overload method 1
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //overload method 2
        public void Move(Point newLocation)
        {
            if(newLocation == null)
                throw new ArgumentNullException("newLocation");
            
            Move(newLocation.X, newLocation.Y);
        }
        // public void Move(Point newLocation)
        // {
        //     this.X = newLocation.X;
        //     this.Y = newLocation.Y;
        // }



    }
}
