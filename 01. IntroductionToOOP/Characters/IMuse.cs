using _01.IntroductionToOOP.Weapons.DarkAge;
using _01.IntroductionToOOP.Characters.Body;
using System;

namespace _01.IntroductionToOOP.Characters
{
    public interface IMuse
    {
        int MagickPoints { get; set; }
        GlassBottle Weapon { get; set; }

        void ChiBlast(Character character);//Polymorphism: instead of targetting one type of character, you can target any type by using the base class (Character)

        void ChiRefresh();
    }
}
