﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPGood
{

    public interface ITakePhoto 
    {
        void TakePhoto();
    }

    public class LSPGood
    {

        public abstract class BasePhone 
        {

            public void Call() 
            {
                Console.WriteLine("Arama yapıldı");
            }            

        }


        public class IPhone : BasePhone, ITakePhoto
        {
            public void TakePhoto()
            {
                Console.WriteLine("Fotoğraf çekildi.");
            }
        }


        public class Nokia3310 : BasePhone
        {
        }


    }
}
