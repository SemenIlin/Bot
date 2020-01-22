using AnswersOfBots.Interfaces;

namespace AnswersOfBots.ContentsForPoser
{
    public class WaitALittle : IContentAnswer<string>
    {
        public string Content()
        {
            return "Подожди немного, отвечу позже.";
        }
    }
}
