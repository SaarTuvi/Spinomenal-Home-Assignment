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
            while (spinDegree >= 180)
            {
                //Making sure the degree given is 180.
                ////if it's more, it will spin 180 one time, and reduct 180 from the full spin requried
                squereObj.AngleVector(spinDegree - 180, 1);
                spinDegree = spinDegree - 180;
            }
            if(spinDegree != 0)
            {
            squereObj.AngleVector(spinDegree, 1); // Spin the remeining amount
            }

            squereObj.Fade(totalFadeTime / 2, 100, 0); //Full opacity to minimum in half the fade time (fade out)
            squereObj.Fade(totalFadeTime / 2, 0, 100); //Minimum opacity to full in half the fade time (fade in)
            squereObj.Delay(delayTime);
            squereObj.Grow(growSquereBy, growSquereBy); //Multiply both hight and width with the desired growth


            Console.WriteLine(squereObj.ToString()); //The ToString was overriden to meet the task demands
        }
    }
}
