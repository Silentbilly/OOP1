using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    abstract class MusicalInstruments
    {
        protected string brand { get; set; }
        protected string origin { get; set; }
        protected string userInterface { get; set; }
        protected string range { get; set; }
        protected bool modern { get; set; }
        protected float length { get; set; }
        protected float weight { get; set; }
        public float price { get; set; }
        protected int age { get; set; }
        protected double volume { get; set; }
        public abstract void GetInfo();
        public abstract void BrandSticker();
    }
    // Струнные инструменты.
    class Stringed : MusicalInstruments
    {
        public string deckMaterial;
        public string stringMaterial;
        public Stringed()
        {
            userInterface = "strings";
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Material of the deck: {deckMaterial}, material of {userInterface}: {stringMaterial}.");
        }
        public override void BrandSticker()
        {
            Console.WriteLine("The {0} {1} was made in {2}.", GetType().Name, brand, origin);
        }
    }
    // Духовые инструменты.
    class Brass : MusicalInstruments
    {
        public string family;
        public string material;
        public override void GetInfo()
        {
            Console.WriteLine($"Material of the instrument: {material}.");
        }
        public override void BrandSticker()
        {
            Console.WriteLine("The {4} {3} {0} {1} was made in {2}.", GetType().Name, brand, origin, range, family);
        }
    }
    // Клавишные инструменты.
    class Keyboard : MusicalInstruments
    {
        public string keyboardType;
        public string caseMaterial;
        public Keyboard()
        {
            userInterface = "keyboard";
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Type of the keyboard: {keyboardType}, material of the {GetType().Name}: {caseMaterial}.");
        }
        public override void BrandSticker()
        {
            Console.WriteLine("The {0} {1} was made in {2}.", GetType().Name, brand, origin);
        }
    }
    // Фортепиано. 
    class Piano : Keyboard
    {
        public Piano(string keyboardType, string caseMaterial, string brand, string origin, int price)
        {
            this.keyboardType = keyboardType;
            this.caseMaterial = caseMaterial;
            this.brand = brand;
            this.origin = origin;
            this.price = price;
        }
    }
    // Тромброн.
    class Trombone : Brass
    {
        public Trombone(string family, string brand, string origin, string range, int price)
        {
            material = "Brass";
            this.family = family;
            this.brand = brand;
            this.origin = origin;
            this.range = range;
            this.price = price;
        }
    }
    // Диджериду.
    class Didgeridoo : Brass
    {
        public Didgeridoo(string family, string brand, string origin, string range, string material, int price)
        {
            this.material = material;
            this.family = family;
            this.brand = brand;
            this.origin = origin;
            this.range = range;
            this.price = price;
        }
        public Didgeridoo(string family, string brand, string origin, string range, int price) : this(family, brand, origin, range, "wood",  price)
        {
            this.family = family;
            this.brand = brand;
            this.origin = origin;
            this.range = range;
            this.price = price;
        }
    }
    // Скрипка.
    class Viola : Stringed
    {
        public Viola(string deckMaterial, string stringMaterial, string brand, string origin, int price)
        {
            this.deckMaterial = deckMaterial;
            this.stringMaterial = stringMaterial;
            this.brand = brand;
            this.origin = origin;
            this.price = price;
        }
        public Viola(string brand, string origin, int price) : this("wood", "cooper", brand, origin, price)
        {
            this.brand = brand;
            this.origin = origin;
            this.price = price;
        }
    }
    // Гитара.
    class Guitar : Stringed
    {
        private string typeOfGuitar;
        public Guitar(string deckMaterial, string stringMaterial, string typeOfGuitar, string brand, string origin, int price)
        {
            this.typeOfGuitar = typeOfGuitar;
            this.deckMaterial = deckMaterial;
            this.stringMaterial = stringMaterial;
            this.brand = brand;
            this.origin = origin;
            this.price = price;
        }
        public Guitar(string brand, string origin, int price) : this("acoustic", "wood", "cooper", brand, origin, price)
        {
            this.brand = brand;
            this.origin = origin;
            this.price = price;
        }
        public override void BrandSticker()
        {
            Console.WriteLine("The {3} {0} {1} was made in {2}.", GetType().Name, brand, origin, typeOfGuitar);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Viola Brahner_bvc_370 = new Viola("plastic", "iron", "Brahner", "China", 4234);
            Brahner_bvc_370.BrandSticker();
            Brahner_bvc_370.GetInfo();
            Console.WriteLine();
            Viola Random666 = new Viola("VioFromAli", "New Zealand", 666);
            Random666.BrandSticker();
            Random666.GetInfo();
            Console.WriteLine();
            Guitar Yamaha_Pacifica_012_BL = new Guitar("wood", "iron", "electric", "Yamaha", "Japan", 34233);
            Yamaha_Pacifica_012_BL.BrandSticker();
            Yamaha_Pacifica_012_BL.GetInfo();
            Console.WriteLine();
            Trombone Roy_Benson_BT_260 = new Trombone("slide", "Roy_Benson", "Germany", "Baritone", 95434);
            Roy_Benson_BT_260.BrandSticker();
            Roy_Benson_BT_260.GetInfo();
            Console.WriteLine();
            Didgeridoo Yuka_DDP51_4 = new Didgeridoo("natural", "Yuka", "France", "tenor", "plastic", 4666);
            Yuka_DDP51_4.BrandSticker();
            Yuka_DDP51_4.GetInfo();
            Console.WriteLine();
            Piano Roland_PHA_4 = new Piano("hammer action", "composite", "Roland", "Japan", 23433);
            Roland_PHA_4.BrandSticker();
            Roland_PHA_4.GetInfo();
            Console.WriteLine();
            Console.WriteLine($"Prices of all objects {Brahner_bvc_370.price}, {Random666.price}, {Yamaha_Pacifica_012_BL.price}, {Roy_Benson_BT_260.price}, {Yuka_DDP51_4.price}, {Roland_PHA_4.price}.");
            Console.ReadKey();
        }
    }
}
