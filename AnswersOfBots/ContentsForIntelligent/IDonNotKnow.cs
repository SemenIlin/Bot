using AnswersOfBots.Interfaces;

namespace AnswersOfBots.ContentsForIntelligent
{
    public class IDonNotKnow : IContentAnswer<string>
    {
        public string Content()
        {
            return "Я не знаю чем Вам помочь.";
        }
    }
}
