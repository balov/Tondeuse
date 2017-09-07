using System;

namespace TaskovExercise.Entities
{
    public class Tondeuse
    {
        private int x;
        private int y;
        private char orientation;

        public Tondeuse(int x, int y, char orientation)
        {
            this.X = x;
            this.Y = y;
            this.Orientation = orientation;
        }

        public int X
        {
            get
            {
                return this.x;
            }

            private set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            private set
            {
                this.y = value;
            }
        }

        public char Orientation
        {
            get
            {
                return this.orientation;
            }

            private set
            {
                this.orientation = value;
            }
        }

        public void Move(Surface surface)
        {
            if (CanIMove(surface))
            {
                switch (this.Orientation)
                {
                    case 'N':
                        this.Y++;
                        break;

                    case 'S':
                        this.Y--;
                        break;

                    case 'W':
                        this.X--;
                        break;

                    case 'E':
                        this.X++;
                        break;
                }
            }
        }

        public void Rotate(char direction)
        {
            string orientations = "WNES";

            int indexOfCurrentOrientation = orientations.IndexOf(this.Orientation);

            if (direction == 'G')
            {
                int indexOfNewOrientation = indexOfCurrentOrientation - 1;

                char newOrientation = indexOfNewOrientation < 0 ? orientations[orientations.Length - 1] : orientations[indexOfNewOrientation];

                this.Orientation = newOrientation;
            }
            else if (direction == 'D')
            {
                int indexOfNewOrientation = indexOfCurrentOrientation + 1;

                char newOrientation = indexOfNewOrientation > (orientations.Length - 1) ? orientations[0] : orientations[indexOfNewOrientation];

                this.Orientation = newOrientation;
            }
        }

        private bool CanIMove(Surface surface)
        {
            switch (this.Orientation)
            {
                case 'N':
                    if (this.Y < surface.Ymax)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 'S':
                    if (this.Y > surface.Ymin)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 'W':
                    if (this.X > surface.Xmin)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 'E':
                    if (this.X < surface.Xmax)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            return String.Join(" ", this.X, this.Y, this.Orientation);
        }
    }
}