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
