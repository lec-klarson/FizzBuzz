using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using FizzBuzz.Models;

namespace FizzBuzz.Logic
{
    public class FizzBuzzProcessor
    {
        public IEnumerable<FizzBuzzResponse> ProcessFizzBuzz(string inputItems)
        {
            if (inputItems == null)
                return null;

            inputItems = RemoveBrackets(inputItems);

            string[] inputs = inputItems.Split(',');

            var responses = new List<FizzBuzzResponse>();
            foreach (var input in inputs)
            {
                var s = FizzBuzzResponse(input);  
                responses.AddRange(s);     
            }
            return responses;
        }

        private string RemoveBrackets(string inputStr)
        {
            if (inputStr[0].ToString() == "[")
                inputStr = inputStr.Substring(1);

            var lastBracket = inputStr.LastIndexOf(']');
            if (lastBracket != -1 && inputStr.Length == lastBracket+1)
                inputStr = inputStr.Remove(lastBracket, 1);

            return inputStr;
        }

        private List<FizzBuzzResponse> FizzBuzzResponse(string inputStr)
        {
            var responses = new List<FizzBuzzResponse>();
            int value;

            if(int.TryParse(inputStr, out value))
            {
                var fizzResponse = GetFizzBuzz(value,3,"Fizz");
                var buzzResponse = GetFizzBuzz(value,5,"Buzz");
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
                return responses;
            }

            responses.Add(new FizzBuzzResponse() { input = inputStr, response = "Invalid Item" });               
            return responses; 
        }

        private FizzBuzzResponse GetFizzBuzz(int value, int fbValue, string responseVal)
        {
                if(value%fbValue == 0)
                    return new FizzBuzzResponse() { input = value.ToString(), response = responseVal };
                else
                    return new FizzBuzzResponse() { input = value.ToString(), 
                        response = string.Format("Divided {0} by {1}", value, fbValue)};
        }        
    }
}