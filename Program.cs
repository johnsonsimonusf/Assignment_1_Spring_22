using System;

namespace Assignment_1_Spring_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is "+ rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        /**
         * @Summary: Method to remove vowel(case insensitive) occurances in a given string.
         * @Params:
         * string s : Input String
         * @Returns: A String by omitting vowel characters present in input string
         * 
         * Author: Johnson
         * Date: 01-27-2022
         * Self reflection:
         * Time taken to complete the problem was about 1 hour.
         * Usage of string manipulation to omit characters in a string is involved/learnt.
         * Have developed a method to remove characters in a given string.
         * Would recommend going through string manipulation techniques and methods
         *  available for strings in C# documentation.
         */
        private static string RemoveVowels(string s)
        {
            try
            {
                String final_string = "";
                if (s.Length >= 0 && s.Length <= 10000)// Valid input
                {
                    //sending all vowel characters to RemoveCharacter method
                    s = RemoveCharacter(s, 'a');
                    s = RemoveCharacter(s, 'A');
                    s = RemoveCharacter(s, 'e');
                    s = RemoveCharacter(s, 'E');
                    s = RemoveCharacter(s, 'i');
                    s = RemoveCharacter(s, 'I');
                    s = RemoveCharacter(s, 'o');
                    s = RemoveCharacter(s, 'O');
                    s = RemoveCharacter(s, 'u');
                    s = RemoveCharacter(s, 'U');
                    s.Trim();
                    final_string = s; //Assigning the string without vowels

                }
                else //Invalid constraints
                {
                    System.Environment.Exit(1);
                }
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /**
         * @Summary: To remove all occurances of a particular character in a string
         *           Used in Question 1
         * @Params:
         * string s - input string
         * char c - character that is to be removed from input string s
         * 
         * @Returns:
         * string s without the input character c in it
         * 
         * Author: Johnson
         * Date: 01-27-2022
         */
        private static string RemoveCharacter(string s, char c)
        {
            try
            {
                String tempString = ""; //Temp string for computation
                if (s.Contains(c))
                {
                    String[] subStrings = s.Split(c);//Returns array of sub-strings that are
                                                     //delimited by separator. Char c here.

                    foreach (string subString in subStrings)//concatination of substrings
                    {
                        tempString += subString;
                    }
                    s = tempString;

                } // End of if

                s.Trim();//additional step just to ensure clean-up of spaces

                return s;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        /**
         * @Summary: Method to compare if two string arrays have the same content in them
         * @Params:
         * string[] bulls_string1 : Input String
         * string[] bulls_string2 : Input String
         * @Returns:
         * A boolean value that states if the two input string arrays are same or not same,
         *  by concatination of strings in string array.
         * 
         * Author: Johnson
         * Date: 01-27-2022
         * Self-reflection:
         * The problem took about 30 minutes to solve.
         * Learnt the concept of concatination of strings and effective usage of foreach loop.
         *  
         **/
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                string string1 = "", string2 = ""; //Strings to store the concatenation of string arrays

                foreach (string s in bulls_string1)//Concatenating substrings in String 1
                {
                    string1 += s;
                }

                foreach (string s in bulls_string2)//Conacatenating substrings in String 2
                {
                    string2 += s;
                }

                if (string1.Equals(string2))//Comparing the two given strings after concatenation
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

      /**
       * @Summary: Method to give sum of all the unique integers in a given integer array
       * @Params:
       * int[] bull_bucks : Input integer array
       * @Returns:
       * An Integer value that stores the sum of all the unique int's in the input array.
       * 
       * Author: Johnson
       * Date: 01-28-2022
       * Self-reflection:
       * A quiet challenging one. The problem took over 2 hours to solve.
       * Learnt the concept of integer array handling and multi-dimentional arrays.
       * Went through C# documentation to understand the implementation of multi-dimentional arrays.
       * Would recommend on going through the same, before trying to solve this problem.
       *  
       **/
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int sumOfUnique = 0;//initializing the variable that stores, sum of unique values to zero
                int bullBucksLength = bull_bucks.Length; //string length of int array
                int[,] bull_bucks_count = new int[bullBucksLength, 2]; // Interger matrix of Rank 2.
                //Row 1 of array to store the integers
                //Row 2 to store the occurances/count of the particular integer in sequence

                foreach (int x in bull_bucks)
                {
                    if (x < 1 || x > 100) //Constarint violation check - for values
                    {
                        goto ConstraintViolation; //Goes to particular label which has exit with error code 1
                    }
                }

                if (bullBucksLength >= 1 || bullBucksLength <= 100) //Constarint check - for length
                {
                    for (int i = 0; i < bullBucksLength; i++) //Traversing through the int array
                    {
                        bull_bucks_count[i, 0] = bull_bucks[i];//Assigning input int value in row 0 of integer matrix
                        if (bull_bucks_count[i, 1] == -1) //Checking for count to be -1. A flag to skip computation
                        {
                            break;
                        }
                        bull_bucks_count[i, 1] = 0;//Assigning initial count of int value to be 0 in row 1 of integer matrix

                        for (int j = i + 1; j < bullBucksLength; j++)//Traversing through the remaining integer array only- we can skip the int array part to left
                        {
                            if (bull_bucks[i] == bull_bucks[j]) //Checking if there is repetation of values in int array
                            {
                                bull_bucks_count[i, 1] += 1; // Increasing the count for that particular integer
                                bull_bucks_count[j, 1] = -1; // Setting the flag as -1 for next occurances of same variable.
                                                             // Setting flag will reduce the computation time when i becomes current value of j.
                            }
                        }
                    }

                    for (int i = 0; i < bullBucksLength; i++)//Traversing through the int array again
                    {
                        if (bull_bucks_count[i, 1] == 0) // Checking for unique values and adding them to sumOfUnique
                        {
                            sumOfUnique += bull_bucks_count[i, 0];
                        }
                    }
                    return sumOfUnique;
                }
            ConstraintViolation:    //label for exit statement with error code 1.
                                    //To be executed when the input has constraint violation
                System.Environment.Exit(1);

                return sumOfUnique;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        /**
         * @Summary: Method to give sum of integers, that form a diagonal in a given integer matrix
         * @Params:
         * int[,] bulls_grid : Input square integer matrix
         * @Returns:
         * An Integer value that stores the sum of all the diagonal elements within the matrix
         * 
         * Author: Johnson
         * Date: 01-29-2022
         * Self-reflection:
         * A logic for this is interesting. The problem took about 30 minutes to solve.
         * Learnt the concept of integer matrix handling and multi-dimentional arrays.
         * Went through C# documentation to understand the implementation of multi-dimentional arrays.
         * Would recommend on going through the same, before trying to solve this problem.
         *  
         **/
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int diagonalSum = 0; //Inintialize the sum to zero
                int bullsGridLength = bulls_grid.GetLength(0); //Storing the length of the square integer matrix
                for (int i = 0; i < bullsGridLength; i++)//traverse through each row of int matrix
                {
                    for (int j = 0; j < bullsGridLength; j++)//traverse through each row's element of int matrix
                    {
                        if (j == i || (j + i == bullsGridLength - 1)) //Condition for being a diagonal element
                        {
                            diagonalSum += bulls_grid[i, j];//Adding the diagonal element's sum
                        }
                    }
                }
                return diagonalSum;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        /**
         * @Summary: Method to map the contents of given string with an int array whose indices have been jumbled
         * @Params:
         * string bulls_string : Input string
         * int[] indices : Input int array with indices of given string
         * @Returns:
         * A String that has the contents of given string in correct order
         * 
         * Author: Johnson
         * Date: 01-29-2022
         * Self-reflection:
         * The problem took about One hour to solve. The logic was simple but tricky.
         * Learnt the concept of string handling and operations on character array.
         * Went through C# documentation to understand the implementation of character arrays.
         *  
         */
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                string restoredString = "";// variable to return output
                char[] correctOrder = new char[indices.Length]; //array to store string in correct format
                char[] x = new char[bulls_string.Length]; //array to store given string
                int temp = 0; //A temporary variable used for computation
                foreach (char i in bulls_string)//converting given string to char array
                {
                    x[temp] = i;
                    temp++;

                }
                for (int i = 0; i < bulls_string.Length; i++)//Mapping the string value with indices and storing in array
                {
                    correctOrder[indices[i]] = x[i];
                }
                for (int i = 0; i < bulls_string.Length; i++)//copying content from char array to string
                {
                    //Console.Write(correctOrder[i]);
                    restoredString += correctOrder[i];
                }
                return "null";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        /**
         * @Summary: Method to reverse the substring when the first occurance of char occurs and append the remaining substring
         * @Params:
         * string bulls_string6 : Input string
         * char ch : Input character
         * @Returns:
         * String that has the reverse of substring split at first occuarnce of char and the remaining substring concatenated
         * 
         * Author: Johnson
         * Date: 01-29-2022
         * Self-reflection:
         * The problem took about 90 minutes to solve.
         * Learnt the concept of string handling and operations on character array.
         * Went through C# documentation to understand the implementation of character arrays.
         *  
         */
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = ""; //string to return the output
                int chPosition = 0, counter = 0; // chPosition stores the index position of character in string
                                                 // counter is a variable used for iteration within foreach loop
                char swapHelp; // Third varaible to store data when swapping
                int bullsString6Length = bulls_string6.Length; // Stores the length of string
                char[] bullsString6Array = new char[bullsString6Length]; // Character array with length as that of given string

                if (bullsString6Length < 1 || bullsString6Length > 250) //Checking for constratint
                {
                    goto constraintViolation;
                }
                foreach (char c in bulls_string6)
                {
                    if (Char.IsUpper(c))//checking for constraint
                    {
                        goto constraintViolation;
                    }
                    if (c.Equals(ch))//storing the position of ch, when there is a match
                    {
                        chPosition = counter;
                    }

                    bullsString6Array[counter] = c;
                    counter++;
                }
                for (int i = 0, j = chPosition; i <= (chPosition / 2 + chPosition % 2) && j > i; i++, j--)
                //Loop to reverse the contents of character array 
                {

                    swapHelp = bullsString6Array[i];
                    bullsString6Array[i] = bullsString6Array[j];
                    bullsString6Array[j] = swapHelp;

                }

                foreach (char c in bullsString6Array)// framing the output array to return
                {
                    prefix_string += c;
                }
                return prefix_string;

            constraintViolation:
                System.Environment.Exit(1);
                return prefix_string;
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
