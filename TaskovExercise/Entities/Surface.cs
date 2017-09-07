namespace TaskovExercise.Entities
{
    public class Surface
    {
        private const int XMinConstant = 0;
        private const int YMinConstant = 0;

        private int xmin;
        private int ymin;
        private int xmax;
        private int ymax;

        public Surface(int xmax, int ymax)
        {
            this.Xmin = XMinConstant;
            this.Ymin = YMinConstant;
            this.Xmax = xmax;
            this.Ymax = ymax;
        }

        public int Xmin
        {
            get
            {
                return this.xmin;
            }

            private set
            {
                this.xmin = value;
            }
        }

        public int Ymin
        {
            get
            {
                return this.ymin;
            }

            private set
            {
                this.ymin = value;
            }
        }

        public int Xmax
        {
            get
            {
                return this.xmax;
            }

            private set
            {
                this.xmax = value;
            }
        }

        public int Ymax
        {
            get
            {
                return this.ymax;
            }

            private set
            {
                this.ymax = value;
            }
        }
    }
}