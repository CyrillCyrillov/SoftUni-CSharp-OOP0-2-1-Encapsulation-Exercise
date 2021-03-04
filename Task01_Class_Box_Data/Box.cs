using System;
using System.Collections.Generic;
using System.Text;

namespace Task01_Class_Box_Data
{
    public class Box
    {
        private double length;

        private double width;
        
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.ThrowIfInvalidArgument(value, nameof(Length));

                this.length = value;
            }
        }

        

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.ThrowIfInvalidArgument(value, nameof(Width));

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.ThrowIfInvalidArgument(value, nameof(Height));

                this.height = value;
            }
        }

        //Surface Area = 2lw + 2lh + 2wh

        public double SurfaceArea()
        {
            double result = 2 * length * width + 2 * length * height + 2 * width * height;
            return result;
        }

        //Lateral Surface Area = 2lh + 2wh

        public double LateralSurfaceArea()
        {
            double result = 2 * length * height + 2 * width * height;
            return result;
        }

        
        public double Volume()
        {
            double result = length * width * height;
            return result;
        }

        private void ThrowIfInvalidArgument(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }

    }
}
