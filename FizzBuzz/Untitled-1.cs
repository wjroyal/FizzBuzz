//Write a public method that accepts a number
public string FizzBuzz(int number)
{
    var answer = "";

    //when the number is divisible by 3 return the word fizz
    if (number % 3 == 0)
    {
        answer = "fizz";
    }

    if (number % 5 == 0)
    {
        answer += "buzz";
    }

        //when the number is divisible by both, return the word fizzbuzz
    return answer;
}