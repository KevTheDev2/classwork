using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardProject
{
    public class PlayingCard
    {

        /**********************************************************
         * Data for the class - Instance Data
         * 
         * Instance Data means every object has it's own copy of the data
         */

        private string suit; 
        private string color;
        //                       Ace                            jack queen king
        private int    value; // 1,  2, 3, 4, 5, 6, 7, 8, 9, 10, 11,  12,   13
        // Contructor for a PlayingCard - get all the values from the user

        public PlayingCard(string suitName, string theColor, int theValue)
        {
            suit = suitName;
            value = theValue;
            color = theColor;

        }

        // ToString() so we can use a PlayingCard as a string
        public override string ToString()
        {
            return $"Value: {value} Color: {color} Suit: {suit}";

        }
    }
}
