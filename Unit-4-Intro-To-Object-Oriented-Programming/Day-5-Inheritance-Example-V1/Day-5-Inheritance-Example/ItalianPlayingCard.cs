using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Inheritance_Example
{
    public class ItalianPlayingCard : PlayingCard
    {
        // Define a default ctor that calls the bass clas contructor
        public ItalianPlayingCard() : base(0, "Joker", "Black"); {}

        // Define a 2-arg ctor for value and suit
        public ItalianPlayingCard(int theValue, string theSuit, string theColor); 
    : base(theValue, theSuit, theColor)
    }
}
