﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer speech = new SpeechSynthesizer();
            //Console.WriteLine("Please listen carefully and answer y/n");
            ////speech.SelectVoice("ScanSoft Katerina_Full_22kHz");
            //speech.Speak("Hello there! How are you? What do you think about my voice? Isn't it perfect?");
            //char answer = Console.ReadKey().KeyChar;
            //if (answer.ToString().ToLower() == "y")
            //{
            //    speech.Speak("Oh! Thank you!");
            //}
            //else
            //{
            //    speech.Speak("Ouch! Nooo!");
            //}

            GradeBook book = new GradeBook();
            book.GradeAdded += OnGradeAdded;
            NewMethod(book);
        }
        static void OnGradeAdded(object sender, ItemAddedEventArgs args)
        {
            Console.WriteLine($"New gared was added { args.newGrade.ToString() }");
        }

        private static void NewMethod(GradeBook book)
        {
            book.AddGrade(.25f);
            book.AddGrade(40);
            book.AddGrade(60);
            GradeBookResult res = book.ComputeResult();
            Console.WriteLine(res.ToString());
            Console.ReadKey();
        }
    }
}
