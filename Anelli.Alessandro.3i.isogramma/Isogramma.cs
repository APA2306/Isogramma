using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {

        
        int lenght = word.Length;
        string parola = word.ToLower();
        char[] array = parola.ToCharArray();
        int y;

        for (int i = 0; i < lenght; i++)
        {
            y = i + 1;
            while(y<lenght)
            {
                if(array[i] == array[y] && array[i] != ' ' &&  char.IsLetter(array[i]))
                {
                    return false;

                }
                y++;
            }

        }

        return true;

    }
}