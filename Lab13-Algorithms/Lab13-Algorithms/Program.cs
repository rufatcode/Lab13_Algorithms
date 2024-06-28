#region 1

using System.Text;

//Console.WriteLine(LongestNonRepeatingString("abcabcbb"));
//esgerxan

string LongestNonRepeatingString(string text)
{
    string resoult = "";
    string temp = "";
    for (int i = 0; i < text.Length-1; i++)
    {
        
        for (int j = i; j < text.Length; j++)
        {
            if (!temp.Contains(text[j]))
            {
                temp += text[j];
            }
            else
            {
                if (temp.Length > resoult.Length)
                {
                    resoult = temp;
                }
                temp = "";
                break;
            }
        }
        if (temp.Length > resoult.Length)
        {
            resoult = temp;
        }
        temp = "";
        
    }
    return resoult;
}

#endregion
#region 2
//Console.WriteLine(LongestPolindrom("cbbd"));

string LongestPolindrom(string text)
{
    string resoult = "";
    string temp = "";
    for (int i = 0; i < text.Length-1; i++)
    {
        temp = text[i].ToString();
        for (int j = i+1; j < text.Length; j++)
        {
            temp += text[j];
            if (IsPolindrom(temp)&&temp.Length>resoult.Length)
            {
                resoult = temp;
            }
        }
        temp = "";
        
    }
    return resoult;
}
bool IsPolindrom(string text)
{
    string reverseText = "";
    for (int i = text.Length-1; i >=0; i--)
    {
        reverseText += text[i];
    }
    return reverseText == text;
}
#endregion

#region 3
//var resoult= LetterCombinations("2");

List<string> LetterCombinations(string digits)
{
    Dictionary<char, List<string>> numbersCouples = new Dictionary<char, List<string>>();
    numbersCouples.Add('2', new List<string> { "a", "b", "c" });
    numbersCouples.Add('3', new List<string> { "d", "e", "f" });
    numbersCouples.Add('4', new List<string> { "g", "h", "i" });
    numbersCouples.Add('5', new List<string> { "j", "k", "l" });
    numbersCouples.Add('6', new List<string> { "m", "n", "o" });
    numbersCouples.Add('7', new List<string> { "p", "q", "r","s" });
    numbersCouples.Add('8', new List<string> { "t", "u", "v" });
    numbersCouples.Add('9', new List<string> { "w", "x", "y","z" });
    List<string> resoult = new List<string>();
    List<List<string>> datas = new List<List<string>>();
    for (int i = 0; i < digits.Length; i++)
    {
        datas.Add(numbersCouples[digits[i]]);
    }
    if (datas.Count==1)
    {
        return datas[0];
    }
    else
    {
        for (int i = 0; i < datas[0].Count; i++)
        {
            for (int j = 0; j < datas[1].Count; j++)
            {
                resoult.Add(datas[0][i] + datas[1][j]);
            }
        }
    }
    return resoult;
}

#endregion

#region 4
//Console.WriteLine(FirstOccurence("tybutsda", "sad"));
int FirstOccurence(string haystack, string needle)
{
    string temp = "";
    
    for (int i = 0; i < haystack.Length-needle.Length+1; i++)
    {
        for (int j = i; j < i+needle.Length; j++)
        {
            temp += haystack[j];
        }
        if (temp==needle)
        {
            return i;
        }
        temp = "";
    }
    return -1;
}
#endregion

#region 5
Console.WriteLine(AsciiResoult("hello"));
int AsciiResoult(string text)
{
    byte[] bytes = Encoding.ASCII.GetBytes(text); //[104,105,109]
    int resoult = 0;
    for (int i = 0; i < bytes.Length-1; i++)
    {
        resoult += Math.Abs(bytes[i] - bytes[i + 1]);
    }
    return resoult;
}
#endregion

#region 6
//Console.WriteLine(IndexDifferencesSum("abc", "cba"));
int IndexDifferencesSum(string word1,string word2)
{
    int resoult = 0;
    if (word1.Length!=word2.Length)
    {
        return -1;
    }
    for (int i = 0; i < word1.Length; i++)
    {
        if (!word2.Contains(word1[i]))
        {
            return -1;
        }
        for (int j = i+1; j < word1.Length; j++)
        {
            if (word1[i] == word1[j])
            {
                return -1;
            }
        }
        resoult += Math.Abs(i - word2.IndexOf(word1[i]));
    }
    return resoult;
}

#endregion

#region 8
//Console.WriteLine(InterpretsCommand("G()()()()(al)"));
 string InterpretsCommand(string comand)
{
    string resoult = "";

    for (int i = 0; i < comand.Length; i++)
    {
        if (comand[i]=='G')
        {
            resoult += 'G';
        }
        else if (comand[i] == '(' && comand[i+1]==')')
        {
            resoult += "o";
            i += 1;
        }
        else
        {
            resoult += "al";
            i += 3;
        }
    }

    return resoult;
}
#endregion






