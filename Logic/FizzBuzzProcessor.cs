using System;
using System.Collections.Generic;
using FizzBuzz.Models;

namespace FizzBuzz.Logic
{
    public class FizzBuzzProcessor
    {
        public IEnumerable<FizzBuzzResponse> ProcessFizzBuzz(string inputItems)
        {

            string[] inputs = inputItems.Split(',');

            var x = new List<FizzBuzzResponse>();
            foreach (var input in inputs)
            {
                var s = FizzBuzzResponse(input);  
                x.AddRange(s);     
            }
            return x;
        }

        private List<FizzBuzzResponse> FizzBuzzResponse(string inputStr)
        {
            var responses = new List<FizzBuzzResponse>();
            int value;

            if(int.TryParse(inputStr, out value))
            {
                var fizzResponse = GetFizzBuzz(value,3);
                var buzzResponse = GetFizzBuzz(value,5);
                if(fizzResponse.response == "Fizz" && buzzResponse.response == "Buzz")
                {
                    fizzResponse.response += "Buzz";
                    responses.Add(fizzResponse);
                    return responses;
                }
                if(fizzResponse.response == "Fizz")
                {
                    responses.Add(fizzResponse);
                    return responses;
                }
                if(buzzResponse.response == "Buzz")
                {
                    responses.Add(buzzResponse);
                    return responses;
                }
                responses.Add(fizzResponse);
                responses.Add(buzzResponse);
            }

            responses.Add(new FizzBuzzResponse() { input = inputStr, response = "Invalid Item" });               
            return responses; 
        }

        private FizzBuzzResponse GetFizzBuzz(int value, int fbValue)
        {
                if(value%fbValue == 0)
                    return new FizzBuzzResponse() { input = value.ToString(), response = "Fizz" };
                else
                    return new FizzBuzzResponse() { input = value.ToString(), 
                        response = string.Concat("Divided {0} by {1}", value, fbValue)};
        }        
    }
}