using AnswersOfBots.Interfaces;

namespace AnswersOfBots.ContentsForPoser
{
    public class IDoNotWrite : IContentAnswer<string>
    {
        public string Content()
        {
            return "Я не могу ответить, я занят.";
        }
    }
}
