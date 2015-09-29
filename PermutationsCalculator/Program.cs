namespace PermutationsCalculator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            Permute p = new Permute();
            string c = "ABC";
            char[] c2 = c.ToCharArray();
            /*calling the permute*/
            p.setper(c2);

            var list = Permute2.GetAllPermutation("abc");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
