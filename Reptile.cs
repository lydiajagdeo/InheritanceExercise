using System;
namespace Inheritance
{
    public class Reptilen: Animal
    {
        //public Reptile()
        //{
        //}

        public bool HasATail { get; set; }
        public bool HasScales{ get; set; }
        public bool IsSlimy { get; set; }
        public bool LivesInSwamps{ get; set; }



        public void DinasaurFeatures()
        {
            Console.WriteLine($"A dinasaur has a tail :{HasATail}, has scales: {HasScales}, but is not Slimy {IsSlimy} or likes living in a swamp {LivesInSwamps}");
        }
    }
}
