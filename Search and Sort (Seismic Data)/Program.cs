using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_and_Sort__Seismic_Data_
{
    class Program
    {
        // public int for selecting the file
        public static int fileNum = 0;
        // public int for selecting the file Group
        public static int fileGroupNum = 0;
        // create array of file names
        public static string[] files = new string[] { "Year", "Month", "Day", "Time", "Magnitude", "Latitude", "Longitude", "Depth", "Region", "IRIS_ID", "Timestamp" };
        public static List<List<string>> fileInfoList = new List<List<string>>();
        // the array for the file data after converting from list
        public static string[][] fileData;
        // store option in menu
        public static string option = "";
        // search value
        public static string searchValue = "";
        // set the extension for the files
        public static string extension = ".txt";
        // set int for if the array has been read or not
        public static int arrayRead = 0;
        // public boolean for quitting the program preset to false
        public static bool quitProgram = false;

        // public main to run the program
        public static void Main(string[] args)
        {
            // while statement to run the main menu until the user wants to quit
            while (quitProgram == false)
            {
                // create the main menu object from external class
                Menu menu = new Menu();
                menu.mainMenu();
                // repeat main menu once menu has completed code cycle unless they user chose to quit which has set quitProgram to true 
                // causing the while statement to stop
            }
        }
    }
}
