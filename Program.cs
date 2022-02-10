using System;

namespace VariableExersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            string catName = "Garfield";
            int catAge = 5;
            char middleInitial = 'V';
            bool isBald = false;
            double exactAge = 5.7;
            decimal myMoney = 100.000000454m;

            Console.WriteLine(catName);
            Console.WriteLine(catAge);
            Console.WriteLine(middleInitial);
            Console.WriteLine(isBald);
            Console.WriteLine(exactAge);
            Console.WriteLine(myMoney);
            Console.WriteLine($"My dogs name is {catName}, He is {catAge} years old, His middle initial is {middleInitial}, Many people think my cat is bald but that is {isBald}, \n" +
                $"The vet told me his exact age is {exactAge}, I currently have {myMoney} dollars");




        }
    }
}
