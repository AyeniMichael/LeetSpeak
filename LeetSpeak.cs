using System;
using System.Collections.Generic;

namespace LeetSpeak
{
    class LeetSpeakTranslator
    {
        static void Main()
        {
            Console.WriteLine("Enter your text:");
            string inputString  = Console.ReadLine();  
            Translate(inputString);
        }

        static void Translate(string sentence)
        {
            char[] sentenceArray = sentence.ToCharArray(); 
            for (int i = 0; i<sentenceArray.Length; i++ )
            {
                if(sentenceArray[i] == 'e')
                {
                    sentenceArray[i] = '3';
                }
                else if (sentenceArray[i] == 'o')
                {
                    sentenceArray[i] = '0';
                }
                else if (sentenceArray[i] == 'I')
                {
                    sentenceArray[i] = '1';
                }
                else if (sentenceArray[i] == 't')
                {
                    sentenceArray[i] = '7';
                }
                else if (sentenceArray[i] == 's')
                {
                    sentenceArray[i] = 'z';
                }
            }
            string result = string.Join("", sentenceArray);
            Console.WriteLine("Your LeetSpeak translation:\n"  +result);

        }
    }    

}