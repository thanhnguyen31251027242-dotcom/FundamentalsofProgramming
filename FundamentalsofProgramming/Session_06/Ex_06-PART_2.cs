using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming.Session_06
{
    internal class Ex_06_PART_2
    {
        //1.Requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        // Bubble Sort
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        //2.Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
        // Linear Search
        static bool LinearSearch(string[] words, string target)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower() == target.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        static void Main()
        {
            //1.Requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
            int[] arr = new int[10];

            // Input 10 integers
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Sort array
            BubbleSort(arr);

            // Output sorted array
            Console.WriteLine("Array after Bubble Sort:");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            //2.Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
            // Request a sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Request a word
            Console.Write("Enter a word to search: ");
            string word = Console.ReadLine();

            // Split sentence into words
            string[] words = sentence.Split(' ');

            // Search word using linear search
            if (LinearSearch(words, word))
            {
                Console.WriteLine("The word appears in the sentence.");
            }
            else
            {
                Console.WriteLine("The word does not appear in the sentence.");
            }
        }
    }
}
