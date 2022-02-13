using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int squereHight = 100;
            int squereWidth = 100;
            string squereColor = "Green";
            int spinDegree = 360;
            int totalFadeTime = 4;
            int delayTime = 3;
            int growSquereBy = 4;

            Squere squereObj = new Squere(squereWidth, squereHight, squereColor);
            //Constructing the squere with dimentions and color required

            int vectorMultiplier = spinDegree / 180;
            int remainer = spinDegree % 180;
            squereObj.AngleVector(180, vectorMultiplier);
            if(remainer != 0)
            {
                squereObj.AngleVector(remainer, 1);
            }

            squereObj.Fade(totalFadeTime / 2, 100, 0); //Full opacity to minimum in half the fade time (fade out)
            squereObj.Fade(totalFadeTime / 2, 0, 100); //Minimum opacity to full in half the fade time (fade in)
            squereObj.Delay(delayTime);
            squereObj.Grow(growSquereBy, growSquereBy); //Multiply both hight and width with the desired growth


            Console.WriteLine(squereObj.ToString()); //The ToString was overriden to meet the task demands
        }
    }
}
