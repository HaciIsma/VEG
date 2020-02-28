using System;

namespace VEG
{
    public enum VegetableName
    { 
        Cabbage,
        Turnip,
        Radish,
        Carrot,
        Parsnip,
        Beetroot,
        Lettuce,
        Beans,
        Peas,
        Potato,
        Eggplant,
        Tomato,
        Cucumber,
        Pumpkin,
        Onion,
        Garlic,
        Leek,
        Pepper 
    }
    public enum VegetableState 
    { 
        Fresh,
        Normal,
        Rotten,
        Toxic
    }
    public enum StoreStatus 
    { 
        Open, 
        Buy,
        Sorted,
        Epidem,
        Bankrupt
    }
    class Controller
    {
        public void Control()
        {
            Console.CursorVisible = false;
            Console.SetBufferSize(120, 40);
            Console.SetWindowSize(100, 43);

            Store s = new Store();

            s.OpenStore();

            Console.Read();
        }
    }
}
