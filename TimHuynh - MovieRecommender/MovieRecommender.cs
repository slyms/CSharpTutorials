using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//X - include Excel DLL
using Microsoft.Office.Interop.Excel;
//XVII - Path Class
using System.IO;
//XXIV - COMException
using System.Runtime.InteropServices;
//XXVIII - RuntimeBinderException
using Microsoft.CSharp.RuntimeBinder;
//XXXII - Excel processes
using System.Diagnostics;

namespace TimHuynh___MovieRecommender
{
    //III
    //Static = it is not to be instantiated by Objects, eg. Movie.cs
    //It is a utility Class - provides necessary functions
    public static class MovieRecommender
    {
        //IV
        //List will receive data from Excel file
        //Public = Program.cs will have to access it
        //private set = List should not be reset by Program.cs
        public static List<Movie> MostPopularMovies2017 { get; private set; }

        //V
        //Stores movies recommended to user
        //Private = should not be available for the Client code
        //List is a Field - accessor methods are not specified = it is not exposed to Program.cs
        private static List<Movie> myRecommendedMovies;

        //VI
        //Method to instantiate two Movie<List>
        //Private = allow to call the Method only be Members of the same Class
        //Void = doesn't return any Value
        private static void InstantiateLists()
        {
            //Initialization
            MostPopularMovies2017 = new List<Movie>();
            myRecommendedMovies = new List<Movie>();
        }

        //IX
        public static bool ImportExcelMovieFile()
        {
            //XI
            //Initialization of both lists
            InstantiateLists();
            
            //XII
            //Friendly message while loading data
            Console.WriteLine("Grabbing movies from Excel file...");

            //XIII
            //Result of importing Excel - turns to false if Exception occurs
            var result = true;

            //XIV
            //3 Objects - to let App read from Excel file
            Application oExcel = null;
            Workbook wb = null;
            Worksheet wks = null;

            //XXII
            try
            {
                //XV
                //Instatiation of Object
                oExcel = new Application();

                //XVI
                /*Open Excel workbook - string Object
                @ - verbatim string literal - a string that does not need to be escaped, escape signs are ignored
                string filePath = @"D:\2017.02.03\Education\VisualStudio\C Sharp Projects\C Sharp Tutorials\TimHuynh - MovieRecommender\App_Data\MovieListImport.xlsx";
                Method to get relative path - program runs from: TimHuynh - MovieConsoleApp\bin\Debug
                */
                string filePath = Path.GetFullPath(@"..\..\App_Data\MovieListImport.xlsx");

                //XVIII
                //Open Excel
                wb = oExcel.Workbooks.Open(filePath);

                //XIX
                //Assign worksheet
                //[1] - open 1st worksheet, in Interop.Excel index starts from 1
                wks = wb.Worksheets[0];

                //XX
                //Object - store rows & columns that have values
                var usedRange = wks.UsedRange;

                //XXI
                //Loop - go thru all rows
                //r = 2 - r = 1 = header
                for (var r = 2; r <= usedRange.Rows.Count; r++)
                {
                    //New Object
                    Movie coolMovie = new Movie
                    {
                        //[r, 1] - current row, column = 1
                        //ToString() - convert dynamic Excel type to MovieName's data type
                        MovieName = wks.Cells[r, 1].Value.ToString(),
                        Genre = wks.Cells[r, 2].Value.ToString(),
                        //Convert from string to double
                        IMDbRating = Double.Parse(wks.Cells[r, 3].Value.ToString())
                    };
                    //Add coolMovie Object to list
                    MostPopularMovies2017.Add(coolMovie);
                }
            }
            //XXIII
            //Error with reading Excel
            catch(COMException ex)
            {
                //Method - save Exception details
                WriteToLogFile(ex.ToString());
                //XXV
                //false = failed ImportExcel task
                result = false;
            }
            //XXVI
            //Error when IMDb Rating can't be formated to Double value
            catch (FormatException ex)
            {
                WriteToLogFile(ex.ToString());
                result = false;
            }
            //XXVII
            //Error when data is invalid (eg. empty)
            catch (RuntimeBinderException ex)
            {
                WriteToLogFile(ex.ToString());
                result = false;
            }
            finally
            {
                //XXX
                //Make App exit Excel Object
                if(wb != null)
                {
                    wb.Close();
                }
                if(oExcel != null)
                {
                    oExcel.Quit();
                }
                //XXXI
                //Terminate Excel processes
                var excelProcs = Process.GetProcessesByName("EXCEL");
                foreach(var proc in excelProcs)
                {
                    proc.Kill();
                }
            }
            //Will be true if no Exception is catched
            return result;
        }

        //XXIV
        //Method signature <- Ctrl+. <- WriteToLogFile(ex.ToString());
        private static void WriteToLogFile(string exception)
        {
            //XXVIII
            //Log path
            var logFilePath = @"..\..\Log\Log.txt";
            //XXIX
            //Write to log file
            //using - encapsulate the Object; will automatically flush, close the file stream & dispose Stream Object
            //bool - if true, messages appended at the end of file, if false - current text will be removed
            using (StreamWriter file = new StreamWriter(logFilePath, true))
            {
                //$ - interpolated string syntax; { } - C# Objects
                file.WriteLine($"[EXCEPTION DETAILS]: {exception}, [DATE]: {DateTime.Now}");
            }
        }
    }
}
