using System;

namespace Problems
{
    public class Program
    {
        public static void Prefix(string input){
            if (input == null){
                Console.WriteLine("null");
            }
            else {
                int a =0, numWords =1;
                int string_length = input.Length;
                while (a <= string_length -1){
                    if(input[a]==' ' || input[a]=='\n' || input[a]=='\t'){
                        numWords++;
                    }
                    a++;           
                }
                Console.WriteLine(string_length + "," + numWords + ":" + input);   
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string string_input;
            string_input = Console.ReadLine();
            Prefix(string_input);
        }
    }
}
