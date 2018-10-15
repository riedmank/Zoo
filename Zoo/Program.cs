using System;
using Zoo.Classes;

namespace Zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AmericanAlligator Alligator = new AmericanAlligator();
            Alligator.numTeeth = 50;
            Alligator.canFly = false;
            Alligator.canSwim = true;
            NileCrocodile Crocodile = new NileCrocodile();
            Crocodile.numTeeth = 60;
            Crocodile.canFly = false;
            Crocodile.canSwim = true;
            SpectacledCaiman Caiman = new SpectacledCaiman();
            Caiman.numTeeth = 40;
            Caiman.canFly = false;
            Crocodile.canSwim = true;

            AmericanCrow Crow = new AmericanCrow();
            Crow.colorType = "black";
            Crow.canFly = true;
            Crow.canSwim = false;
            CommonRaven Raven = new CommonRaven();
            Raven.colorType = "slightly darker black";
            Raven.canFly = true;
            Raven.canSwim = false;
            WesternJackdaw Jackdaw = new WesternJackdaw();
            Jackdaw.colorType = "gray";
            Jackdaw.canFly = true;
            Jackdaw.canSwim = false;
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string AlligatorEat()
        {
            AmericanAlligator Alligator = new AmericanAlligator();
            return Alligator.Eat();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string CrocodileEat()
        {
            NileCrocodile Crocodile = new NileCrocodile();
            return Crocodile.Eat();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string CaimanEat()
        {
            SpectacledCaiman Caiman = new SpectacledCaiman();
            return Caiman.Eat();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string CrowEat()
        {
            AmericanCrow Crow = new AmericanCrow();
            return Crow.Eat();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string RavenEat()
        {
            CommonRaven Raven = new CommonRaven();
            return Raven.Eat();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string JackdawEat()
        {
            WesternJackdaw Jackdaw = new WesternJackdaw();
            return Jackdaw.Eat();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string AlligatorSleep()
        {
            AmericanAlligator Alligator = new AmericanAlligator();
            return Alligator.Sleep();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string CrocodileSleep()
        {
            NileCrocodile Crocodile = new NileCrocodile();
            return Crocodile.Sleep();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string CaimanSleep()
        {
            SpectacledCaiman Caiman = new SpectacledCaiman();
            return Caiman.Sleep();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string CrowSleep()
        {
            AmericanCrow Crow = new AmericanCrow();
            return Crow.Sleep();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string RavenSleep()
        {
            CommonRaven Raven = new CommonRaven();
            return Raven.Sleep();
        }

        /// <summary>
        /// Method created for test
        /// </summary>
        /// <returns>Returns a string</returns>
        public static string JackdawSleep()
        {
            WesternJackdaw Jackdaw = new WesternJackdaw();
            return Jackdaw.Sleep();
        }
    }
}
