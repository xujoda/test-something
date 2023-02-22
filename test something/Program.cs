using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 06.12.22 LeetCode Rank 1 519 604
 * 07.12.22          Rank 1 450 545
 * 08.12.22          Rank 1 332 542 18+6+1
 * 13.12.22          Rank 1 285 130 19+7+1
 * 14.12.22          Rank 1 239 821 19+9+1
 * 19.12.22          Rank 1 243 813 19+9+1
 * 20.12.22          Rank 1 222 536 19+10+1
 * 22.12.22          Rank 1 203 012 20/11/1
 * 23.12.22          Rank 1 144 878 21/12/1
 * 16.02.23          Rank 1 096 325 22/19/1
 * 20.02.23          Rank 986 151   27/20/1
 */

namespace test_something
{
    public class Program
    {
        static int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            Console.WriteLine("first = {0}, last = {1}", first, last);
            if (first > last)
            {
                return -1;
            }
            var middle = first + (last - first) / 2;
            var middleValue = array[middle];
            Console.WriteLine("middle = {0}", middle);
            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    Console.WriteLine("new last = {0}", middle - 1);
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    Console.WriteLine("new left = {0}", middle + 1);
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }

        static int[] QuickSort(int[] array, int left, int right)
        {
            int l = left;
            int r = right;
            int avg = array[(l + r) / 2];
            do
            {
                while (array[l] < avg)
                    ++l;
                while (array[r] > avg)
                    --r;
                if (l <= r)
                {
                    int temp = array[l];
                    array[l] = array[r];
                    array[r] = temp;
                    ++l;
                    --r;
                }
            }
            while (l <= r);
            if (left < r)
                QuickSort(array, left, r);
            if (l < right)
                QuickSort(array, l, right);
            return array;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static Dictionary<char, string> pairs = new Dictionary<char, string>()
            {
                { '2',"abc" },
                { '3',"def" },
                { '4',"ghi" },
                { '5',"jkl" },
                { '6',"mno" },
                { '7',"pqrs" },
                { '8',"tuv" },
                { '9',"wxyz" },
            };

        static void swap(ref int a, ref int b)
        {
            var note = a;
            a = b;
            b = note;
        }

        static bool verticalVerif(char[,] board, char symbol, int column)
        {
            int res = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = column; j == column; j++)
                {
                    if (board[i, j] == symbol) res++;
                }
            }
            if (res > 1) return false;
            return true;
        }

        static bool horizontalVerif(char[,] board, char symbol, int row)
        {
            int res = 0;
            for (int i = row; i == row; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == symbol) res++;
                }
            }
            if (res > 1) return false;
            return true;
        }

        static bool sqrtVerif(char[,] board, char symbol, int m, int n)
        {
            int res = 0;

            for (int i = m; i < m + 3; i++)
            {
                for (int j = n; j < n + 3; j++)
                {
                    if (board[i, j] == symbol) res++;
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            if (res > 1) return false;
            return true;
        }


        static void Main(string[] args)
        {
            //string s = "(()";    //2
            //string s = ")()())"; //4
            string s = "(()()"; //4
            //string s = "()((())"; //4
            //string s = "()(()";  //2 
            //string s = "((()))()"; //8
            //string s = "()((())()()";//8

            //Console.WriteLine(s.);

            int res = 0;

            var reply = fun(s, res, 0);
            res = reply.Item1;
            s = reply.Item2;
            Console.WriteLine(s);
            Console.WriteLine("maxRes = " + res);
            Console.ReadLine();
        }



        static (int, string) fun(string s, int res, int maxRes)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '(' && s[i + 1] == ')')
                {
                    s = s.Remove(i, 2);
                    res += 2;

                    maxRes = fun(s, res, maxRes).Item1;
                }
                maxRes = res > maxRes ? res : maxRes;
            }
            if (s.Length == 1 && (s[0] == '(' || s[0] == ')')) maxRes -= 2;
            return (maxRes, s);
        }
    }
}