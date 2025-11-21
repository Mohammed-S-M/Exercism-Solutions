public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        if (strand == "")
        {
            return Array.Empty<string>();
        }

        string[] strandCollection = AddSeparator(strand).Split("-");
        string[] proteinCollection = new string[strandCollection.Length];

        int elementCounter = 0;
        int index = 0;
        while (index < strandCollection.Length && ProteinName(strandCollection[index]) != "STOP")
        {
            if (ProteinName(strandCollection[index]) != "STOP")
            {
                proteinCollection[index] = ProteinName(strandCollection[index]);
                elementCounter++;
            }
            index++;
        }

        string[] finalResult = new string[elementCounter];
        for (int i = 0; i < finalResult.Length; i++)
        {
            finalResult[i] = proteinCollection[i];
        }

        return finalResult;
    }

    private static string AddSeparator(string strand)
    {
        string result = "";

        for (int i = 0; i < strand.Length; i++)
        {
            if (i % 3 == 0 && i != 0)
            {
                result += "-";
                result += strand[i];
            }
            else
            {
                result += strand[i];
            }
        }

        return result;
    }

    private static string ProteinName(string proteinCode)
    {
        string result = "";

        if (proteinCode == "AUG")
        {
            result = "Methionine";
        }
        else if (proteinCode == "UUU" || proteinCode == "UUC")
        {
            result = "Phenylalanine";
        }
        else if (proteinCode == "UUA" || proteinCode == "UUG")
        {
            result = "Leucine";
        }
        else if (proteinCode == "UCU" || proteinCode == "UCC" || proteinCode == "UCA" || proteinCode == "UCG")
        {
            result = "Serine";
        }
        else if (proteinCode == "UAU" || proteinCode == "UAC")
        {
            result = "Tyrosine";
        }
        else if (proteinCode == "UUU" || proteinCode == "UUC")
        {
            result = "Phenylalanine";
        }
        else if (proteinCode == "UGU" || proteinCode == "UGC")
        {
            result = "Cysteine";
        }
        else if (proteinCode == "UGG")
        {
            result = "Tryptophan";
        }
        else if (proteinCode == "UAA" || proteinCode == "UAG" || proteinCode == "UGA")
        {
            result = "STOP";
        }

        return result;
    }
}