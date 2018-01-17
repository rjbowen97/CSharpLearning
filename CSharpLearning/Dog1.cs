using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{

    public class Trainer
    {
        void Operate()
        {
            var dog = new Poodle();
            dog.HasSpoken += Dog_HasSpoken;
        }

        private void Dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

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
            if (HasSpoken != null)
                HasSpoken(this, EventArgs.Empty);
        }

        public void Speak(int times, string what = "bark", bool sit = true)
        {
            // TODO
        }

        public event EventHandler HasSpoken;

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
