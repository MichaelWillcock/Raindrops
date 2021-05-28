# Raindrops
Github Repo for Raindrops Test
### Project Outline
This project was created for the purpose of making a function that would return a string based off of an integer input parameter.

If the integer input was a multiple of 3 the function would return the string "Pling". If the integer was a multiple of 5 the function would return the string "Plang". If the integer was a multiple of 7 the function would return the string "Plong".

The function would was also return multiple combinations of the words if the integer was a multiple of more than one number. For example, if the integer was 15, a multiple of both 5 and 3, the function would return "PlingPlang" and if the integer was 35, a multiple of 5 and 7, the function would return "PlangPlong" and so on and so forth.

Finally, if the integer was not a multiple of 3, 5, or 7 the function would instead return the input integer.
```csharp
public static string RaindropsMethod(int number)
        {
            
        }
```
Above is the initial method created. Here the input integer and output string can be seen in the method signiture. Following that is an example showing one of the if statements contained within the code that adds the correct statement to the output string based on the input integer.
```csharp
if (number%3 == 0)
    {
        a += "Pling";
    }
```
The method contains 2 other if statements, both containing similar contents to the above, except adding "Plang" for a multiple of 5 and "Plong" for a multiple of 7. The methods return statement contains a more efficient ternary if statement, in order to return the digits of the input integer if it is not a multiple of 3, 5 or 7, and can be seen below. The .Trim() on the output string, should be irrelevant as there shouldn't be spaces at anypoint in the code, but are included anyway for good practice.
```csharp
return result == null ? number.ToString().Trim() : result.Trim();
```
The next step was to create unit tests, to check the functionality of the method, the total number of unique outputs of the method is 8. The majority of the tests contain 3 input variables, a positive integer that will return one of the unique outputs from the method, the negative version of the positive integer to ensure the method functions for numbers less than zero and an additional positive number to check that the method functions for larger multiples.

The first 3 test methods check that positive and negative multiples of only 3, 5 and 7 return "Pling", "Plang" and "Plong" respectively.

![IndividualResultTests](https://user-images.githubusercontent.com/81698105/119977120-ecebf200-bfaf-11eb-865d-952ab9de98cd.png)

The next 3 methods test the dual combiantions of multiple values with 3&5, 3&7 and 5&7 returning "PlingPlang", "PlingPlong" and "PlangPlong" respectively

![DualResultTests](https://user-images.githubusercontent.com/81698105/119977608-8fa47080-bfb0-11eb-9e7d-c85b34e8466d.png)

The next 2 methods test the final official functionality of the original method, the first testing that multiples of 3, 5 and 7 return "PlingPlangPlong" and the second method checking that if the input integer is not a multiple of any of the numbers it returns a string of the input integer.

![TrippleandNoResultTest](https://user-images.githubusercontent.com/81698105/119978186-3d178400-bfb1-11eb-9285-76cf63d54e01.png)

The final two tests are checking the edge cases of the maximum and minimum integer values and testing that zero gives the correct result which as zero is a universal multiple should return "PlingPlangPlong".

![EdgeCaseTests](https://user-images.githubusercontent.com/81698105/119978515-a39ca200-bfb1-11eb-8a2c-a954fb423be5.png)

The penultimate screenshot shows that all the previously shown unit tests pass upon execution.

![UnitTestResults](https://user-images.githubusercontent.com/81698105/119980039-a7c9bf00-bfb3-11eb-861b-82f622696689.png)

The benefit of creating the program.cs file as a project and now a class library is that I could also manually test the method that I had created. The result of these manual tests can be seen in the final screenshot below.

![ManualTests](https://user-images.githubusercontent.com/81698105/119980875-ce3c2a00-bfb4-11eb-82a7-066c860cf016.png)
