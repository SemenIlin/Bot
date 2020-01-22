using System.Text.RegularExpressions;

namespace Common
{
    public class MyStringConverter
    {
        private readonly char[] vowel = { 'у', 'ё', 'е', 'ы', 'а', 'о','э', 'я', 'и', 'ю'};

        public MyStringConverter(string message)
        {
            message = Regex.Replace(message, @"\s+", " ");
            Message = message.ToLower();
            Words = message.Split(' ');
        }

        public bool IsValidLength 
        {
            get
            {
                foreach(var word in Words)
                {
                    if(word.Length > 25)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public bool IsValidSence
        {
            get
            {
                int counterVowel;
                int counterConsonant;

                foreach (var word in Words)
                {
                    counterVowel = 0;
                    counterConsonant = 0;

                    for (int i = 0; i < word.Length; ++i)
                    {
                        for (int j = 0; j < vowel.Length; ++j)
                        {
                            if (word[i] == vowel[j])
                            {
                                ++counterVowel;
                                counterConsonant = 0;
                                break;
                            }
                            else if(j == vowel.Length - 1)
                            {
                                ++counterConsonant;
                                counterVowel = 0;
                            }
                        }
                        if((counterVowel >= 4) || 
                           (counterConsonant > 4) )
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public bool IsQuestion
        {
            get
            {

                foreach(var symbol in Message)
                {
                    if(symbol == '?')
                    {
                        return true;
                    }
                }

                return false;
            }        
        }

        public string[] Words { get;  }

        public string Message { get; }

    }
}
