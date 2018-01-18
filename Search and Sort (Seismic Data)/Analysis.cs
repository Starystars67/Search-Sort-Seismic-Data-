using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_and_Sort__Seismic_Data_
{
    class Analysis
    {
        public static string fileChoice = "";
        public static string option = "";

        public static void results()
        {
            // get results for selection
            switch (Program.option)
            {
                case "Ascending":
                    sortArrayByFile();
                    break;
                case "Descending":
                    sortArrayByFile();
                    break;
                case "Search":
                    searchFileInArray();
                    Console.ReadLine();
                    break;
                case "Search_Month":
                    searchFileInArray();
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }

        public static void sortArrayByFile()
        {
            // BUBBLE SORT
            // create intger for the array size
            int arraySize = Program.fileData.Length - 1;
            // for each in the array size do the following
            for (int i = 0; i < arraySize; i++)
            {
                // for each of the indevidual for each (Due to the list of list) do this
                for (int j = arraySize; j > i; j--)
                {
                    // if we are x then do y else remain the same
                    if (((IComparable)Program.fileData[j-1][Program.fileNum]).CompareTo(Program.fileData[j][Program.fileNum]) > 0)
                    {
                        // change the order
                        string[] tempVal = { Program.fileData[j-1][0] , Program.fileData[j-1][1] , Program.fileData[j-1][2] , Program.fileData[j-1][3] , Program.fileData[j-1][4] , Program.fileData[j-1][5] , Program.fileData[j-1][6] , Program.fileData[j-1][7] , Program.fileData[j-1][8] , Program.fileData[j-1][9] , Program.fileData[j-1][10] };
                        Program.fileData[j - 1][0] = Program.fileData[j][0];
                        Program.fileData[j - 1][1] = Program.fileData[j][1];
                        Program.fileData[j - 1][2] = Program.fileData[j][2];
                        Program.fileData[j - 1][3] = Program.fileData[j][3];
                        Program.fileData[j - 1][4] = Program.fileData[j][4];
                        Program.fileData[j - 1][5] = Program.fileData[j][5];
                        Program.fileData[j - 1][6] = Program.fileData[j][6];
                        Program.fileData[j - 1][7] = Program.fileData[j][7];
                        Program.fileData[j - 1][8] = Program.fileData[j][8];
                        Program.fileData[j - 1][9] = Program.fileData[j][9];
                        Program.fileData[j - 1][10] = Program.fileData[j][10];
                        Program.fileData[j] = tempVal;
                    }
                }
            }



            // sort the array based on the file and option of ascending or descending
            //////////
            // ISSUE TRACKING WHEN SORTING BY DAY IT GOES 1 , 10, 11, 12, 13, 14, 15.... 20, 21 INSTEAD OF  1,2,3,4 :/
            //////////
            if (Program.option == "Ascending")
            {
                // ASCENDING 
                Console.WriteLine("");
                Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,8}|{4,10}|{5,7}|{6,7}|{7,8}|{8,29}|{9,8}|{10,10}", Program.files[0], Program.files[1], Program.files[2], Program.files[3], Program.files[4], Program.files[5], Program.files[6], Program.files[7], Program.files[8], Program.files[9], Program.files[10]);
                Console.WriteLine("======================================================================================================================");
                for (int i = 0; i < Program.fileData.GetLength(0); i++)
                {
                    Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,5}|{4,10}|{5,8}|{6,9}|{7,8}|{8,29}|{9,8}|{10,10}", Program.fileData[i][0], Program.fileData[i][1], Program.fileData[i][2], Program.fileData[i][3], Program.fileData[i][4], Program.fileData[i][5], Program.fileData[i][6], Program.fileData[i][7], Program.fileData[i][8], Program.fileData[i][9], Program.fileData[i][10]);
                }
            }
            else if (Program.option == "Descending")
            {
                // DESCENDING
                Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,8}|{4,10}|{5,7}|{6,7}|{7,8}|{8,29}|{9,8}|{10,10}", Program.files[0], Program.files[1], Program.files[2], Program.files[3], Program.files[4], Program.files[5], Program.files[6], Program.files[7], Program.files[8], Program.files[9], Program.files[10]);
                Console.WriteLine("======================================================================================================================");

                for (int i = arraySize,j = 0; j < Program.fileData.Length; i--, j++)
                {
                    Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,5}|{4,10}|{5,8}|{6,9}|{7,8}|{8,29}|{9,8}|{10,10}", Program.fileData[i][0], Program.fileData[i][1], Program.fileData[i][2], Program.fileData[i][3], Program.fileData[i][4], Program.fileData[i][5], Program.fileData[i][6], Program.fileData[i][7], Program.fileData[i][8], Program.fileData[i][9], Program.fileData[i][10]);
                }
            }
            // display the result
        }

        public static void searchFileInArray()
        {
            if (Program.option == "Search")
            {
                bool dataFound = false;
                // Search All files  
                // create menu header
                Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,8}|{4,10}|{5,7}|{6,7}|{7,8}|{8,29}|{9,8}|{10,10}", Program.files[0], Program.files[1], Program.files[2], Program.files[3], Program.files[4], Program.files[5], Program.files[6], Program.files[7], Program.files[8], Program.files[9], Program.files[10]);
                Console.WriteLine("======================================================================================================================");
                for (int i = 0; i < Program.fileData.GetLength(0); i++)
                {
                    if (Program.searchValue == Program.fileData[i][0] || Program.searchValue == Program.fileData[i][1] || Program.searchValue == Program.fileData[i][2] || Program.searchValue == Program.fileData[i][3] || Program.searchValue == Program.fileData[i][4] || Program.searchValue == Program.fileData[i][5] || Program.searchValue == Program.fileData[i][6] || Program.searchValue == Program.fileData[i][7] || Program.searchValue == Program.fileData[i][8] || Program.searchValue == Program.fileData[i][9] || Program.searchValue == Program.fileData[i][10])
                    {
                        Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,5}|{4,10}|{5,8}|{6,9}|{7,8}|{8,29}|{9,8}|{10,10}", Program.fileData[i][0], Program.fileData[i][1], Program.fileData[i][2], Program.fileData[i][3], Program.fileData[i][4], Program.fileData[i][5], Program.fileData[i][6], Program.fileData[i][7], Program.fileData[i][8], Program.fileData[i][9], Program.fileData[i][10]);
                        dataFound = true;
                    }
                }

                if (dataFound == false)
                {
                    Console.WriteLine("Sorry no data found for your search term: '{0}'", Program.searchValue);
                }
            }
            else if (Program.option == "Search_Month")
            {
                bool dataFound = false;
                // search Month
                // create menu header
                Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,8}|{4,10}|{5,7}|{6,7}|{7,8}|{8,29}|{9,8}|{10,10}", Program.files[0], Program.files[1], Program.files[2], Program.files[3], Program.files[4], Program.files[5], Program.files[6], Program.files[7], Program.files[8], Program.files[9], Program.files[10]);
                Console.WriteLine("======================================================================================================================");
                for (int i = 0; i < Program.fileData.GetLength(0); i++)
                {
                    if (Program.fileData[i][1] == Program.searchValue)
                    {
                        Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,5}|{4,10}|{5,8}|{6,9}|{7,8}|{8,29}|{9,8}|{10,10}", Program.fileData[i][0], Program.fileData[i][1], Program.fileData[i][2], Program.fileData[i][3], Program.fileData[i][4], Program.fileData[i][5], Program.fileData[i][6], Program.fileData[i][7], Program.fileData[i][8], Program.fileData[i][9], Program.fileData[i][10]);
                        dataFound = true;
                    }
                }

                if (dataFound == false)
                {
                    Console.WriteLine("Sorry no data found for your search term: '{0}'", Program.searchValue);
                }
        }
        }
    }
}
