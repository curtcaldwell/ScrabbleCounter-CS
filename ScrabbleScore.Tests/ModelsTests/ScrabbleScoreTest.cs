using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore;
using System;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScoreTest
  {
    // public void Dispose()
    // {
    //   ScrabbleScoreCount.ClearAll();
    // }
    // [TestMethod]
    // public void ScrabbleScore_FindCharA_True()
    // {
    //   ScrabbleScoreCount newWord = new ScrabbleScoreCount();
    //   newWord.FindChar("a");
    //   int result = newWord.GetScore();
    //   int score = 1;
    //   Assert.AreEqual(result, score);
    // }
    // [TestMethod]
    // public void SetString_UserStringSet_Equal()
    // {
    //   ScrabbleScoreCount newWord = new ScrabbleScoreCount();
    //   string doggy = "Doggo.";
    //   string result = newWord.SetString("Doggo.");
    //   Assert.AreEqual(doggy, result);
    // }
     [TestMethod]
     public void ScrabbleScore_FindCharOnePoint_True()
     {
       ScrabbleScoreCount newWord = new ScrabbleScoreCount();
       int result = newWord.FindChar("stone");
       int score = newWord.GetScore();
       Assert.AreEqual(score, 5);
     }
    [TestMethod]
    public void ScrabbleScore_FindCharTwoPoint_True()
    {
      ScrabbleScoreCount newWord = new ScrabbleScoreCount();
      newWord.ClearScore();
      int result = newWord.FindChar("ddgg");
      int score = newWord.GetScore();
      Assert.AreEqual(score, 8);
    }
    [TestMethod]
    public void ScrabbleScore_FindCharThreePoint_True()
    {
      ScrabbleScoreCount newWord = new ScrabbleScoreCount();
      newWord.ClearScore();
      int result = newWord.FindChar("bcmp");
      int score = newWord.GetScore();
      Assert.AreEqual(score,12);
    }
    [TestMethod]
    public void ScrabbleScore_FindCharFourPoint_True()
    {
      ScrabbleScoreCount newWord = new ScrabbleScoreCount();
      newWord.ClearScore();
      int result = newWord.FindChar("fhvwy");
      int score = newWord.GetScore();
      Assert.AreEqual(score, 20);
    }
    [TestMethod]
    public void ScrabbleScore_FindCharFivePoint_True()
    {
      ScrabbleScoreCount newWord = new ScrabbleScoreCount();
      newWord.ClearScore();
      int result = newWord.FindChar("k");
      int score = newWord.GetScore();
      Assert.AreEqual(score, 5);
    }
    [TestMethod]
    public void ScrabbleScore_FindCharEightPoint_True()
    {
    ScrabbleScoreCount newWord = new ScrabbleScoreCount();
    newWord.ClearScore();
    int result = newWord.FindChar("jx");
    int score = newWord.GetScore();
    Assert.AreEqual(score,16);
    }
    [TestMethod]
    public void ScrabbleScore_FindCharTenPoint_True()
    {
      ScrabbleScoreCount newWord = new ScrabbleScoreCount();
      newWord.ClearScore();
      int result = newWord.FindChar("qz");
      int score = newWord.GetScore();
      Assert.AreEqual(score,20);
    }
  }
}
