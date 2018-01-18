using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_and_Sort__Seismic_Data_
{
    class FileManagement
    {
        public static bool allFileExist = false;
        public void checkFile()
        {
            int fileCount = 0;
            string confirm = "";
            //clear the screen for a fresh start
            Console.Clear();
            // display the new interface for file checking
            Console.WriteLine("Search and Sort (Seismic Data) v1. By Mitch Durso");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("##########           File Finding and Checking!           ##########");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            for (int x = 0; x < Program.files.Length; x++) {
                string path = "Files/" + Program.files[x] + "_" + Program.fileGroupNum + Program.extension;
                if (File.Exists(path))
                {
                    Console.WriteLine("     {0}{1} Found!", Program.files[x],"_" + Program.fileGroupNum + Program.extension);
                    fileCount++;
                }
                else
                {
                    Console.WriteLine("     {0}{1} NOT FOUND!", Program.files[x], "_" + Program.fileGroupNum + Program.extension);
                }
            }
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("A total of {0} files were found and listed above, are these correct?", fileCount);
            Console.WriteLine("Please enter yes to continue or no to re-search for the files.");
            if (fileCount != 11)
            {
                Console.WriteLine("\nIf the error persists please check you have named your files\ncorrectly according to the help menu.");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            confirm = Console.ReadLine();
            if (confirm == "yes" || confirm == "")
            {
                readFileToList();
            }
            else
            {
                checkFile();
            }
        }
        public void readFileToList()
        {
            //clear the screen for a fresh start
            Console.Clear();
            // display the new interface for file checking
            Console.WriteLine("Search and Sort (Seismic Data) v1. By Mitch Durso");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("##########                                            Reading Files!                                        ##########");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            // create header
            Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,8}|{4,10}|{5,7}|{6,7}|{7,8}|{8,29}|{9,8}|{10,10}", Program.files[0], Program.files[1], Program.files[2], Program.files[3], Program.files[4], Program.files[5], Program.files[6], Program.files[7], Program.files[8], Program.files[9], Program.files[10]);
            Console.WriteLine("======================================================================================================================");
            
            // set the counter and temp string for storing the line
            int iteration = 0;
            string lineYear;
            string lineMonth;
            string lineDay;
            string lineTime;
            string lineMagnitude;
            string lineLatitude;
            string lineLongitude;
            string lineDepth;
            string lineRegion;
            string lineIRIS_ID;
            string lineTimestamp;

            // Read the file and display it line by line.
            System.IO.StreamReader year = new System.IO.StreamReader("Files/" + Program.files[0] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader month = new System.IO.StreamReader("Files/" + Program.files[1] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader day = new System.IO.StreamReader("Files/" + Program.files[2] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader time = new System.IO.StreamReader("Files/" + Program.files[3] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader magnitude = new System.IO.StreamReader("Files/" + Program.files[4] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader latitude = new System.IO.StreamReader("Files/" + Program.files[5] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader longitude = new System.IO.StreamReader("Files/" + Program.files[6] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader depth = new System.IO.StreamReader("Files/" + Program.files[7] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader region = new System.IO.StreamReader("Files/" + Program.files[8] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader iris_id = new System.IO.StreamReader("Files/" + Program.files[9] + "_" + Program.fileGroupNum + Program.extension);
            System.IO.StreamReader timestamp = new System.IO.StreamReader("Files/" + Program.files[10] + "_" + Program.fileGroupNum + Program.extension);
            // read each line
            while ((lineYear = year.ReadLine()) != null)
            {
                // read the lines in the file
                lineMonth = month.ReadLine();
                lineDay = day.ReadLine();
                lineTime = time.ReadLine();
                lineMagnitude = magnitude.ReadLine();
                lineLatitude = latitude.ReadLine();
                lineLongitude = longitude.ReadLine();
                lineDepth = depth.ReadLine();
                lineRegion = region.ReadLine();
                lineIRIS_ID = iris_id.ReadLine();
                lineTimestamp = timestamp.ReadLine();
                //print them to screen as they are read so the user can see them
                Console.WriteLine(" {0,4}|{1,10}|{2,3}|{3,5}|{4,10}|{5,8}|{6,9}|{7,8}|{8,29}|{9,8}|{10,10}", lineYear, lineMonth, lineDay, lineTime, lineMagnitude, lineLatitude, lineLongitude, lineDepth, lineRegion, lineIRIS_ID, lineTimestamp);
                List<string> line = new List<string>();
                // add them to the list
                line.Add(lineYear);
                line.Add(lineMonth);
                line.Add(lineDay);
                line.Add(lineTime);
                line.Add(lineMagnitude);
                line.Add(lineLatitude);
                line.Add(lineLongitude);
                line.Add(lineDepth);
                line.Add(lineRegion);
                line.Add(lineIRIS_ID);
                line.Add(lineTimestamp);
                Program.fileInfoList.Add(line);
                iteration++;
            }

            // close all the files
            year.Close();
            month.Close();
            day.Close();
            time.Close();
            magnitude.Close();
            latitude.Close();
            longitude.Close();
            depth.Close();
            region.Close();
            iris_id.Close();
            timestamp.Close();
            // pint amount of lines
            Console.WriteLine("There are {0} records.", iteration);
            Console.WriteLine("Does this all look correct?");
            // check user is happy with the infomation
            string confirm = "";
            Console.WriteLine("Please enter yes to continue or no to re-read the files.");
            confirm = Console.ReadLine();
            if (confirm == "yes" || confirm == "")
            {
                listToArray();
            }
            else
            {
                readFileToList();
            }
        }
        public void listToArray()
        {
            // convert list  into array
            Program.fileData = Program.fileInfoList.Select(a => a.ToArray()).ToArray();
            if (Program.fileGroupNum == 1)
            {
                Program.arrayRead = 1;
            }
            else if (Program.fileGroupNum == 2)
            {
                Program.arrayRead = 2;
            }
            else if (Program.fileGroupNum == 3)
            {
                Program.arrayRead = 3;
            }
            Console.WriteLine("Files ready for analysis. Press enter to continue");
            Console.ReadLine();
        }
    }
}
