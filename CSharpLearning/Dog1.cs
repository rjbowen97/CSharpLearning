using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //Partial spreads the class out across Dog1 and Dog2
    public partial class Dog
    {
        //Properties hold values
        public string Name { get; set; }

        //The above is really the same as below

        private string MyName;

        public string MyProperty
        {
            get { return MyName; }
            set { MyName = value; }
        }


        //Only by the class
        private void Foo() { }
        
        //Only by this and derived classes
        //protected void Bar() { }

        //Only in this assembly
        internal void Bar() { }
    }

    class Poodle : Dog
    {
    }
}
