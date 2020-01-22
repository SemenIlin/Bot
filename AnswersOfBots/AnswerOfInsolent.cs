using AnswersOfBots.Interfaces;
using Interfaces.AnswersOfBots;

namespace AnswersOfBots
{
    public class AnswerOfInsolent : IAnswer<string>
    {
        private readonly IContentAnswer<string> content;

        public AnswerOfInsolent(IContentAnswer<string> content)
        {
            this.content = content;
        }

        public string Answer()
        {
            return content.Content();
        }   
    }
}
