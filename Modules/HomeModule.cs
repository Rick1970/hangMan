using Nancy;
using System.Collections.Generic;
using HangMan.objects;
using System;
namespace HangManList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {


      // Console.WriteLine(firstWords.GetCorrectGuess());
      // Console.WriteLine(firstWords.GetInCorrectGuess());

      Get["/"] = _ => {
      return View["index.cshtml"];
      };

      Get["/guess"] = _ => {
        List<string> myword = new List<string>{"p","i","g","l","a","t","i","n"};
        Word firstWords = new Word(myword);

      return View["test.cshtml",firstWords];
      };

    Post["/makeguss"] = _ => {
        Word startPlaying = Word.FindGame(Request.Form["player-id"]);
        Console.WriteLine("I submit a guss");
        Console.WriteLine(startPlaying);

        //
        Console.WriteLine(startPlaying.GetStringWord());
        string tempGuess= Request.Form["guess"];
        startPlaying.CompareWords(tempGuess);

        return View["test.cshtml",startPlaying];

    };
    }
  }
}
