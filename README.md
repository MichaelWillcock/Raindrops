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
The method contains 3 other if statements, 2 containing similar contents to the above, except adding "Plang" for a multiple of 5 and "Plong" for a multiple of 7. The final if statement returns the digits of a non multiple integer and is shown below.
```csharp
if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
    {
        a = $"{number}";
    }
```
The next step was to create unit tests, to check the functionality of the method. I started by creating testcases to check the basic functionality of the method ensuring the right strings were returned for the right input integer.

![FunctionalityTests](https://user-images.githubusercontent.com/81698105/119901755-34399a80-bf3e-11eb-9c94-0f7b0ff5e570.png)

The brief for the project contained examples and I thought it good practise to specifically test those examples just for the sake of propriety. They are listed below.

![BriefTests](https://user-images.githubusercontent.com/81698105/119902373-0a34a800-bf3f-11eb-81d3-f9d1ce042b6f.png)

The next set of tests all contain negative values of the Funtionality tests to ensure all the tests still pass for negative values.

![NegativeTests](https://user-images.githubusercontent.com/81698105/119902464-29333a00-bf3f-11eb-910d-07ae7010f63a.png)

The penultimate set of tests contain maximum and minimum integer values to ensure the edge cases are covered.

![ExtremeTests](https://user-images.githubusercontent.com/81698105/119902623-6697c780-bf3f-11eb-98a8-c7e3711405ed.png)

The final test tests zero as an input integer, since zero divided by any number results in zero the way the method is written should result in "PlingPlangPlong" being output.

![ZeroTestCase](https://user-images.githubusercontent.com/81698105/119902831-ae1e5380-bf3f-11eb-9ef4-e0ac6bb750f7.png)

The final screenshot documents all of the unit tests shown above passing.

![TestResults](https://user-images.githubusercontent.com/81698105/119903237-559b8600-bf40-11eb-81bf-8b0a1d5678fb.png)


