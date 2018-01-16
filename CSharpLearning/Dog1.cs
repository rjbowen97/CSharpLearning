using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //Partial spreads the class out across Dog1 and Dog2
    public partial class Dog
    {

        //Only by the class
        private void Foo() { }
        
        //Only by this and derived classes
        //protected void Bar() { }

        //Only in this assembly
        internal void Bar() { }
    }

    class Poodle : Dog
    {
        void x() { this.}
    }
}
