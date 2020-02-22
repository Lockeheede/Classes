
namespace _01.IntroductionToOOP.Characters
{
using _01.IntroductionToOOP.Weapons.DarkAge;
    public interface ISpellcaster
    {
        int ChiPoints { get; set; }
        GlassBottle Weapon { get; set; }

        void ChiBlast(Character character);//Polymorphism: instead of targetting one type of character, you can target any type by using the base class (Character)

        void ChiRefresh();
    }
}
