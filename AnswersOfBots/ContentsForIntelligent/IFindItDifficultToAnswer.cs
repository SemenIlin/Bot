using AnswersOfBots.Interfaces;

namespace AnswersOfBots.ContentsForIntelligent
{
    public class IFindItDifficultToAnswer : IContentAnswer<string>
    {
        public string Content()
        {
            return "Мне трудно ответить на этот вопрос.";
        }
    }
}
