using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is : ");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

        
        public String MyFunctionA(string input)
        {
            //Write a C# program to find the longest word in a string.
            string[] words = input.Split(' ');
            int wordarrayLength = words.Length;
            String longestword = words[0];
            int[] wordsLength = new int[words.Length];
            for (int s = 0; s < words.Length; s++)
            {
                wordsLength[s] = words[s].Length;
            }