using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Enums;
using System;

namespace SampleHierarchies.Data
{
    //KeDi C
    public class ScreenSettings
    {
        #region Public methods

        public void Display(int screenNum)
        {
            var screenName = (ColorScreenChoices)screenNum;
            Console.WriteLine($"{screenName} screen: Foreground color is {MainTextColor}, background color is {MainBackgroundColor}");
        }
        #endregion//Public methods

        #region Ctors And Properties
        public int ScreenNumber { get; set; }
        public ConsoleColor MainTextColor { get; set; }
        public ConsoleColor MainBackgroundColor { get; set; }


        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="screenNum">Name</param>
        /// <param name="text">Name</param>
        /// <param name="background">Breed</param>
        /// 
        public ScreenSettings(int screenNum, ConsoleColor text, ConsoleColor background)
        {
            ScreenNumber = screenNum;
            MainTextColor = text;
            MainBackgroundColor = background;
        }

        #endregion //Ctors And Properties
    }
    //KeDi
}
