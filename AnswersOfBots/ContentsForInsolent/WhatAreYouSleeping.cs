using AnswersOfBots.Interfaces;

namespace AnswersOfBots.ContentsForInsolent
{
    public class WhatAreYouSleeping : IContentAnswer<string>
    {
        public string Content()
        {
            return "Ты что там, уснул?";
        }
    }
}
