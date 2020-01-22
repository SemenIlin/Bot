using AnswersOfBots.Interfaces;
using Interfaces.AnswersOfBots;

namespace AnswersOfBots
{
    public class AnswerOfIntelligent : IAnswer<string>
    {
        private readonly IContentAnswer<string> content;

        public AnswerOfIntelligent(IContentAnswer<string> content) 
        {
            this.content = content;
        }
        public string Answer()
        {
            return content.Content();
        }
    }
}
