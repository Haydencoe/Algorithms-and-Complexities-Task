using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; //for stopwatch
using System.Threading; //for thread.sleep

/*
 * This is the class dedicated to the sorting algorithms that you need to provide and test
 * There is no need to change this code as it is not part of the assessment
 */

namespace AlgorithmAss1
{
    class SortingAlgorithms
    {
        #region class variables
        //**************** CLASS VARIABLES *************
        // Timespan is required to provide the time taken by the algoritms
        private List<TimeSpan> timesTaken;
        private List<string> testName;
        //The stopwatch attribute is used in the timing of the algorithms
        private Stopwatch stopWatch;
        #endregion class variables
        public SortingAlgorithms()
        {
            //constructor for the algorithm object
            timesTaken = new List<TimeSpan>();
            testName = new List<string>();
            stopWatch = new Stopwatch();
        }
        /* ********************************************************
         * This is where you must create the required Algorithms  *
         * ********************************************************/
        #region Option 1. List Date Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option Option 1. List Date Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects called 'listToSort'</para>
        /// </summary>
        public List<StoredData> sortDateAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //###################################################################################
            //Place your first algorithm to sort by the date in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //###################################################################################
            
            //sort all data listtosort.[i].(txday) 
            
           //Bubble sort:

            StoredData temp;

           
            for (int i = 1; i <= listToSort.Count; i++)//loops through the full list of data 
            {
                for (int j = 0; j < listToSort.Count - i; j++)//steps through the next iteration to compare to
                {
                    if (listToSort[j].TxDate > listToSort[j + 1].TxDate) //Ascending date order
                    {
                        //compare the two numbers swop them if necessary 
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                    } 
                }

                countOfRepetitions++;
            }


            //###################################################################################
            //Place your first algorithm to sort by the date in ASCENDING order above here
            //###################################################################################
            listToSort.First().SearchTypeAndTime = "Using 'Bubble Sort A1' sort Date Ascending";//*** Change 'DateAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort; 
        }
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option Option 1. List Date Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects called 'listToSort'</para>
        /// </summary>
        public List<StoredData> sortDateAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0;
            // use this to hold the number of repetitions your algorithm has to make to sort the data

            //###################################################################################
            //Place your second algorithm to sort by the date in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //###################################################################################


            //Merge sort

            countOfRepetitions = MergeSortDate(listToSort, 0, listToSort.Count - 1, countOfRepetitions);//calls the merge method

           

            //###################################################################################
            //Place your second algorithm to sort by the date in ASCENDING order above here
            //###################################################################################
            listToSort.First().SearchTypeAndTime = "Using 'Merge Sort A2' sort Date Ascending";//*** Change 'DateAscAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        #endregion Option 1.
        /**********************************************************************************************************************/
        #region Option 2. List Date Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        //Option 2. List Date Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in descending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects called 'listToSort'</para>
        /// </summary>
        public List<StoredData> sortDateDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 

            //###################################################################################
            //Place your first algorithm to sort by the date in DECENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //##################################################################################


            //Bubble sort:

            StoredData temp;


            for (int i = 1; i <= listToSort.Count; i++)//loops through the full list of data 
            {
                for (int j = 0; j < listToSort.Count - i; j++)//steps through the next iteration to compare to
                {
                    if (listToSort[j].TxDate < listToSort[j + 1].TxDate) //Decending date order
                    {
                        //compare the two numbers swop them if necessary 
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                    }
                }

                countOfRepetitions++;
            }


            //###################################################################################
            //Place your second algorithm to sort by the date in DECENDING order above here
            //###################################################################################
            //// *** Place your algorithm to sort the data above here

            listToSort.First().SearchTypeAndTime = "Using 'Bubble A1' sort Date Descending"; //*** Change 'DateDesAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }

        


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        //Option 2. List Date Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in descending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects called 'listToSort'</para>
        /// </summary>
        public List<StoredData> sortDateDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
             //###################################################################################
             //Place your second algorithm to sort by the date in DECENDING order below here
             //This will be displayed on the right-hand-side of the console window
             //###################################################################################

           
           //Merge sort

            countOfRepetitions = MergeSortDate(listToSort, 0, listToSort.Count - 1, countOfRepetitions); //calls the merge sort method

            listToSort.Reverse();


            //###################################################################################
            //Place your second algorithm to sort by the date in DECENDING order above here
            //###################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Merge A2' sort Date Descending"; //*** Change 'DateDesAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;  
            return listToSort;
        }
        #endregion Option 2.
        /**********************************************************************************************************************/
        #region Option 3. List Opening Price Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 3. List Opening Price Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' (Sh_open) attribute
        /// <para>You need to place the result into a List of StoredData objects</para>
        /// </summary>
        public List<StoredData> sortOpenAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the opening value (Sh_open) in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            
            //Bubble sort:

            StoredData temp;


            for (int i = 1; i <= listToSort.Count; i++)//loops through the full list of data 
            {
                for (int j = 0; j < listToSort.Count - i; j++)//steps through the next iteration to compare to
                {
                    if (listToSort[j].Sh_open > listToSort[j + 1].Sh_open) //Acending Opening price order
                    {
                        //compare the two numbers swop them if necessary 
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                    }
                }

                countOfRepetitions++;
            }


            //######################################################################################################
            //Place your first algorithm to sort by the the opening value (Sh_open) in ASCENDING order above here
            //######################################################################################################
            
            listToSort.First().SearchTypeAndTime = "Using 'Bubble A1' sort Open Ascending"; //*** Change 'DateDA2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort; 
        }

        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 3. List Opening Price Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬     
        public List<StoredData> sortOpenAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //###################################################################################
            //Place your second algorithm to sort by the the opening value (Sh_open) in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //###################################################################################
           

             //Quick Sort

             countOfRepetitions = quickSortOpening(listToSort, 0, listToSort.Count - 1, countOfRepetitions);//calls the quick sort method





            //######################################################################################################
            //Place your second algorithm to sort by the the opening value (Sh_open) in ASCENDING order above here
            //######################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Quick A2' sort Open Ascending"; //*** Change 'DateDA2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;
            return listToSort; 
        }
#endregion Sort the data Ascending by Opening Value
        /**********************************************************************************************************************/
        #region Option 4. List Opening Price Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 4. List Opening Price Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in Descending order by its 'Opening Value' attribute
        /// <para>You need to place the result into a List of StoredData objects</para>
        /// </summary>
        public List<StoredData> sortOpenDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the opening value (Sh_open) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
           

            //Bubble sort:

            StoredData temp;


            for (int i = 1; i <= listToSort.Count; i++)//loops through the full list of data 
            {
                for (int j = 0; j < listToSort.Count - i; j++)//steps through the next iteration to compare to
                {
                    if (listToSort[j].Sh_open < listToSort[j + 1].Sh_open) //Acending Opening Price order
                    {
                        //compare the two numbers swop them if necessary 
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                    }
                }

                countOfRepetitions++;
            }



            //######################################################################################################
            //Place your first algorithm to sort by the the opening value (Sh_open) in DESCENDING order above here
            //######################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Bubble A1' sort Open Descending"; //*** Change 'DateDA2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }

        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 4. List Opening Price Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortOpenDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the opening value (Sh_open) in DESCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
           

             //Quick Sort

             countOfRepetitions = quickSortOpening(listToSort, 0, listToSort.Count - 1, countOfRepetitions);//calls the quick sort method

            listToSort.Reverse();

            //######################################################################################################
            //Place your second algorithm to sort by the the opening value (Sh_open) in DESCENDING order above here
            //######################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Quick A2' sort Open Descending"; //*** Change 'DateDA2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;  
            return listToSort;
        }
        #endregion Option 4.
        /**********************************************************************************************************************/
        #region Option 5. List Closing Price Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 5. List Closing Price Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortCloseAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in ASSCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            


            countOfRepetitions = MergeSortClosing(listToSort, 0, listToSort.Count - 1, countOfRepetitions);//calls the merge sort method



            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in ASSCENDING order above here
            //#####################################################################################################

            //// *** Place your algorithm to sort the data above here

            listToSort.First().SearchTypeAndTime = "Using 'Merge A1' sort Close Ascending"; //*** Change 'CloseAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;  
            return listToSort; 
        }        

        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 5. List Closing Price Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortCloseAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the closing value (Sh_close) in ASCENDING order below here
            //This will be displayed on the righr-hand-side of the console window
            //#####################################################################################################
            
            //Quick Sort

             countOfRepetitions = quickSortClosing(listToSort, 0, listToSort.Count - 1, countOfRepetitions);//calls the quick sort method





            //#####################################################################################################
            //Place your second algorithm to sort by the the closing value (Sh_close) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Quick A2' sort Close Ascending"; //*** Change 'CloseAscAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 5.
        /**********************************************************************************************************************/
        #region Option 6. List Closing Price Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 6. List Closing Price Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in Descending order by its 'Opening Value' attribute
        /// <para>You need to place the result into a List of StoredData objects</para>
        /// </summary>
        public List<StoredData> sortCloseDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            
            //Merge sort

            countOfRepetitions = MergeSortClosing(listToSort, 0, listToSort.Count - 1, countOfRepetitions);//calls the the Merge sort method
            listToSort.Reverse();

            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in DESCENDING order above here
            //#####################################################################################################

            //// *** Place your algorithm to sort the data above here

            listToSort.First().SearchTypeAndTime = "Using 'Merge A1' sort Close Ascending"; //*** Change 'CloseAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort; 
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 6. List Closing Price Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortCloseDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the closing value (Sh_close) in DESCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
           
            //Quick sort

             countOfRepetitions = quickSortClosing(listToSort, 0, listToSort.Count - 1, countOfRepetitions); //calls the quick sort method
            listToSort.Reverse();

            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Quick A2' sort Close Ascending"; //*** Change 'CloseAscAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 6.
        /**********************************************************************************************************************/
        #region Option 7. List Volume of sales Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 7. List Volume of sales Ascending algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortVolAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
           
            //Quick Sort

             countOfRepetitions = quickSortVolume(listToSort, 0, listToSort.Count - 1, countOfRepetitions); //calls the quick sort method


            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Quick A1' sort Volume Ascending"; //*** Change 'VolAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }

        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 7. List Volume of sales Ascending algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortVolAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_volume) in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
           
            //Insertion sort

          int length = listToSort.Count;


          for (int i = 1; i < length; i++)//Loop through all the elemnts 
          {
             int j = i;

                //Loop, compare & swap if this element is less than any of it's left side elememts 

                while ((j > 0) && (listToSort[j].Sh_volume < listToSort[j - 1].Sh_volume))//Ascending volume of sales order

                {
                    //compare the two numbers swop them if necessary 
                    int k = j - 1;//move the elements
                    int temp = listToSort[k].Sh_volume;
                    listToSort[k].Sh_volume = listToSort[j].Sh_volume;
                    listToSort[j].Sh_volume = temp;

                    j--;
               }

                countOfRepetitions++;
            }




            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_volume) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion A2' sort Volume Ascending"; //*** Change 'VolumeAscAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 7. 

        /**********************************************************************************************************************/
        #region Option 8. List List Volume of sales Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 8. List List Volume of sales Descending algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortVolDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            
             //Quick Sort

             countOfRepetitions = quickSortVolume(listToSort, 0, listToSort.Count - 1, countOfRepetitions);//calls the quick sort method
            listToSort.Reverse();


            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Quick A1' sort Volume Descending"; //*** Change 'VolDescAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 8. List List Volume of sales Descending algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortVolDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_volume) in DESCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
           
           //Insertion sort

          int length = listToSort.Count;


          for (int i = 1; i < length; i++)//Loop through all the elemnts 
          {
             int j = i;

                //Loop, compare & swap if this element is less than any of it's right side elememts 

                while ((j > 0) && (listToSort[j].Sh_volume > listToSort[j - 1].Sh_volume))//Decending volume of sales order

                {
                    //compare the two numbers swop them if necessary 
                    int k = j - 1;//move the elements
                    int temp = listToSort[k].Sh_volume;
                    listToSort[k].Sh_volume = listToSort[j].Sh_volume;
                    listToSort[j].Sh_volume = temp;

                    j--;
               }

                countOfRepetitions++;
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion A2' sort Volume Descending"; //*** Change 'VolumeDescAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 8. 
        /**********************************************************************************************************************/
        #region Option 9. List difference of sales Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 9. List difference of sales Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDiffAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            
             
            //Insertion sort

          int length = listToSort.Count;


          for (int i = 1; i < length; i++)//Loop through all the elemnts 
          {
             int j = i;

                //Loop, compare & swap if this element is less than any of it's right side elememts 

                while ((j > 0) && (listToSort[j].Sh_diff < listToSort[j - 1].Sh_diff))//Acending difference of sales order

                {
                    //compare the two numbers swop them if necessary 
                    int k = j - 1;//move the elements
                    double temp = listToSort[k].Sh_diff;
                    listToSort[k].Sh_diff = listToSort[j].Sh_diff;
                    listToSort[j].Sh_diff = temp;

                    j--;
               }

                countOfRepetitions++;
            }
          

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion A1' sort Difference Ascending"; //*** Change 'DiffAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 9. List difference of sales Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDiffAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_diff) in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
           
            //Merge sort

             countOfRepetitions = MergeSortDifference(listToSort, 0, listToSort.Count - 1, countOfRepetitions); //calls the Merge sort method

          

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Merge A2' sort Difference Ascending"; //** Change 'DiffAscAlg2' for the algorithm used by you ***
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;  
            return listToSort;
        }
        #endregion Option 9.
        /**********************************************************************************************************************/
        #region Option 10. List difference of sales Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 10. List difference of sales Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDiffDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            
              //Insertion sort

          int length = listToSort.Count;


          for (int i = 1; i < length; i++)//Loop through all the elemnts 
          {
             int j = i;

                //Loop, compare & swap if this element is less than any of it's right side elememts 

                while ((j > 0) && (listToSort[j].Sh_diff > listToSort[j - 1].Sh_diff))//Decending difference of sales order

                {
                    //compare the two numbers swop them if necessary 
                    int k = j - 1;//move the elements
                    double temp = listToSort[k].Sh_diff;
                    listToSort[k].Sh_diff = listToSort[j].Sh_diff;
                    listToSort[j].Sh_diff = temp;

                    j--;
               }

                countOfRepetitions++;
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion A1' sort Difference Descending"; //*** Change 'DiffDescAlg1' for the algorithm used by you ***
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 10. List difference of sales Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDiffDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_diff) in DESCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
            

             //Merge sort

             countOfRepetitions = MergeSortDifference(listToSort, 0, listToSort.Count - 1, countOfRepetitions); //calls the Merge sort method

             listToSort.Reverse();


            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Merge A2' sort Difference Descending"; //***Change 'DiffDescAlg2' for the algorithm used by you ***
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 10.
        /**********************************************************************************************************************/
        #region Option 11. List days Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 11. List days Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬


        public List<StoredData> sortDayAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //Remember the order is to be by day order - Mon, Tues, Wed ... not Alphabetical
            //#####################################################################################################
            //Place your first algorithm to sort by the the Day value (TxDay) in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            
            
            //Bubble sort

            StoredData temp;

            // foreach(int i in a)
            for (int i = 1; i <= listToSort.Count; i++)//loops through the full list of data 
            {
                for (int j = 0; j < listToSort.Count - i; j++)//steps through the next iteration to compare to
                {
                    if (ValueDay(listToSort[j].TxDay) > ValueDay(listToSort[j + 1].TxDay))  //Acending day order
                    {
                        //compare the two numbers swop them if necessary 
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                    }
                   
                }

                countOfRepetitions++;
            }


            //#####################################################################################################
            //Place your first algorithm to sort by the the Day value (TxDay) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Bubble A1' sort Day Ascending"; //*** Change 'DayAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data

            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 11. List days Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDayAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //Remember the order is to be by day order - Mon, Tues, Wed ... not Alphabetical
            //#####################################################################################################
            //Place your second algorithm to sort by the the Day value (TxDay) in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
           
            //Insertion Sort adapted for day of the week processing

            double leftHandSide, rightHandSide;
            string close1, close2;
            //Create holder for data to be swapped
            StoredData data1 = null;
            List<StoredData> insertionSortedData = new List<StoredData>();
            insertionSortedData.Add(listToSort[0]); //place 1st value into list
            //loop through the data swapping by day into Ascending order
            for (int index = 1; index < listToSort.Count; index++)
            {
                insertionSortedData.Add(listToSort[index]);
                //shuffle new element into its correct poistion
                for (int i = insertionSortedData.Count - 1; i > 0; i--) // sort it into its correct position
                {

                    close1 = insertionSortedData[i - 1].TxDay;
                    leftHandSide = ValueDay(close1);
                    close2 = insertionSortedData[i].TxDay;
                    rightHandSide = ValueDay(close2);
                    if (leftHandSide > rightHandSide)
                    {
                        //swap the 2 elements over  
                        data1 = insertionSortedData.ElementAt(i - 1);
                        insertionSortedData[i - 1] = insertionSortedData.ElementAt(i);
                        insertionSortedData[i] = data1;
                    }
                    else
                    {
                        break;//escape loop once the new element is in its correct position and get the next element
                    }
                }

                countOfRepetitions++;
            }

            for (int i = 0; i < insertionSortedData.Count; i++)
            {
                listToSort[i] = insertionSortedData[i];
            }


            //#####################################################################################################
            //Place your second algorithm to sort by the the Day value (TxDay) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion A2' sort Day Ascending"; //*** Change 'DiffDayAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        #endregion Option 11.
        /**********************************************************************************************************************/
        #region Option 12. List days Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 12. List days Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDayDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //Remember the order is to be by day order - Mon, Tues, Wed ... not Alphabetical
            //#####################################################################################################
            //Place your first algorithm to sort by the the Day value (TxDay) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            
             //Bubble sort

            StoredData temp;

            // foreach(int i in a)
            for (int i = 1; i <= listToSort.Count; i++)//loops through the full list of data 
            {
                for (int j = 0; j < listToSort.Count - i; j++)//steps through the next iteration to compare to
                {
                    if (ValueDay(listToSort[j].TxDay) < ValueDay(listToSort[j + 1].TxDay))  //Decending day order
                    {
                        //compare the two numbers swop them if necessary 
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                    }
                   
                }

                countOfRepetitions++;
            }

            


            //#####################################################################################################
            //Place your first algorithm to sort by the the Day value (TxDay) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Bubble A1' sort Day Descending"; //*** Change 'DayDescAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data

            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 12. List days Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDayDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //Remember the order is to be by day order - Mon, Tues, Wed ... not Alphabetical
            //#####################################################################################################
            //Place your second algorithm to sort by the the Day value (TxDay) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            

              
            //Insertion Sort adapted for day of the week processing

             double leftHandSide, rightHandSide;
            string close1, close2;
            //Create holder for data to be swapped
            StoredData data1 = null;
            List<StoredData> insertionSortedData = new List<StoredData>();
            insertionSortedData.Add(listToSort[0]); //place 1st value into list
            //loop through the data swapping by day into descending order
            for (int index = 1; index < listToSort.Count; index++)
            {
                insertionSortedData.Add(listToSort[index]);
                //shuffle new element into its correct poistion
                for (int i = insertionSortedData.Count - 1; i > 0; i--) // sort it into its correct position 
                {
                    close1 = insertionSortedData[i - 1].TxDay;
                    leftHandSide = ValueDay(close1);
                    close2 = insertionSortedData[i].TxDay;
                    rightHandSide = ValueDay(close2);
                    if (leftHandSide < rightHandSide)
                    {
                        //swap the 2 elements over  
                        data1 = insertionSortedData.ElementAt(i - 1);
                        insertionSortedData[i - 1] = insertionSortedData.ElementAt(i);
                        insertionSortedData[i] = data1;
                    }
                    else
                    {
                        break;//escape loop once the new element is in its correct position and get the next element
                    }
                }

                countOfRepetitions++;

            }
            for (int i = 0; i < insertionSortedData.Count; i++)
            {
                listToSort[i] = insertionSortedData[i];
            }


            
           

                //#####################################################################################################
                //Place your second algorithm to sort by the the Day value (TxDay) in DESCENDING order above here
                //#####################################################################################################

                listToSort.First().SearchTypeAndTime = "Using 'Insertion A2' sort Day Descending"; //*** Change 'DiffDayDelg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        #endregion Option 12.
        /**********************************************************************************************************************/

        #region private methods



        public static int quickSortVolume(List<StoredData> data, int l, int r, int counter)//option 7 and 8
        {
             

            int i, j;
            int x, temporary; //pivot

            i = l;//left
            j = r;//right

            x = data[(l + r) / 2].Sh_volume; /* find pivot item */

            while (true)
            {
                while ((data[i].Sh_volume < x) && (i < r))
                    i++;

                while ((x < data[j].Sh_volume) && (j > l))
                    j--;

                if (i <= j)
                {
                    //performs swop
                    temporary = data[i].Sh_volume;
                    data[i].Sh_volume = data[j].Sh_volume;
                    data[j].Sh_volume = temporary;
                    i++;
                    j--;
                }
                if (i > j)
                    break;
                counter++;
            }

            //recursion part of the sort
            if (l < j)
                quickSortVolume(data, l, j, counter);
            if (i < r)
                quickSortVolume(data, i, r, counter);


            return counter;
        }

        
        public static int quickSortOpening(List<StoredData> data, int l, int r, int counter)//option 3 and 4
        {
            //int cycleCount = counter;

            int i, j;
            double x, temporary; //pivot

            i = l;//left
            j = r;//right

            x = data[(l + r) / 2].Sh_open; /* find pivot item */

            while (true)
            {
                while ((data[i].Sh_open < x) && (i < r))
                    i++;

                while ((x < data[j].Sh_open) && (j > l))
                    j--;

                if (i <= j)
                {
                    //performs swop 
                    temporary = data[i].Sh_open;
                    data[i].Sh_open = data[j].Sh_open;
                    data[j].Sh_open = temporary;
                    i++;
                    j--;
                }
                if (i > j)
                    break;
                counter++;
            }

            //recursion part of the sort
            if (l < j)
                quickSortOpening(data, l, j, counter);
            if (i < r)
                quickSortOpening(data, i, r, counter);


            return counter;
        }


        public static int quickSortClosing(List<StoredData> data, int l, int r, int counter)//option 3 and 4
        {
            //int cycleCount = counter;

            int i, j;
            double x, temporary; //pivot

            i = l;//left
            j = r;//right

            x = data[(l + r) / 2].Sh_close; /* find pivot item */

            while (true)
            {
                while ((data[i].Sh_close < x) && (i < r))
                    i++;

                while ((x < data[j].Sh_close) && (j > l))
                    j--;

                if (i <= j)
                {
                    //performs swop
                    temporary = data[i].Sh_close;
                    data[i].Sh_close = data[j].Sh_close;
                    data[j].Sh_close = temporary;
                    i++;
                    j--;
                }
                if (i > j)
                    break;
                counter++;
            }

            //recursion part of the sort
            if (l < j)
                quickSortClosing(data, l, j, counter);
            if (i < r)
                quickSortClosing(data, i, r, counter);


            return counter;
        }


        public static int MergeSortClosing(List<StoredData> input, int low, int high, int counter )
        {
            if (low < high)
            {
                //split the list
                int middle = (low / 2) + (high / 2); //centre index
                MergeSortClosing(input, low, middle, counter);//left side
                MergeSortClosing(input, middle + 1, high, counter);//right side
                //recursively merge
                counter = MergeClosing(input, low, middle, high, counter);//send back the repition counter
            }

            return counter;
        }


        private static int MergeClosing(List<StoredData> input, int low, int middle, int high, int counter)
        {

            int left = low;
            int right = middle + 1;
            //Temporary storage for the aldready sorted
            double[] tmp = new double[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left].Sh_close < input[right].Sh_close)
                {
                    tmp[tmpIndex] = input[left].Sh_close;
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right].Sh_close;
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;

                counter++;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    //perfroms swop
                    tmp[tmpIndex] = input[left].Sh_close;
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    //perfroms swop
                    tmp[tmpIndex] = input[right].Sh_close;
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i].Sh_close = tmp[i];
            }

            return counter;
        }


        public static int MergeSortDifference(List<StoredData> input, int low, int high, int counter)
        {
            int reps = counter;

            if (low < high)
            {
                int middle = (low / 2) + (high / 2);//centre index
                MergeSortDifference(input, low, middle, reps);//left side
                MergeSortDifference(input, middle + 1, high, reps);//right side 
                //recursively merge
                reps = MergeDifference(input, low, middle, high, reps);//send the reps count back
            }

            return reps;
        }


        public static int MergeDifference(List<StoredData> input, int low, int middle, int high, int counter)
        {
            int reps = counter;

            int left = low;
            int right = middle + 1;
            //temporary stoarge for the already sorted
            double[] tmp = new double[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left].Sh_diff < input[right].Sh_diff)
                {
                    tmp[tmpIndex] = input[left].Sh_diff;
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right].Sh_diff;
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;

                reps++;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    //perfroms swop
                    tmp[tmpIndex] = input[left].Sh_diff;
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    //perfroms swop
                    tmp[tmpIndex] = input[right].Sh_diff;
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i].Sh_diff = tmp[i];
            }

           
            return reps;
        }

        public static int MergeSortDate(List<StoredData> input, int low, int high, int counter)
        {
            int reps = counter;

            if (low < high)
            {
                int middle = (low / 2) + (high / 2);//centre index
                MergeSortDate(input, low, middle, reps);//left side
                MergeSortDate(input, middle + 1, high, reps);//right side
                //recursively merge
                reps = MergeDate(input, low, middle, high, reps);//send the reps back
            }

            return reps;
        }


        public static int MergeDate(List<StoredData> input, int low, int middle, int high, int counter)
        {
            int reps = counter;

            int left = low;
            int right = middle + 1;
            //temporary storage for the sorted
            DateTime[] tmp = new DateTime[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left].TxDate < input[right].TxDate)
                {
                    tmp[tmpIndex] = input[left].TxDate;
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right].TxDate;
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;

                reps++;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    //perform swop
                    tmp[tmpIndex] = input[left].TxDate;
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    //performs swop 
                    tmp[tmpIndex] = input[right].TxDate;
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i].TxDate = tmp[i];
            }


            return reps;
        }

        //method for converting days for the week to ints
        private int ValueDay(string DayList)
        {
            int numValDay = 0;

            if (DayList.Contains("Monday"))
            {
                return numValDay = 0;
            }
            if (DayList.Contains("Tuesday"))
            {
                return numValDay = 1;
            }
            if (DayList.Contains("Wednesday"))
            {
                return numValDay = 2;
            }
            if (DayList.Contains("Thursday"))
            {
                return numValDay = 3;
            }
            if (DayList.Contains("Friday"))
            {
                return numValDay = 4;
            }
            if (DayList.Contains("Saturday"))
            {
                return numValDay = 5;
            }
            if (DayList.Contains("Sunday"))
            {
                return numValDay = 6;
            }
            return numValDay;
        }

        /*************************************************************************************************/
        private string outputTime(List<TimeSpan> timesTaken, string testName)
        {
            string timeTakenString = "";
            //Console.WriteLine("\n ************************************************************\n");
            for (int i = 0; i < timesTaken.Count(); i++)
            {
                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timesTaken[i].Hours, timesTaken[i].Minutes, timesTaken[i].Seconds, timesTaken[i].Milliseconds / 10);
                timeTakenString = testName + " : " + elapsedTime;
            }

            //Console.WriteLine("\n ************************************************************\n");

            return timeTakenString;
        }
    }
        #endregion
}
 