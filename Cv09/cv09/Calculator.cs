using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace cv09
{
    class Calculator
    {
        private Stav _stav= Stav.FirstNumber;
        public String Display { get; set; }//What we see
        public String Memory { get; set; }//Empty

        private string one="";
        private Operation operation ;
        private string two = "";
        private string answer = "";

        public void Button(String btn) {

            var number="";

            switch (btn)
            {
                case "0":
                    number += "0";
                    break;

                case "1":
                    number += "1";
                    break;

                case "2":
                    number += "2";
                    break;

                case "3":
                    number += "3";
                    break;

                case "4":
                    number += "4";
                    break;

                case "5":
                    number += "5";
                    break;

                case "6":
                    number += "6";
                    break;

                case "7":
                    number += "7";
                    break;

                case "8":
                    number += "8";
                    break;

                case "9":
                    number += "9";
                    break;

                case "+":
                    _stav = Stav.Operation;
                    operation = Operation.Plus;
                    break;

                case "-":
                    _stav = Stav.Operation;
                    operation = Operation.Minus;
                    break;

                case "*":
                    _stav = Stav.Operation;
                    operation = Operation.Times;
                    break;

                case "/":
                    _stav = Stav.Operation;
                    operation = Operation.Divide;
                    break;

                case "=":
                    _stav = Stav.Result;
                    answer = FindAnswer();
                    Display = answer;
                    one = "";
                    two = "";
                    answer = "";
                    break;

                case ",":
                    _stav = Stav.Operation;
                    operation = Operation.Dot;
                    break;

                case "+-":
                    if (Display != "") { 
                        if (_stav == Stav.FirstNumber) {
                            var tmp=Convert.ToDouble(one) * -1;
                            one = "" + tmp;
                        }
                        if (_stav == Stav.SecondNumber) {
                            var tmp = Convert.ToDouble(two) * -1;
                            two = "" + tmp;
                        }
                    }
                    break;

                case "CE":// delete actual number
                    if (_stav == Stav.FirstNumber)
                    {
                        one = "";
                        Display = one;
                    }
                    if (_stav == Stav.SecondNumber)
                    {
                        two = "";
                        Display = two;
                    } 
                    break;

                case "C":// delete all
                    _stav = Stav.FirstNumber;
                    Display = answer;
                    one = "";
                    two = "";
                    answer = "";
                    break;

                case "<="://delete one letter
                    if (_stav == Stav.FirstNumber)
                    {
                        one = one.Substring(0, one.Length - 1);
                        Display = one;
                    }
                    if (_stav == Stav.SecondNumber)
                    {
                        two = one.Substring(0, two.Length - 1);
                        Display = two;
                    }
                    break;

                case "MS":
                    Memory = Display;
                    break;

                case "MR":
                    if (_stav == Stav.FirstNumber)
                    {
                        one = Memory;
                    }
                    if (_stav == Stav.SecondNumber)
                    {
                        two = Memory;
                    }

                    Display = Memory;
                    break;

                case "MC":
                    Memory = "";
                    break;

                default:
                    break;

            }

            switch (_stav) {
                case Stav.FirstNumber:
                    one += number;
                    Display = one;
                    break;
                case Stav.SecondNumber:
                    two += number;
                    Display = two;
                    break;
                case Stav.Operation:
                    _stav = Stav.SecondNumber;
                    break;
                case Stav.Result:
                    _stav = Stav.FirstNumber;
                    break;
            }
        }

        private enum Operation
        {
            Plus,
            Minus,
            Times,
            Divide,
            Dot
        };

        private enum Stav
        {
            FirstNumber,
            Operation,
            SecondNumber,
            Result
        };

        private string FindAnswer() {
            var o = Convert.ToDouble(one);
            var t = Convert.ToDouble(two);
            double ans = 0;

            switch (operation) {
                case Operation.Plus:
                    ans = o + t;
                    break;
                case Operation.Minus:
                    ans = o - t;
                    break;
                case Operation.Times:
                    ans = o * t;
                    break;
                case Operation.Divide:
                    ans = o / t;
                    break;
                case Operation.Dot:
                    ans = ',' + o;
                    break;
            }

            return "" + ans;
        }
    }
}
