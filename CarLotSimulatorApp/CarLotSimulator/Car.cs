using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        #region Constructors
        public Car() { }

        public Car(string make, string model, string engineNoise, string honkNoise, int year, bool isDriveable) 
        {
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            Year = year;
            IsDriveable = isDriveable;
        }

        #endregion 

        #region Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }

        #endregion

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        #region Methods
        public void MakeEngineNoise()
        {            
            Console.WriteLine(HonkNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

        #endregion

    }
}
