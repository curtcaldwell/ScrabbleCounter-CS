using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class ScrabbleScoreCount
  {
    public int scrabbleScore = 0;

    public char[] one = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
    public char[] two = {'d', 'g'};
    public char[] three = {'b', 'c', 'm', 'p'};
    public char[] four = {'f', 'h', 'v', 'w', 'y'};
    public char[] five = {'k'};
    public char[] eight = {'j', 'x'};
    public char[] ten = {'q', 'z'};

    public void FindChar(char[] scrabbleString)
    {
      foreach(char scrabb in scrabbleString)
      {
        foreach(char c in one)
        {
          if(scrabb == c)
          {
            scrabbleScore++;
          }
        }
        foreach(char c in two)
        {
          if(scrabb == c)
          {
            scrabbleScore += 2;
          }
        }
        foreach(char c in three)
        {
          if(scrabb == c)
          {
            scrabbleScore += 3;
          }
        }
        foreach(char c in four)
        {
          if(scrabb == c)
          {
            scrabbleScore += 4;
          }
        }
        foreach(char c in five)
        {
          if(scrabb == c)
          {
            scrabbleScore += 5;
          }
        }
        foreach(char c in eight)
        {
          if(scrabb == c)
          {
            scrabbleScore += 8;
          }
        }
        foreach(char c in ten)
        {
          if(scrabb == c)
          {
            scrabbleScore += 10;
          }
        }
      }
      // return scrabbleScore;
      // char[] splitChar = scrabbleString.ToCharArray();
      // for(int i = 0; i < 11; i++)
      // {
      //   if(splitChar[i] = one[i])
      //   {
      //     scrabbleScore++;
      //   }
      // }
    }
    public int GetScore()
    {
      return scrabbleScore;
    }
     public void ClearScore()
     {
       scrabbleScore = 0;
     }

  }
  public class Program
  {
    public static void Main()
    {
      ScrabbleScoreCount newWord = new ScrabbleScoreCount();
      Console.WriteLine("gimma a word: ");
      string userString = Console.ReadLine();
      userString = userString.ToLower();
      char[] userCharArray = userString.ToCharArray();
      newWord.FindChar(userCharArray);
      int score = newWord.GetScore();
      Console.WriteLine(score);
    }
  }
}
