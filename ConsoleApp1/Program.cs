

using System.Diagnostics;

namespace blablabla
{

    class Program
    {
        static void Main()
        {
            {

                string pass;
               
                
                
               
                bool num = false, low_letters = false, high_letters = false, symbols = false;
                pass = Console.ReadLine();
                char[] charPass = pass.ToCharArray();
               
                
                for (int i = 0; i < pass.Length; i++)
                {
                    for (int j = 0; j < pass.Length; j++)
                        switch (charPass[i])
                        {
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                num = true;
                                break;
                            case 'q':
                            case 'w':
                            case 'e':
                            case 'r':
                            case 't':
                            case 'y':
                            case 'u':
                            case 'i':
                            case 'o':
                            case 'p':
                            case 'a':
                            case 's':
                            case 'd':
                            case 'f':
                            case 'g':
                            case 'h':
                            case 'j':
                            case 'k':
                            case 'l':
                            case 'z':
                            case 'x':
                            case 'c':
                            case 'v':
                            case 'b':
                            case 'n':
                            case 'm':
                                low_letters = true;
                                break;
                            case 'Q':
                            case 'W':
                            case 'E':
                            case 'R':
                            case 'T':
                            case 'Y':
                            case 'U':
                            case 'I':
                            case 'O':
                            case 'P':
                            case 'A':
                            case 'S':
                            case 'D':
                            case 'F':
                            case 'G':
                            case 'H':
                            case 'J':
                            case 'K':
                            case 'L':
                            case 'Z':
                            case 'X':
                            case 'C':
                            case 'V':
                            case 'B':
                            case 'N':
                            case 'M':
                                high_letters = true;
                                break;
                            case '!':
                            case '#':
                            case '$':
                            case '%':
                            case '&':
                            case '(':
                            case ')':
                            case '*':
                            case '+':
                                symbols = true;
                                break;
                        }
                }
                
                 int count = pass.Length;
                 Console.WriteLine("Ваш пароль :" + pass + "  , количество выполненных условий для надежности пароля : ");
                 if (count >= 8 && high_letters == true && low_letters == true && symbols == true && num == true)
                     Console.WriteLine("5");

                 else if ((count >= 8 && high_letters == true && low_letters == true && symbols == true && num == false) ||
                     (count >= 8 && high_letters == true && low_letters == true && symbols == false && num == true) ||
         (count >= 8 && high_letters == true && low_letters == false && symbols == true && num == true) ||
         (count >= 8 && high_letters == false && low_letters == true && symbols == true && num == true) ||
         (count < 8 && high_letters == true && low_letters == true && symbols == true && num == true))
                     Console.WriteLine("4");

                 else if ((count >= 8 && high_letters == true && low_letters == true && symbols == false && num == false) ||
                     (count >= 8 && high_letters == true && low_letters == false && symbols == false && num == true) ||
                     (count >= 8 && high_letters == false && low_letters == false && symbols == true && num == true) ||
                     (count < 8 && high_letters == false && low_letters == true && symbols == true && num == true) ||
                     (count < 8 && high_letters == true && low_letters == false && symbols == true && num == false) ||
                     (count < 8 && high_letters == true && low_letters == true && symbols == false && num == true) ||
                     (count < 8 && high_letters == true && low_letters == true && symbols == true && num == false) ||
                     (count >= 8 && high_letters == true && low_letters == false && symbols == true && num == false) ||
                     (count >= 8 && high_letters == false && low_letters == true && symbols == false && num == true) ||
                     (count >= 8 && high_letters == true && low_letters == false && symbols == false && num == true))
                     Console.WriteLine("3");

                 else if ((count >= 8 && high_letters == true && low_letters == false && symbols == false && num == false) ||
                     (count >= 8 && high_letters == false && low_letters == false && symbols == false && num == true) ||
                     (count < 8 && high_letters == false && low_letters == false && symbols == true && num == true) ||
                     (count < 8 && high_letters == true && low_letters == false && symbols == false && num == true) ||
                     (count < 8 && high_letters == true && low_letters == true && symbols == false && num == false) ||
                     (count < 8 && high_letters == false && low_letters == true && symbols == false && num == true) ||
                     (count < 8 && high_letters == false && low_letters == true && symbols == true && num == false) ||
                     (count < 8 && high_letters == true && low_letters == false && symbols == true && num == false) ||
                     (count >= 8 && high_letters == false && low_letters == true && symbols == false && num == false) ||
                     (count >= 8 && high_letters == false && low_letters == false && symbols == true && num == false))
                     Console.WriteLine("2");

                 else if ((count >= 8 && high_letters == false && low_letters == false && symbols == false && num == false) ||
                     (count < 8 && high_letters == true && low_letters == false && symbols == false && num == false) ||
                     (count < 8 && high_letters == false && low_letters == true && symbols == false && num == false) ||
                     (count < 8 && high_letters == false && low_letters == false && symbols == true && num == false) ||
                     (count < 8 && high_letters == false && low_letters == false && symbols == false && num == true))
                     Console.WriteLine("1");
                

            }
        }
    }
}
