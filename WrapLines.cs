public List<string> WrapLines(string[] words, int k)
{
    var response = new List<string>() { "" };

    var index = 0;

    foreach (string word in words)
    {
        var willHaveSpace = response[index].Length + word.Length < k;

        if (willHaveSpace)
        {
            response[index] = response[index] == ""
                ? word
                : response[index] + "-" + word;
        }
        else
        {
            response.Add(word);
            index += 1;
        }
    }

    return response;
}
