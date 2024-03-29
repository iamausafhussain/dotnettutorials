﻿namespace SingleTonDesignPattern
{
    public sealed class SingletonClass
    {

        public static int counter = 0;

        public static SingletonClass instance = null;
        public static SingletonClass GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonClass();
                return instance;
            }
        }

        private SingletonClass()
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");
        }

        public void Display(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
