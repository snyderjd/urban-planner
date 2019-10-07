using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building
    {
    // Private Fields
    // _designer of type string. It will hold your name.
    // _dateConstructed of type DateTime.This will hold the exact time the building was created.
    // _address of type string.
    // _owner of type string. This will store the same of the person who owns the building.

        private string _designer = "Joe Snyder";
        private DateTime _dateConstructed = new DateTime();
        private string _address;
        private string _owner;

        // Public Properties
        // Stories typed as an integer.
        // Width typed as a double.
        // Depth typed as a double.
        // Volume should be read-only and should return width* depth * (3 * # of stories). Each story is 3 meters high.
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (Stories * 3);
            }
        }

        // The constructor's logic should set the _address field's value to the argument value
        // Public Methods
        // Define a Construct() method.The method's logic should set the _dateConstructed field's value to DateTime.Now.
        // Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building.The method should take that string and assign it to the private _owner field.
        // Neither of these methods will return a value.

        // Methods
        public Building(string address) {
            _address = address;
        }
        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaserName) {
            _owner = purchaserName;
        }

        public string GetAddress() {
            return _address;
        }

        public DateTime GetDateConstructed() {
            return _dateConstructed;
        }

        public string GetDesigner() {
            return _designer;
        }

        public string GetOwner() {
            return _owner;
        }

    }
}