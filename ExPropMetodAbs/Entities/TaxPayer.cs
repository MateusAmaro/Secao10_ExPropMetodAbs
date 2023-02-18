using System;
using System.Collections.Generic;

namespace ExPropMetodAbs.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }


        #region Methods


        public abstract double Tax();


        #endregion

    }
}
