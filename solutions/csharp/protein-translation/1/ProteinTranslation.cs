public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string> proteins = new List<string>();
        string proteinStrand;
        bool devam = true;
        for (int i = 0; i < strand.Length && devam; i += 3)
        {
            proteinStrand = strand.Substring(i, 3);
            switch (proteinStrand)
            {
                case "AUG":
                    proteins.Add("Methionine");
                    break;
                case "UUU":
                case "UUC":
                    proteins.Add("Phenylalanine");
                    break;
                case "UUA":
                case "UUG":
                    proteins.Add("Leucine");
                    break;
                case "UCU":
                case "UCC":
                case "UCA":
                case "UCG":
                    proteins.Add("Serine");
                    break;
                case "UAU":
                case "UAC":
                    proteins.Add("Tyrosine");
                    break;
                case "UGU":
                case "UGC":
                    proteins.Add("Cysteine");
                    break;
                case "UGG":
                    proteins.Add("Tryptophan");
                    break;
                case "UAA":
                case "UAG":
                case "UGA":
                    devam = false;
                    break;
            }
        }

        return proteins.ToArray();
    }
}