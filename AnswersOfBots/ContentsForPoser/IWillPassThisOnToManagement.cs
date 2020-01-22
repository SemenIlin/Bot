using AnswersOfBots.Interfaces;
namespace AnswersOfBots.ContentsForIntelligent
{
    public class IWillPassThisOnToManagement : IContentAnswer<string>
    {
        public string Content()
        {
            return "Я передам это руководству.";
        }
    }
}
