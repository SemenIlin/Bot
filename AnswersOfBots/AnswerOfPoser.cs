using AnswersOfBots.Interfaces;
using Interfaces.AnswersOfBots;

namespace AnswersOfBots
{
    public class AnswerOfPoser : IAnswer<string>
    {
        private readonly IContentAnswer<string> content;

        public AnswerOfPoser(IContentAnswer<string> content)
        {
            this.content = content;
        }
        public string Answer()
        {
            return content.Content();
        }
    }
}
