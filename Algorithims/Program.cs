using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Algorithims
{
    class Program
    {
        static void Main(string[] args)
        {

            //Size();
            //UpperAndLower();
            //WordDash();
            //SortAscending();
            //SortDescendingSecondWay();
            //SortDescending();
            //Min();
            //FindPairs();
            //MergeTwoArraysWithSort();
            //TwoDimenstionFamilyArray();
            //SearchAndEdit();
            //ElementCount();
            //CountEachElement();
            //Shape1();
            //Shape2();
            //ShapeNumbers();
            //MultiplicationTable();
            //Shape3();
            //Shape4();
            //Shape5();
            //IsAwali();
            //AwaliNumbers();
            //StringReverse();
            //Encryption();
            //ArrayUserInput();
            //NumbersRevers();
            //TwoDimensionFamilyChildred();
            //StudentsGrades();
            //MatrixMultiplication();
            //PlayOX();
            //ArrayList();
            //GenericIsEqual<string>("Adel", "Adel");
            //GenericQueue();
            //SumOddEvenNumbersQueue();
            //Console.WriteLine(SumNumbersRecursiveMethod(5));
            //Console.WriteLine(FibonacciRecursive(6));
            //SearchArrayRecursiveMethod(8);
            //ReverseStringRecursive("Adel Salem", "Adel Salem".Length-1);
            //FindMaxRecursiveWay();
            //DrawShape1();
            //DrawShape2(); // Drawing by using line equation
            //DrawShape3();   // Drawing by using line equation
            //DrawCircle();
            //RemoveDuplicatedLetter();
            //DynamicTwoDimensionArray();  // Filling two-dimension array which has different sizes of its enternal arrays


        }

        // Size of any string
        public static void Size()
        {
            Console.WriteLine("Enter the word");
            string str = Console.ReadLine();
            int i = 0;
            foreach (char c in str)
            {
                i++;
            }
            Console.WriteLine("The size is:" + (i));

        }
         
        // Reverse the word
        public static void StringReverse()
        {
            string x = "Hamid";
            string res = "";
            for (int i = x.Length - 1; i >= 0; i--)
            {
                res += x[i];
            }
            Console.WriteLine(res);
        }
        
        // Reverse numeric array
        public static void NumbersRevers()
        {
            Console.Write("Enter the size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[size];
            int[] result = new int[size];
            
            // fill the array X[] with numbers
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter the element " + i + " :");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // Fill the inverse array result[]
            for(int i = size - 1, j=0; i >= 0; i--,j++)
            {
                result[j] = x[i];
            }

            // Print the result array
            Console.Write("The array numbers are: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        // Encrypt the given message then decrypt it again
        public static void Encryption()
        {
            Console.Write("Enter the message: ");
            string msg = Console.ReadLine();
            string result = "";

            for(int i = 0; i < msg.Length; i++)
            {
                result +=(char) (msg[i] + 1);
            }
            Console.WriteLine("\nThe encryption message is: " + result+"\n");

            Console.Write("The extracted message is: ");
            msg = "";
            for(int i = 0; i < result.Length; i++)
            {
                msg +=(char)( result[i] - 1);
            }
            Console.WriteLine(msg);

        }

        // Switch small letters to capital letters and versa
        public static void UpperAndLower()
        {
            Console.WriteLine("Enter the Word:");
            string word = Console.ReadLine();
            string result = "";

            //check is the char between A-Z or a-z
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'A' && word[i] <= 'Z')
                {
                    result += Convert.ToChar(word[i] + 32);
                }
                else if (word[i] >= 'a' && word[i] <= 'z')
                {
                    result += Convert.ToChar(word[i] - 32);
                }
            }
            Console.WriteLine("The result is:" + result);
        }

        // printing word and putting dash(-) instead of each letter for every time
        public static void WordDash()
        {
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            string[] result = new string[word.Length];//output

            Console.WriteLine("The result is: ");
            for (int c = 0; c < word.Length; c++)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i == c)
                    {
                        result[c] += '_';
                    }
                    else
                    {
                        result[c] += word[i];
                    }
                }
                Console.WriteLine(result[c]);
            }
        }

        // Sorting Numeric array ascending
        public static void SortAscending()
        {
            // The enternal loop puts the maximum element at the end 
            // The external loop repeats the operation of the enternal loop with each element
            int[] numbers = {22, 20, 18, 15, 10, 9, 8, 7,5,4,3,2,1,0 };
            Console.WriteLine("The ascending sort of {22, 5, 2, 4, 1, 7, 8, 3, 9 , 0, 15, 10, 20, 18} are: ");

            for (int c = 0; c < numbers.Length-1 ; c++)
            {
                for (int i = 0; i < numbers.Length -1 - c; i++) //the last digit will be sorted automaitcally
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp;
                        temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
            }

            // Print the result array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // Sorting numeric array descending
        public static void SortDescending()
        {
            // The enternal loop puts the minumum element at the end 
            // The external loop repeats the operation of the enternal loop with each element
            int[] numbers = { 5, 2, 4, 1, 7, 8, 3 };

            Console.WriteLine("The descending sort of { 5, 2, 4, 1, 7, 8, 3 } are: ");

            for (int c = 0; c < numbers.Length  ; c++)
            {
                for (int i = 0; i < numbers.Length - 1 - c; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        int temp;
                        temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
            }

            // لطباعة المصفوفة
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // Sorting numeric array ascending with different way (important)
        public static void SortDescendingSecondWay()
        {
            // the idea is to search in the whole array to find the minumum in order to put it at first etc
            int[] numbers = { 22, 20, 18, 15, 10, 9, 8, 7, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine("The ascending sort of {22, 5, 2, 4, 1, 7, 8, 3, 9 , 0, 15, 10, 20, 18} are: ");
            int min = numbers[0];
            int temp;

            for(int c = 0; c < numbers.Length-1; c++)
            {
                for (int i = c+1; i < numbers.Length ; i++)
                {
                    min = numbers[c];
                    if (numbers[c]>numbers[i])
                    {
                        temp = numbers[c];
                        numbers[c] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            // print the result array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //Finding the minimum element in the numeric array
        public static void Min()
        {
            int[] numbers = { 5, 6, 1, 4, 9, 2 };
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("The minimum number of { 5, 6, 1, 4, 9, 2 } is: "+ min);
        }

        // Finding the pairs which is the summation of them =12
        public static void FindPairs()
        {
            int[] nums = { 3, 8, 7, 6, 4, 5, 9 };
            Console.WriteLine("The pairs that are equal 12 from { 3, 8, 7, 6, 4, 5, 9 } are:");

            for (int c = 0; c < nums.Length-1; c++)
            {
                for(int i = c+1; i < nums.Length; i++)
                {
                    if (nums[c] + nums[i] == 12)
                    {
                        Console.WriteLine(nums[c] + "," +nums[i]);
                    }
                }
            }
        }

        // Merge two sorted arrays and re-arrange the elements of the result array
        public static void MergeTwoArraysWithSort()
        {
            int[] nums1 = { 2, 4, 5, 6, 7 };
            int[] nums2 = { 1, 3, 8 };
            int[] result = new int[nums1.Length + nums2.Length];

            Console.WriteLine(@"After merging the two arrays { 2, 4, 5, 6, 7 } and { 1, 3, 8 }, we get: ");

            int c, i, j;
            for (c=0,i=0,j=0; c < nums1.Length && i< nums2.Length;)
            {
                if (nums1[c] < nums2[i])
                {
                    result[j] = nums1[c];
                    j++;
                    c++;
                }
                else
                {
                    result[j] = nums2[i];
                    j++;
                    i++;
                }
            }

            // في حال بقيت هناك عناصر في المصفوفة الأولى 
            while (c < nums1.Length )
            {
                result[j] = nums1[c];
                j++;
                c++;
            }

            // في حال بقيت هناك عناصر في المصفوفة الثانية 
            while (i < nums2.Length)
            {
                result[j] = nums2[i];
                j++;
                i++;
            }

            for (int x = 0; x < result.Length; x++)
            {
                Console.Write(result[x]+",");
            }
        }

        // Fill the names of family members in two dimension array and print it
        public static void TwoDimenstionFamilyArray()
        {
            // the family has 4 persons and each person has 2 kids
            string[,] family = new string[4,2];

            // Fill the two dimensional array
            for(int c = 0; c <4; c++)
            {
                Console.WriteLine("Enter the first and Last name of person number " + (c + 1) + " : ");
                Console.Write("The first name is: ");
                for (int i = 0; i < 2; i++)
                {
                    family[c, i] = Console.ReadLine();
                    if (i != 1)
                    {
                        Console.Write("The last name is : ");
                    }
                }
            }

            // Print the dimensional array
            for (int c = 0; c < 4; c++)
            {
                Console.WriteLine("\n");
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(family[c, i] + " ");
                }
            }
            Console.WriteLine("\n");
        }

        // Search for specific element to change its value
        public static void SearchAndEdit()
        {
            int[] nums = { 2, 8, 4, 1, 5, 9 };
            Console.WriteLine("Enter the value you want to search: ");
            int s = Convert.ToInt16(Console.ReadLine());
            bool found = false;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == s)
                {
                    nums[i] = s * 2;
                    found = true;
                }
            }

            if (found == false)
            {
                Console.WriteLine("The value is not exist \n The result is ");
            }
            else
            {
                Console.Write("The value is exist \n the result is: ");
            }

            //طباعة المصفوفة الجديدة
            Console.Write("{");
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " , ");
            }
            Console.Write("}");
        }

        // Search for repetition number for a specific element
        public static void ElementCount()
        {
            int[] nums = { 2, 8, 4, 5, 1, 4, 3, 5, 4, 7, 9, 4 };
            Console.Write("Write the number you want to check: ");
            int s = Convert.ToInt16(Console.ReadLine());
            int count = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == s)
                {
                    count++;
                }
            }
            Console.Write("The number was repeated " + count + " times\n");
        }

        // Search for repition number for each element in the array .... difficult and important
        public static void CountEachElement()
        {
            int[] nums = { 2, 8, 4, 5, 1, 4, 3, 5, 4, 7, 9, 4 };
            bool[] numChecks = new bool[nums.Length];
            int[] numsCounting = new int[nums.Length];

            for(int c = 0; c < nums.Length; c++)
            {
                for(int i = 0; i < c + 1; i++)
                {
                    if (nums[c] == nums[i] && numChecks[c] == false)
                    {
                        numChecks[i] = true;
                        numsCounting[c]++;
                    }
                }
            }

            for(int i=0;i<nums.Length; i++)
            {
                Console.Write(numsCounting[i]);
            }
            
        }

        // Draw triangle shape by stars
        public static void Shape1()
        {
            for(int c = 1; c <= 7; c++)
            {
                for(int i = 0; i < c; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        // Draw triangle shape by stars ..2
        public static void Shape2()
        {
            for(int c = 1; c <= 7; c++)
            {
                for(int i = 1; i <= 7 - c; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        // Draw pyramid shape by stars ..3
        public static void Shape3()
        {
            for(int c = 1; c <= 5; c++)
            {
                for(int i = 4; i >=c; i--)
                {
                    Console.Write("-");
                }
                for(int i =1; i <= c*2-1; i++)
                {
                    Console.Write("*");
                }
                for (int i = 4; i >=c; i--)
                {
                    Console.Write("-");
                }

                Console.Write("\n");
            }
        }

        // Draw inverse pyramid by stars
        public static void Shape4()
        {
            for(int c = 1; c <= 10; c++)
            {
                for(int i = 1; i < c; i++)
                {
                    Console.Write(" ");
                }
                for(int i = 10; i > c * 2 - 1; i--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        public static void Shape5()
        {
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y>x; y++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        // Print numbers in a triangle shape
        public static void ShapeNumbers()
        {
            for(int c = 1; c <= 6; c++)
            {
                for(int i = 1; i <= c; i++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }

        // Print the table of Multiply operation by using two dimension array
        public static void MultiplicationTable()
        {
            int[,] table = new int[9, 9];

            // Fill the table
            for (int c =1; c <= 9; c++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    table[c-1, i-1] = c*i;
                }
            }

            // Fill the table
            for (int c = 0; c <=9; c++)
            {
                Console.Write(c + " : ");
                for (int i =1; i <=9; i++)
                {
                    if (c == 0)
                    {
                        Console.Write(i + "\t");
                    }
                    else
                    {
                        Console.Write(table[c-1, i-1] + "\t");
                    }
                }

                if (c == 0)
                {
                    Console.Write("\n");
                    Console.Write("------------------------------------------------------------------");
                }
                Console.Write("\n");
            }
        }

        // Check if the number is prime number
        public static void IsAwali()
        {
            Console.Write("Enter the input: ");
            int s = Convert.ToInt16(Console.ReadLine());
            bool isAawli = true;

            for(int i = 2; i <= s - 1; i++)
            {
                if (s % i == 0)
                {
                    isAawli = false; ;
                    break;
                }
            }

            Console.WriteLine("This number is : "+( (isAawli == true) ? "Awali" : "Not awali"));
        }

        // Find the prime numbers from 1 to 20
        public static void AwaliNumbers()
        {
            bool Awali;

            for(int c = 1; c<= 20; c++)
            {
                Awali = true;
                for(int i = 2; i < c; i++)
                {
                    if (c % i == 0)
                    {
                        Awali = false;
                    }
                }
                Console.WriteLine(c+ " is: " + ((Awali == true) ? "Awali" : "Not Awali"));
            }
        }

        // The user enters the size of the array then fill it and we print the array
        public static void ArrayUserInput()
        {
            Console.Write("Enter the size of array: ");
            int length =int.Parse (Console.ReadLine());
            int[] x = new int[length];
            for(int i = 0; i < length; i++)
            {
                Console.Write("Enter the value of element " + i + " :");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe array elements are: ");
            for(int i = 0; i < length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }

        // Important Example: 
        // Building two-dimenstion array but the enternal arrays are in different sizes
        // Ex. We have four persons in the family and each person has different number of kids from the other person
        // we will fill two-dimension aray which the enternal array has different sizes
        public static void TwoDimensionFamilyChildred()
        {
            Console.Write("Enter the number of the family: ");
            int persons = Convert.ToInt32(Console.ReadLine());

            // We only fill the first dimenstion of the array
            string[][] Family = new string[persons][]; 
            for(int i = 0; i < persons; i++)
            {
                Console.Write("Enter the number of kids for person " + (i+1) + " :");
                int kidsNo = Convert.ToInt32(Console.ReadLine());

                // Here is the key, look how we initialize the enternal array for each external array
                Family[i] = new string[kidsNo]; 

                Console.WriteLine("Enter the names of the kids: ");
                for(int j = 0; j < kidsNo; j++)
                {
                    Family[i][j] = Console.ReadLine();
                }
            }

            Console.WriteLine("---------------------");
            
            // Print the names of the kids
            for(int i = 0; i < persons; i++)
            {
                Console.WriteLine("The names of kids for Person number " + (i + 1) + " are: ");
                for(int j = 0; j<Family[i].Length; j++)
                {
                    Console.WriteLine(Family[i][j]);
                }
            }
        }

        
        // Example Student Grades: 
        // How to fill two-dimension array with different sizes in the enternal arrays
        public static void StudentsGrades()
        {
            Console.Write("Enter the number of students: ");
            int studentsNo = Convert.ToInt32(Console.ReadLine());

            int[][] Grades = new int[studentsNo][];

            for(int i = 0; i < studentsNo; i++)
            {
                Console.Write("Enter the number of subjects for student number " + (i + 1) + " :");
                int subjects = Convert.ToInt32(Console.ReadLine());
                Grades[i] = new int[subjects];

                Console.WriteLine("Enter the grades for student no " + (i + 1) + " :");
                for(int j = 0; j < subjects; j++)
                {
                    Grades[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------");
            
            // Print the grades
            for (int i = 0; i < studentsNo; i++)
            {
                Console.WriteLine("The grades for the student number"+(i+1)+" are: ");
                for(int j = 0; j < Grades[i].Length; j++)
                {
                    Console.Write(Grades[i][j] + " , ");
                }
                Console.Write("\n");
            }

            // calculate the total grades of each student and put it in an array
            int[] totals = new int[studentsNo];
            for(int i = 0; i < studentsNo; i++)
            {
                int sum = 0;
                for(int j = 0; j < Grades[i].Length; j++)
                {
                    sum += Grades[i][j];
                }
                totals[i] = sum;
            }

            Console.WriteLine("---------------------");
            
            // Print the total of grades for each student
            for (int i = 0; i < studentsNo; i++)
            {
                Console.WriteLine("The total grades for student number " + (i + 1) + " :"+totals[i]);
            }
        }
        
        // Example for matrix Multiplication
        public static void MatrixMultiplication()
        {
            Console.Write("Enter the size of the matrix: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[size,size];
            int[,] matrix2 = new int[size, size];
            int[,] result = new int[size, size];

            Console.WriteLine("Enter the elements of first matrix : ");
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("Enter the elements of second matrix : ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Multiply the two matrixes
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    for(int x = 0; x < size; x++)
                    {
                        result[i, j] = matrix1[i, x] * matrix2[x, j];
                    }
                    
                }
            }

            // Print the result matrix
            Console.WriteLine("The result is: ");
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write("\t"+result[i, j]+"   ");
                }
                Console.Write("\n");
            }
        }


        // Play O X .. Not completed yet
        public static void PlayOX()
        {
            Console.WriteLine("your turn: \n\n");
            char[,] squares = new char[3, 3];

            // Draw the game
            Console.Write("__|__|__\n__|__|__\n  |  |\n\n");
        }

        // Choose the common elements between two ArrayLists
        public static void ArrayList()
        {
            ArrayList one = new ArrayList() { "ali", "amal", "huda", "laly" };
            ArrayList two = new ArrayList() { "nader", "raed", "ali", "amal" };
            ArrayList distinct = new ArrayList();

            for (int i = 0; i < two.Count; i++)
            {
                for (int c = 0; c < one.Count; c++)
                {
                    if (two[i].ToString() == one[c].ToString())
                    {
                        distinct.Add(two[i]);
                        break;
                    }
                }
            }

            for (int i = 0; i < distinct.Count; i++)
            {
                Console.WriteLine(distinct[i]);
            }

        }

        // Example: using generic method
        public static void GenericIsEqual<t>(t a,t b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public static void GenericQueue()
        {
            Queue<char> my = new Queue<char>();
            my.Enqueue('a');
            my.Enqueue('5');
            my.Enqueue('@');
            my.Enqueue('c');
            my.Enqueue('*');
            my.Enqueue('9');

            Queue<char> numbers = new Queue<char>();
            Queue<char> ch = new Queue<char>();
            Queue<char> other = new Queue<char>();

            while(my.Count>0)
            {
                if(my.Peek()>='0' && my.Peek() <= '9')
                {
                    numbers.Enqueue( my.Dequeue());
                }else if(my.Peek()>='A' && my.Peek() <= 'z')
                {
                    ch.Enqueue(my.Dequeue());
                }
                else
                {
                    other.Enqueue(my.Dequeue());
                }
            }

            foreach(char n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("--------");

            foreach (char n in ch)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("--------");

            foreach (char n in other)
            {
                Console.WriteLine(n);
            }
        }

        // Calculate the sum of even numbers and odd numbers
        public static void SumOddEvenNumbersQueue()
        {
            Console.WriteLine("ENter the size of queue: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Queue<int> my = new Queue<int>();
            while (my.Count <= size)
            {
                my.Enqueue(Convert.ToInt32(Console.ReadLine()));
            }

            int sumOdd=0, sumEven=0;
            while (my.Count > 0)
            {
                if (my.Peek() % 2 == 0)
                {
                    sumEven += my.Dequeue();
                }
                else
                    sumOdd += my.Dequeue();
            }
            Console.WriteLine("The sume of Odd numbers is: "+sumOdd+"\n The sume of Even numbers is: "+sumEven); 

        }

        // Calculate the sum of numbers using recursive method
        public static int SumNumbersRecursiveMethod(int s)
        {
            if (s == 1)
            {
                Console.WriteLine("The summation of number is : ");
                return 1;
            }
            else
            {
                return s + SumNumbersRecursiveMethod(s - 1);
            }
        }

        // Creating Fiboccanni Series Using Recursive
        // Fib1=1 ; Fib2=1; Fib(n)=Fib(n-1)+Fib(n-2);
        public static int FibonacciRecursive(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
        }

        // Using Recursive Method in Searching for a specific element
        public static void SearchArrayRecursiveMethod(int a,int index=0)
        {
            int[] array = new int[5] { 2, 7, 4, 3, 5 };

            if (index ==array.Length)
            {
                Console.WriteLine("It is not exist");
                return;
            }
            if (array[index] == a)
            {
                Console.WriteLine("It is exist");
                return;
            }
            else
            {
                SearchArrayRecursiveMethod(a,++index);
            }
        }

        // Using Recursive Method in Reversing string
        public static void ReverseStringRecursive(string str,int index)
        {
            if (index < 0)
            {
                Console.Write("\n");
                return;
            } 
            else
            {
                Console.Write(str[index]);
                ReverseStringRecursive(str, --index);
            }
        }

        // Using Recursive Method in Finding the maximum element
        public static void FindMaxRecursiveWay(int max=-1,int i=0)
        {
            int[] arr = new int[5] { 4, 2, 7, 1, 3 };
            if (max == -1)
            {
                max = arr[0];
            }
            if (i == arr.Length-1)
            {
                Console.WriteLine(max);
                return;
            }
            else
            {
                if (max < arr[i+1])
                {
                    max = arr[i+1];
                }
                FindMaxRecursiveWay(max, ++i);
            }
        }

        // Draw Home by stars
        public static void DrawShape1()
        {
            int x = 4;
            for(int i = 0; i < 4; i++)
            {
                for(int c = 0; c < 9; c++)
                {
                    if (c == x-i || c==x+i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for(int i = 0; i < 5; i++)
            {
                for(int c = 0; c < 9; c++)
                {
                    if(i==0 || i == 4)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        if(c==0 || c == 8)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        // Important:: Creative solution for drawing by using line equation
        public static void DrawShape2()
        {
            for(int y= 0; y< 5; y++)
            {
                for(int x = 0; x < 9; x++)
                {
                    if (y==-x+4||y==x-4||y==4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        //Important:: Creative solution for drawing by using line equation
        public static void DrawShape3()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (y == x - 4 || y == -x + 4||y==x+4 || y == -x + 12)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }

        // Important:: Creative solution for drawing circle by using cicle equation
        public static void DrawCircle()
        {
            for(int y = 0; y < 20; y++)
            {
                for(int x = 0; x < 20; x++)
                {
                    if ((y-8)*(y-8) + (x-8)*(x-8) == 16)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        // Re-write the string after removing the duplicated letters
        public static void RemoveDuplicatedLetter()
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string result = "";
            bool[] flag = new bool[str.Length];

            for(int i = 0; i < str.Length; i++)
            {
                if (flag[i] == true)
                {
                    continue;
                }
                for(int c = i+1; c < str.Length; c++)
                {
                    if (str[i] == str[c])
                    {
                        flag[c] = true;
                    }
                }
                result += str[i];
            }
            Console.WriteLine("The result is : " + result);
        }

        // Explain how we can create or fill two-dimensional array with different size of enternal arrays
        public static void DynamicTwoDimensionArray()
        {
            // ملاحظة مهمة : يمكن كتابة المصفوفة الثنائية بطريقتين وهي
            // int[,] x=new int[7,2];
            // or int[][] x=new int[3][];
            // الطريقة الأولى لابد فيها من تحديد حجم المصفوفة الداخلة والخارجية 
            // ويبقى الحجم ثابت لجميع المصفوفات الداخلة والخارجية
            // الطريقة الثانية لابد من تحديد حجم المصفوفة الخارجية فقط (الصفوف) ويتم تحديد 
            // حجم المصفوفة الداخلة لكل صف على حدة بالشكل التالي
            // x[2]=new int[5];
            // يعني كأننا نقول أن حجم العناصر داخل المصفوفة الثانية (الصف الثاني) هو 5
            // وبنفس الطريقة نحدد حجم كل صف على حدة 
            // ونستخدم هذه الطريقة عندما يكون عندي مصفوفة ثنائية البعد مختلفة الأحجام الداخلية
            // بمعنى آخر عندما يكون عندي شجرة مختلفة في أعداد الفروع الداخلية
            
            string[][] family=new string[3][];
            int kids = 0;
            for(int i = 0; i < family.Length; i++)
            {
                Console.Write("\nEnter the name of the person: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the number of kids for " + name);
                kids = Convert.ToInt32(Console.ReadLine());
                family[i] = new string[kids];

                Console.WriteLine("\nEnter their names: ");
                for(int c = 0; c < family[i].Length; c++)
                {
                    family[i][c] = Console.ReadLine();
                }
            }


            Console.WriteLine("\n\nThe family names are: ");
            for(int i = 0; i < family.Length; i++)
            {
                for(int c = 0; c < family[i].Length; c++)
                {
                    Console.Write(family[i][c]+"  ");
                }
                Console.WriteLine("\n-------------");
            }
        }
    }
}


