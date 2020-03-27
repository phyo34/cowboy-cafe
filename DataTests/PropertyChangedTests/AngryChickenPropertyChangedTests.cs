/***
 * Author: May Phyo
 * Purpose of this class is to test the property changed in Angry Chicken
 * 
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class AngryChickenPropertyChangedTests
    {

        //Test 1: Angry Chicken should implement the INotifyPropertyChangedInterface

        //Test 2: Changing the "Bread" property should invoke PropertyChanged for "Bread"
        //Test 3: Changing the "Bread" property should invoke PropertyChanged for "SpecialInstructions"
        //Test 4: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        //Test 5: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"

    }
}
