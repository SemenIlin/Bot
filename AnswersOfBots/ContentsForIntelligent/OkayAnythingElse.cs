using AnswersOfBots.Interfaces;

namespace AnswersOfBots.ContentsForIntelligent
{
    public class OkayAnythingElse : IContentAnswer<string>
    {
        public string Content()
        {
            return "Хорошо, что-нибудь еще?";
        }
    }
}
