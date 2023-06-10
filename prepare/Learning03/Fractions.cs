using System;
    public class Fraction
    {
        private int _top;
        private int _bottom;
        public Fraction()
        {
            int _top = 1;
           int _bottom = 1;
        }
        public Fraction(int wholeNum)
        {
            _top = wholeNum;
            int _bottom = 1;
        }
        public Fraction(int top, int bottom)
        {
            _top = top; 
            _bottom = bottom;
        }
        public string GetFractionString()
        {
            string text = $"{_top}/{_bottom}";
            return text;
        }
        public double SetDecimalvalue()
        {
            return (double)_top / (double)_bottom;
        }
    }