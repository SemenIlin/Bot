using Interfaces.AnswersOfBots;
using AnswersOfBots;
using AnswersOfBots.ContentsForIntelligent;
using System;
using System.Collections.Generic;
using Common;
using AnswersOfBots.Interfaces;
using AnswersOfBots.ContentsForInsolent;
using AnswersOfBots.ContentsForPoser;

namespace ConsoleBot
{
    public class ConsoleBotE
    {
        private readonly Random randomForAnswer = new Random();

        private readonly int numberForIntelligent;
        private readonly int numberForInsolent;
        private readonly int numberForPoser;

        private readonly MyStringConverter stringConverter;

        private readonly IAnswer<string>[] bot = new IAnswer<string>[3];
        private readonly List<IContentAnswer<string>> contentsForIntelligent = new List<IContentAnswer<string>>(3)
        {
            new IFindItDifficultToAnswer(),
            new OkayAnythingElse(),
            new IDonNotKnow()
        };
        private readonly List<IContentAnswer<string>> contentsForInsolent;
        private readonly List<IContentAnswer<string>> contentsForPoser = new List<IContentAnswer<string>>(4)
        {
            new IDoNotWrite(),
            new IHaveBusiness(),
            new IWillPassThisOnToManagement(),
            new WaitALittle()
        };
        
        public ConsoleBotE(string message)
        {
            contentsForInsolent = new List<IContentAnswer<string>>(3)
            {
                new DoYouHaveCatOnKeyboard(),
                new WhatAreYouSleeping(),
                new FindDifferences(message)
            };

            numberForIntelligent = randomForAnswer.Next(0, contentsForIntelligent.Count);
            numberForInsolent = randomForAnswer.Next(0, contentsForInsolent.Count);
            numberForPoser = randomForAnswer.Next(0, contentsForPoser.Count);

            stringConverter = new MyStringConverter(message);

            bot[0] = new AnswerOfInsolent(contentsForInsolent[numberForInsolent]);
            bot[1] = new AnswerOfIntelligent(contentsForIntelligent[numberForIntelligent]);
            bot[2] = new AnswerOfPoser(contentsForPoser[numberForPoser]);
        }

        public string Answer()
        {
            if(!stringConverter.IsValidLength || !stringConverter.IsValidSence)
            {
                return bot[0].Answer();
            }
            else if(stringConverter.IsQuestion)
            {
                return bot[1].Answer();
            }
            else
            {
                return bot[2].Answer();
            }
        }
    }
}
