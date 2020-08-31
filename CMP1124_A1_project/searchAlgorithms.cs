using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AlgorithmAss1
{
    class SearchAlgorithms
    {
        //The class contains differing search algorithms based on Lists using DateTime or String Days
        public SearchAlgorithms()
        {
            //constructor - not needed
        }
        //---------------------------------------------------------------------------------------------
        #region search date
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDateA1(List<StoredData> sortedListToSearchA1, DateTime dateToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your first search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            List<StoredData> searchResults = new List<StoredData>();

            //Interpolation Search
            //Average Case: log(log(n)) 
            //Worst Case: O(n)

            sortedListToSearchA1.Sort((x, y) => x.TxDate.CompareTo(y.TxDate)); //sorts dates in sequential order

            int low = 0;
            int mid;
            int high = sortedListToSearchA1.Count - 1; 

            while (sortedListToSearchA1[low].TxDate < dateToFind && sortedListToSearchA1[high].TxDate >= dateToFind)  //the search space
            {
                mid = low + ((high - low) / 2);
                if (sortedListToSearchA1[mid].TxDate < dateToFind)  //search space is reduced to the part before
                {                                                   
                    low = mid + 1;
                }
                else if (sortedListToSearchA1[mid].TxDate > dateToFind)
                {
                    high = mid - 1;
                }

                else
                {
                    searchResults.Add(sortedListToSearchA1[mid]); //adds current iteration of mid index in sortedListToSearchA1
                    break;
                }

                countOfRepetitions++;
            }

            if (sortedListToSearchA1[low].TxDate == dateToFind) //in case the search date is located at lowest index in list
            {
                searchResults.Add(sortedListToSearchA1[low]);
            }

            else if (searchResults.Count == 0) //if the date can't be found error is added to search results
            {
                StoredData newObj = new StoredData("Not Found", DateTime.Now, 0, 0, 0, 0);
                searchResults.Add(newObj);
            }

            // counts iterations of how many time the search passes through the list.
            //#####################################################################################################
            //Place your first search algorithm above here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 

            searchResults.First().SearchTypeAndTime = "Using 'Interpolation Search A1' search by date";//rewrite the text to show user which algorithm you have used
                                                                                                       // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions;
            //rewrite to show user the number of steps (loops) this algorithm has made to sort the data

            return searchResults;
        }




        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>


            //Global varible for counter 
        static int counter;

        public static int GlobalCounter
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
            }
        }
        public List<StoredData> searchByDateA2(List<StoredData> sortedListToSearchA2, DateTime dateToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
            List<StoredData> searchResults = new List<StoredData>();

            //Binary Tree
            //Average case: O(log n) 
            //Worst case: O(n)

            


        TBinarySTree<DateTime> bt = new TBinarySTree<DateTime>();


            //insert the data into the tree
            for (int i = 0; i < sortedListToSearchA2.Count; i++)
            {

                bt.insert(sortedListToSearchA2[i].TxDate, i);

            }

            // Retrieve data from the tree with its index number
            TTreeNode symbol = bt.findSymbol(dateToFind);
            if (symbol != null)
            {

                searchResults.Add(sortedListToSearchA2[symbol.value]);

            }

            else if (symbol == null) //if date cannot be found, adds an empty StoredData object to results list
            {
                StoredData newObj = new StoredData("Not Found", DateTime.Now, 0, 0, 0, 0);
                searchResults.Add(newObj);
            }

            countOfRepetitions = SearchAlgorithms.GlobalCounter;

            //#####################################################################################################
            //Place your second search algorithm above here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'Binary Tree Search A2' search by date";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            return searchResults;
        }
        #endregion search date



        #region search day
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching days and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDayA1(List<StoredData> dataToSearchA1, string dayToFind)
        {
          

            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
                                        //#####################################################################################################
                                        //Place your
                                        //first search algorithm below here - the results must be in the List 'searchResults'
                                        //This will be displayed on the left-hand-side of the console window
                                        //#####################################################################################################
                                        //Create a blank data item to indicate the searched for date doesnot exist in the data set


            //Linear search
            //Worst and Average case: O(n)
            //Best case: O(1)

            List<StoredData> searchResults = new List<StoredData>();

            for (int i = 0; i <= dataToSearchA1.Count - 1; i++)//loops through whole list
            {
                if (dataToSearchA1[i].TxDay == dayToFind)

                {
                    searchResults.Add(dataToSearchA1[i]);//found item added to search results list 
                }

                countOfRepetitions++;
            }

            if (searchResults.Count == 0)
            {

                //if the value to search for can't be found an error is entered 
                StoredData noValue = new StoredData("Not Found", DateTime.Now, 0, 0, 0, 0);

                searchResults.Add(noValue);

            }


            //#####################################################################################################
            //Place your first search algorithm below here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'Linear Search A1' search by day";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            return searchResults;
        }
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching days and return a match or a 'did not match' result in a list
        /// </summary>
        //public enum DayOfWeek

        public List<StoredData> searchByDayA2(List<StoredData> dataToSearchA2, string dayToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
            //Create a blank data item to indicate the searched for date doesnot exist in the data set
            List<StoredData> searchResults = new List<StoredData>();

            //Binary search
            //Worst and Average case: O(log n)
            //Best case: O(1)

            List<int> numberList = new List<int>();

            for (int i = 0; i <= dataToSearchA2.Count - 1; i++)
            {
                numberList.Add(indexDay(dataToSearchA2[i].TxDay));  //converts the list of days of the week to a new list with numbers 1 - 7 to represent days of the week

            }

            numberList.Sort();//sorts the new number list into numerical order

            dataToSearchA2.Sort((x, y) => dayNumber(x.TxDay).CompareTo(dayNumber(y.TxDay)));//compares it to number value for numerical order sorting

            int lowBound = 0, highBound = numberList.Count - 1;

            int mid = 0;

            int N = dataToSearchA2.Count;

            int numberDay = dayNumber(dayToFind);//returns number from the day of the week entered


            while (lowBound <= highBound)
            {

                mid = (lowBound + highBound) / 2;
                if (numberList[mid] < numberDay)//the element we search is located to the right from the mid point
                {
                    lowBound = mid + 1;

                }
                else if (numberList[mid] > numberDay)//the element we search is located to the left from the mid point
                {
                    highBound = mid - 1;

                }

                //at this point low and high bound are equal and we have found the element or
                //list[mid] is just equal to the value => we have found the searched element
                else if (numberList[mid] == numberDay)
                {
                    searchResults.Add(dataToSearchA2[mid]);


                    int plusMid = mid;
                    int minusMid = mid;


                    if (plusMid < dataToSearchA2.Count - 1)
                        plusMid = plusMid + 1;

                    if (minusMid > 0)
                        minusMid = minusMid - 1;


                    if (numberList[0] == numberDay)
                        searchResults.Add(dataToSearchA2[0]);

                    while ((numberList[plusMid] == numberDay) && (plusMid < dataToSearchA2.Count - 1)) //checks the index to the right to find all the matching values 

                    {
                        searchResults.Add(dataToSearchA2[plusMid]);//adds the element to the right if it matches the search element
                        plusMid = plusMid + 1;

                        countOfRepetitions++;

                    }

                    while ((numberList[minusMid] == numberDay) && (minusMid > 0)) //checks the index to the left to find all the matching values 

                    {
                        searchResults.Add(dataToSearchA2[minusMid]);//adds the element to the left if it matches the search element
                        minusMid = minusMid - 1;

                        countOfRepetitions++;
                    }


                    //Console.WriteLine(numberList[mid] + "  this is the index:  " + mid + "       " + numberDay);

                    break;


                }//end of else for when the correct value has been found

                countOfRepetitions++;

            }//end of while loop

            if (lowBound > highBound)

            {
                StoredData noValue = new StoredData("Not Found", DateTime.Now, 0, 0, 0, 0);//if the element can't be found an error is shown 
                searchResults.Add(noValue);

            }


            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'Binary Search A2' search by day";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data

            return searchResults;
        }


        //**********************************************************************************************
        #endregion search day

            //method for converting the dayToFind varible to an int 
        private int dayNumber(string day)
        {
            switch (day)
            {
                case "Monday":
                    return 0;
                case "Tuesday":
                    return 1;
                case "Wednesday":
                    return 2;
                case "Thursday":
                    return 3;
                case "Friday":
                    return 4;
                case "Saturday":
                    return 5;
                case "Sunday":
                    return 6;

            }
            return -1;
        }

        //method for converting the dataToSearch to a list of ints 
        public int indexDay(string day)
        {
            switch (day)
            {
                case "Monday":
                    return 0;
                case "Tuesday":
                    return 1;
                case "Wednesday":
                    return 2;
                case "Thursday":
                    return 3;
                case "Friday":
                    return 4;
                case "Saturday":
                    return 5;
                case "Sunday":
                    return 6;
                default:
                    return -1;
            }
        }


        //methods for the binary tree:
        class TreeNode<T>
        {

            public T Element { get; set; }
            public TreeNode<T> Left { get; set; }
            public TreeNode<T> Right { get; set; }

            public TreeNode(T element)
            {
                this.Element = element;
            }


        }


        // Define tree nodes 2nd one
        public class TTreeNode
        {
            public DateTime name;
            public int value;
            public TTreeNode left, right;

            // Constructor  to create a single node 
            public TTreeNode(DateTime name, int d)
            {
                this.name = name;
                value = d;
                left = null;
                right = null;
            }
        }

        public class TBinarySTree<T>
        {
            // Implements:

            // insert()
            
            // findSymbol()
          

            private TTreeNode root;     // Points to the root of the tree
            private int _count = 0;

            public TBinarySTree()
            {
                root = null;
                _count = 0;
            }


            /// <summary>
            /// Find name in tree. Return a reference to the node
            /// if symbol found else return null to indicate failure.
            /// </summary>
            /// <param name="name">Name of node to locate</param>
            /// <returns>Returns null if it fails to find the node, else returns reference to node</returns>

            //find 
            public TTreeNode findSymbol(DateTime name)
            {
                TTreeNode np = root;
                int cmp;
                while (np != null)
                {
                    cmp = DateTime.Compare(name, np.name);
                    if (cmp == 0)   // found !
                        return np;

                    if (cmp < 0)
                        np = np.left;
                    else
                        np = np.right;

                    SearchAlgorithms.GlobalCounter++;//Count the reps

                }

                return null;  // Return null to indicate failure to find name
            }


            // Recursively locates an empty slot in the binary tree and inserts the node


            //add
            private void add(TTreeNode node, ref TTreeNode tree)
            {
                if (tree == null)
                    tree = node;
                else
                {
                    // If we find a node with the same name then it's 
                    // a duplicate and we can't continue
                    int comparison = DateTime.Compare(node.name, tree.name);
                    if (comparison == 0)
                        throw new Exception();

                    if (comparison < 0)
                    {
                        add(node, ref tree.left);
                    }
                    else
                    {
                        add(node, ref tree.right);
                    }
                }
            }

            //insert
            public TTreeNode insert(DateTime name, int d)
            {
                TTreeNode node = new TTreeNode(name, d);
                try
                {
                    if (root == null)
                        root = node;
                    else
                        add(node, ref root);
                    _count++;
                    return node;
                }
                catch (Exception)
                {
                    return null;
                }
            }





        }

    }

}//end of name space
