namespace Players_and_Monsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elf elf = new Elf("Elf", 1);
            Console.WriteLine(elf.ToString());

            MuseElf museElf = new MuseElf("MuseElf", 2);
            Console.WriteLine(museElf.ToString());

            Wizard wizard = new Wizard("Wizard", 3);
            Console.WriteLine(wizard.ToString());

            DarkWizard darkWizard = new DarkWizard("DarkWizard", 4);
            Console.WriteLine(darkWizard.ToString());

            SoulMaster soulMaster = new SoulMaster("SoulMaster", 5);
            Console.WriteLine(soulMaster.ToString());

            Knight knight = new Knight("Knight", 6);
            Console.WriteLine(knight.ToString());

            DarkKnight darkKnight = new DarkKnight("DarkKnight", 7);
            Console.WriteLine(darkKnight.ToString());

            BladeKnight bladeKnight = new BladeKnight("BladeKnight", 8);
            Console.WriteLine(bladeKnight.ToString());
        }
    }
}