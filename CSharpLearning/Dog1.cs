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

        //^^^^ The same thing vvvv

        private string _name;
        public string MyProperty
        {
            get { return _name; }
            private set
            {
                _name = value;
            }
        }

        public void Speak(string what = "bark")
        {
            // TODO
        }

        public void Speak(int times, string what = "bark", bool sit = true)
        {
            // TODO
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
        void x()
        {
            Speak(2, sit: true);
        }
    }
}
