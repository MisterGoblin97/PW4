namespace PW4._1
{
    class Spell 
    {
        public string Name { get; set; }
        public int Mana { get; private set; }
        private string Effect { get; set; }

        public Spell (string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }

        public string use() 
        {
           return Effect;    
        }
    }

    class Magician
    { 
        public string Name { get; private set; }
        public int Mana { get; private set; }

        public Magician(string name, int mana) 
        {
            Name = name;
            Mana = mana;
        }

        public void CastSpell(Spell spell)
        {
            if (Mana <= spell.Mana)
            {
                int manaNeed = spell.Mana - Mana;
                Console.WriteLine($"Для использования {spell.Name} не хватает {manaNeed} едениц маны. Хлебни зелья! хехе");
                
            }
            else
            { 
                spell.use();
                Mana -= spell.Mana;

                Console.WriteLine($"Колдун {Name} колдует! {spell.use()}");
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            Spell FireBall = new Spell("Огненный шар", 49, "Огненый шар взорвался, это четко.");
            Spell ParseTwoString = new Spell("запарсить пару строчек", 50, "Строки запарились?? Ну нормульче");

            Magician Krestinenko = new Magician("Крестиненко", 50);
            Magician Mertsalov = new Magician("Мерцалов Сергей Александрович", 49);

            Krestinenko.CastSpell(FireBall);
            Mertsalov.CastSpell(ParseTwoString);
        }
    }
}