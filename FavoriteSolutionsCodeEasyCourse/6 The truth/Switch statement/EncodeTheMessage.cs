using System;

namespace SwitchStatement
{
    class SubstitutionCipher
    {
        static void Main()
        {
            string stringMessage = Console.ReadLine();
            char[] encodedMessage = new char[stringMessage.Length];
            for (int i = 0; i < stringMessage.Length; i++)
            {
                encodedMessage[i] = stringMessage[i];// created array
            }

            char[] encodedMessageLower = new char[encodedMessage.Length];
            for (int i = 0; i < stringMessage.Length; i++)
            {
                encodedMessageLower[i] = char.ToLower(stringMessage[i]);// created lower letter array for changing chars
            }

            for (int i = 0; i < encodedMessageLower.Length; i++) // analized every char in array enodedMessageLower and changed symbols
            {
                switch (encodedMessageLower[i])
                {
                    case 'f':
                        encodedMessage[i] = '!';
                        break;
                    case 'g':
                        encodedMessage[i] = '@';
                        break;
                    case 't':
                        encodedMessage[i] = '#';
                        break;
                    case 'h':
                        encodedMessage[i] = '$';
                        break;
                    case 'y':
                        encodedMessage[i] = '%';
                        break;
                    case 'b':
                        encodedMessage[i] = '^';
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(encodedMessage);// output encodedMessage, here Upper Letters saved 
        }
    }
}
/*We like ciphers at the resistance base. For internal communication, we use a substitutional cipher. The idea is very simple: every letter in the incoming message is substituted with a different symbol. Your task is to partially encode a string message given to your program as an input and output the encoded message. Leave all letters except for the following:

F and f: replace with !
G and g: replace with @
T and t: replace with #
H and h: replace with $
Y and y: replace with %
B and b: replace with ^

For Example:
>After seeinG my dark Future, I can't continue living in the Boring past.
A!#er seein@ m% dark !u#ure, I can'# con#inue livin@ in #$e ^orin@ pas#.*/