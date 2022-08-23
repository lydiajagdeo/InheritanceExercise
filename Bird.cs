using System;
namespace Inheritance
{
    public class Bird: Animal
    {
        public Bird()
        {
            Eyes = "Has 2";
            Heart = "Are different sizes";
            Offsring = "Is able to multiply";
            Mouth = "Feeds by mouth";
        }

        public bool HasABeak { get; set; }
        public bool HasWings{ get; set; }
        public bool HasFeathers { get; set; }
        public bool LayOnANest { get; set; }


        public void BirdFeature()
        {
            Console.WriteLine($" A bird has a beak :{HasABeak}, it has wings but not all birds can fly {HasWings}, they have feathers :{HasFeathers} and lay their eggs in a nest: {LayOnANest}");
        }
    }
}
