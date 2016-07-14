using System;
using System.Collections.Generic;

namespace HangMan.objects
{
  public class Word
  {
    private int _worldLength;
    private int _id;

    private int _correctGuess;
    private int _incorrectGuess;
    private string _stringWord;
    public static int _increaseMe = 0;
    private static List<string> _words = new List<string>{};
    public static List<string> GuessWord = new List<string>{};
    public static List<Word> _info = new List<Word>{};

    public string guessStringWord;


    public Word(List<string> secertWord)
    {

      _words=secertWord;
      Console.WriteLine(_words);
      guessStringWord="";
      _stringWord=string.Join("",secertWord.ToArray());
      _worldLength=secertWord.Count;
      _correctGuess=0;
      _incorrectGuess=0;
      _info.Add(this);
      _id=_info.Count;
      Console.WriteLine(_id);
    }



    public static Word FindGame(int searchId)
    {
      return _info[searchId-1];
    }


    public int GetId()
    {
      return _id;
    }

    public string GetStringWord()
    {
      return _stringWord;
    }
    public int GetWorldLength()
    {
      return _worldLength;
    }
    public int GetCorrectGuess()
    {
      return _correctGuess;
    }
    public int GetIncorrectGuess()
    {
      return _incorrectGuess;
    }
    public void SetWorldLength(int newWorld)
    {
      _worldLength = newWorld;
    }
    public void SetIncorrectGuess(int newIncorrectGuess)
    {
      _incorrectGuess = newIncorrectGuess;
    }

    public void SetCorrectGuess(int newCorrectGuess)
    {
      _correctGuess = newCorrectGuess;
    }
    public void SetStringWord(string newStringWord)
    {
      _stringWord = newStringWord;
    }
    public List<string> GetAllChar()
    {
      return _words;
    }

    public void CompareWords(string guess)
    {
      _increaseMe += 1;
      Console.WriteLine(_increaseMe);
     string temp = this.GetStringWord();
     Console.WriteLine(temp);
     if (temp.Contains(guess))
     {
       this.SetCorrectGuess(this.GetCorrectGuess()+1);
       Console.WriteLine(this.GetStringWord());
       this.SetStringWord(this.GetStringWord().Replace(guess,"0"));
        Console.WriteLine(this.GetStringWord().Replace(guess,"0"));
     }
     else{
       this.SetIncorrectGuess(this.GetIncorrectGuess()+1);

     }
    }
  }

}
