namespace ChallengesSolutions
{
    public partial class Problems
    {

        /// <summary>
        /// Amazon Test "Amazon Fresh Promotion" Problem
        /// found at https://swabhaw.com/2020/10/07/amazon-fresh-promotion/
        /// </summary>
        /// <param name="arr"></param>
        public static bool AmazonPromotionWinner(List<string> codeList, List<string> shoppingCart)
        {
            if (shoppingCart == null || shoppingCart.Count == 0)
                return false;
            if (codeList == null || codeList.Count == 0)
                return true;

            List<List<string>> codeGroups = new List<List<string>>();

            foreach (string code in codeList)
            {
                codeGroups.Add(code.Split(',').ToList());
            }


            int groupIndex = 0;
            int codeIndex = 0;
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                if (groupIndex == codeGroups.Count) break;
                var item = shoppingCart[i];
                var codeTest = codeGroups[groupIndex][codeIndex];
                if (codeTest == item || codeTest == "anything")
                {
                    codeIndex++;
                    if (codeIndex == codeGroups[groupIndex].Count)
                    {
                        groupIndex++;
                        codeIndex = 0;
                    }
                }
                else
                {
                    codeIndex = 0;
                }

            }
            return groupIndex == codeGroups.Count;
        }

        public static bool WinPrize(string[][] codeList, string[] shoppingCart)
        {
            // checking corner cases
            if (codeList == null || codeList.Length == 0)
                return true;
            if (shoppingCart == null || shoppingCart.Length == 0)
                return false;

            int i = 0, j = 0;
            while (i < codeList.Length && j + codeList[i].Length <= shoppingCart.Length)
            {
                bool match = true;
                for (int k = 0; k < codeList[i].Length; k++)
                {
                    if (!codeList[i][k].Equals("anything") && !shoppingCart[j + k].Equals(codeList[i][k]))
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    j += codeList[i].Length;
                    i++;
                }

                j++;

            }
            return i == codeList.Length;
        }
    }
}
