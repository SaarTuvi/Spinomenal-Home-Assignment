using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    public class Squere
    {
        #region Props
        public int Width { get; set; }
        public int Hight { get; set; }
        public string Color { get; set; }
        #endregion

        #region Ctors
        public Squere()
        {

        }

        public Squere(int width, int hight, string color)
        {
            this.Width = width;
            this.Hight = hight;
            this.Color = color;
        }

        #endregion

        #region Functions
        public void AngleVector(int angle, int x)
        {
            //The function rotates the object by ‘angle’ number of degrees, ‘x’ number of times.
        }

        public void Fade(int duration, int sourceOpacity, int destOpacity)
        {
            // The function changes the opacity from ‘sourceOpacity’ to ‘destOpacity’ over ‘duration’
        }

        public void Grow(int width, int height)
        {
            // function that gets new width and height and multiplies the current
            // width by ‘width’ and the current height by ‘height’.
        }

        public void Delay(int x)
        {
            //   stops the current flow of the code by ‘x’ milliseconds.
        }

        public override string ToString()
        {
            return $"Shape size: {this.Hight} * {this.Width}";
        }

        #endregion
    }
}
