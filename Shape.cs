namespace CacDoiTuongHinhHoc
{
    public class Shape
    {
        public string color = "green";
        public bool filled = true;

        public Shape(){}

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }
        
         public bool getfilled()
        {
            return filled;
        }

        public void setfilled(bool filled)
        {
            this.filled = filled;
        }

        public override string ToString()
        {
            return "A Shape with color of " + getColor() + "and" + (getfilled() ? "filled" : "not filled");
        }
    }
}