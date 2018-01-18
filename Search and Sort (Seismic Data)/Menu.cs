using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_and_Sort__Seismic_Data_
{
    class Menu
    {
        // set references
        FileManagement fileMan = new FileManagement();
        // Store if input error
        public bool validationFailure = false;
        public void mainMenu()
        {
            //clear the screen for a fresh start
            Console.Clear();

            // set string for user input and allow for if the user puts in incorrect values
            string menuC = "0";

            // create the visual menu
            Console.WriteLine("Search and Sort (Seismic Data) v1. By Mitch Durso");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("##########                   Main Menu!                   ##########");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("    Please enter the number for the choice you would like: ");
            Console.WriteLine("     1. File 1.");
            Console.WriteLine("     2. File 2.");
            Console.WriteLine("     *. Custom File Number (Coming Soon).");
            Console.WriteLine("     3. Help");
            Console.WriteLine("     4. Quit.\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            // user input validation check for previous cycle
            if (validationFailure == true)
            {
                Console.WriteLine("\n Please Enter a valid value!");
            }
            // get user input and store
            menuC = Console.ReadLine();

            // check user input against switch case otherwise default will run the main menu again with a clean slate and an error message
            if (menuC == "1" || menuC == "2" || menuC == "3" || menuC == "4")
            {
                switch (menuC)
                {
                    case "1":
                        Program.fileGroupNum = 1;
                        fileMan.checkFile();
                        mainMenu2();
                        break;
                    case "2":
                        Program.fileGroupNum = 2;
                        fileMan.checkFile();
                        mainMenu2();
                        break;
                    case "3":
                        helpMenu();
                        break;
                    case "4":
                        Program.quitProgram = true;
                        break;
                    default:
                        break;
                }
            }

            else
            {
                validationFailure = true;
                mainMenu();
            }
        }

        // ===========================
        //  Second stage of the menu
        // ===========================

        public void mainMenu2()
        {
            //clear the screen for a fresh start
            Console.Clear();

            // set string for user input and allow for if the user puts in incorrect values
            string menuC = "0";

            // create the visual menu
            Console.WriteLine("Search and Sort (Seismic Data) v1. By Mitch Durso");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("##########                   Options!                     ##########");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("    Please enter the number for the choice you would like: ");
            Console.WriteLine("     1. Sort data in Ascending order.");
            Console.WriteLine("     2. Sort data in Descending order.");
            Console.WriteLine("     3. Search files for specific data.");
            Console.WriteLine("     4. Search By Month.");
            Console.WriteLine("     5. Back.\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            // user input validation check for previous cycle
            if (validationFailure == true)
            {
                Console.WriteLine("\n Please Enter a valid value (1, 2, 3, 4 or 5)!");
            }
            // get user input and store
            menuC = Console.ReadLine();

            // check user input against switch case otherwise default will run the main menu again with a clean slate and an error message
            if (menuC == "1" || menuC == "2" || menuC == "3" || menuC == "4" || menuC == "5")
            {
                switch (menuC)
                {
                    case "1":
                        // sort in ascending
                        Program.option = "Ascending";
                        mainMenu3();
                        break;
                    case "2":
                        // sort in descending
                        Program.option = "Descending";
                        mainMenu3();
                        break;
                    case "3":
                        // search files and data
                        Program.option = "Search"; Console.Write(" Please enter what you would like to search for (as it would appere in the file): ");
                        Program.searchValue = Console.ReadLine();
                        results();
                        break;
                    case "4":
                        // search month
                        Program.option = "Search_Month";
                        Program.fileNum = 1;
                        Console.Write(" Please enter the month number you would like e.g 12 for December: ");
                        Program.searchValue = Console.ReadLine();
                        if (Program.searchValue == "1")
                        {
                            Program.searchValue = "January ";
                        }
                        else if (Program.searchValue == "2")
                        {
                            Program.searchValue = "Febuary ";
                        }
                        else if (Program.searchValue == "3")
                        {
                            Program.searchValue = "March ";
                        }
                        else if (Program.searchValue == "4")
                        {
                            Program.searchValue = "April ";
                        }
                        else if (Program.searchValue == "5")
                        {
                            Program.searchValue = "May ";
                        }
                        else if (Program.searchValue == "6")
                        {
                            Program.searchValue = "June ";
                        }
                        else if (Program.searchValue == "7")
                        {
                            Program.searchValue = "July ";
                        }
                        else if (Program.searchValue == "8")
                        {
                            Program.searchValue = "August ";
                        }
                        else if (Program.searchValue == "9")
                        {
                            Program.searchValue = "September ";
                        }
                        else if (Program.searchValue == "10")
                        {
                            Program.searchValue = "October";
                        }
                        else if (Program.searchValue == "11")
                        {
                            Program.searchValue = "November";
                        }
                        else if (Program.searchValue == "12")
                        {
                            Program.searchValue = "December ";
                        }
                        else
                        {
                            mainMenu2();
                        }
                        results();
                        break;
                    case "5":
                        // back
                        mainMenu();
                        break;
                    default:
                        break;
                }
            }

            else
            {
                validationFailure = true;
                mainMenu2();
            }
        }

        // ===========================
        //  Third stage of the menu
        // ===========================

        public void mainMenu3()
        {
            //clear the screen
            Console.Clear();
            // set string for user input and allow for if the user puts in incorrect values
            string menuC = "0";
            // display the new interface for file checking
            Console.WriteLine("Search and Sort (Seismic Data) v1. By Mitch Durso");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("##########                                What would you like to analyse?                                   ##########");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            // the choices
            Console.WriteLine("    Please enter the number for the choice you would like to analyse or search: ");
            Console.WriteLine("     1. Year.");
            Console.WriteLine("     2. Month.");
            Console.WriteLine("     3. Day.");
            Console.WriteLine("     4. Time.");
            Console.WriteLine("     5. Magnitude.");
            Console.WriteLine("     6. Latitude.");
            Console.WriteLine("     7. Longitude.");
            Console.WriteLine("     8. Depth.");
            Console.WriteLine("     9. Region.");
            Console.WriteLine("     10. IRIS_ID.");
            Console.WriteLine("     11. Timestamp.");
            Console.WriteLine("     12. Back.\n");
            if (validationFailure == true)
            {
                Console.WriteLine("\n Please Enter a valid value!");
            }
            // get user input and store
            menuC = Console.ReadLine();

            // check user input against switch case otherwise default will run the main menu again with a clean slate and an error message
            if (menuC == "1" || menuC == "2" || menuC == "3" || menuC == "4" || menuC == "5" || menuC == "6" || menuC == "7" || menuC == "8" || menuC == "9" || menuC == "10" || menuC == "11" || menuC == "12")
            {
                switch (menuC)
                {
                    case "1":
                        // Year
                        Program.fileNum = 0;
                        results();
                        break;
                    case "2":
                        // Month
                        Program.fileNum = 1;
                        results();
                        break;
                    case "3":
                        // Day
                        Program.fileNum = 2;
                        results();
                        break;
                    case "4":
                        // Time
                        Program.fileNum = 3;
                        results();
                        break;
                    case "5":
                        // Magnitude
                        Program.fileNum = 4;
                        results();
                        break;
                    case "6":
                        // Latitude
                        Program.fileNum = 5;
                        results();
                        break;
                    case "7":
                        // Longitude
                        Program.fileNum = 6;
                        results();
                        break;
                    case "8":
                        // Depth
                        Program.fileNum = 7;
                        results();
                        break;
                    case "9":
                        // Region
                        Program.fileNum = 8;
                        results();
                        break;
                    case "10":
                        // IRIS_ID
                        Program.fileNum = 9;
                        results();
                        break;
                    case "11":
                        // Timestamp
                        Program.fileNum = 10;
                        results();
                        break;
                    case "12":
                        // Back
                        mainMenu2();
                        break;
                    default:
                        break;
                }
            }

            else
            {
                validationFailure = true;
                mainMenu3();
            }
        }

        // ===========================
        //  Help menu
        // ===========================

        public void results()
        {
            //clear the screen
            Console.Clear();
            // display the new interface for file checking
            Console.WriteLine("Search and Sort (Seismic Data) v1. By Mitch Durso");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("##########                                            Results!                                              ##########");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            // the info
            Analysis.results();
            Console.ReadLine();
        }

        // ===========================
        //  Help menu
        // ===========================

        public void helpMenu()
        {
            //clear the screen for a fresh start
            Console.Clear();

            // create the visual menu to help them
            Console.WriteLine("Search and Sort (Seismic Data) v1. By Mitch Durso");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("##########                      Help!                     ##########");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("     1. Put all files in the Files Folder.");
            Console.WriteLine("     2. Ensure they are named (where * is a number Must be the same \n        for all files corrosponding to each other):");
            Console.WriteLine("         Year_*.txt, Month_*.txt, Day_*.txt, Time_*.txt");
            Console.WriteLine("         Magnitude_*.txt, Latitude_*.txt, Longitude_*.txt");
            Console.WriteLine("         Depth_*.txt, Region_*.txt, IRIS_ID_*.txt, Timestamp_*.txt");
            Console.WriteLine("     3. Run the Program and select the option depening on the number");
            Console.WriteLine("        of your files.");
            Console.WriteLine("     4. Check all files are found.");
            Console.WriteLine("     5. Do what you would like to do in the next menu.\n");
            Console.WriteLine("     Press Enter to return to the main menu.");
            Console.ReadLine();
            mainMenu();
        }
    }
}
