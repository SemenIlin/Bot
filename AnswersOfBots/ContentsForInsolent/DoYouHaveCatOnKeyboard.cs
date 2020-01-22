using AnswersOfBots.Interfaces;

namespace AnswersOfBots.ContentsForInsolent
{
    public class DoYouHaveCatOnKeyboard : IContentAnswer<string>
    {
        public string Content()
        {
            return "Кошка на клавиатуре?";
        }
    }
}
