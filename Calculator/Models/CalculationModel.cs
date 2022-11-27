using System;

namespace Calculator.Models
{
    public class CalculationModel
    {
        private string result;

        public string FirstOperand { get; set; }
        public string SecondOperand { get; set; }
        public string Operation { get; set; }
        public string Result { get { return result; } }

        public void CalculateResult()
        {
            switch (Operation)
            {
                case "+":
                    result = (Convert.ToDouble(FirstOperand) + Convert.ToDouble(SecondOperand)).ToString();
                    break;

                case "-":
                    result = (Convert.ToDouble(FirstOperand) - Convert.ToDouble(SecondOperand)).ToString();
                    break;

                case "*":
                    result = (Convert.ToDouble(FirstOperand) * Convert.ToDouble(SecondOperand)).ToString();
                    break;

                case "/":
                    result = (Convert.ToDouble(FirstOperand) / Convert.ToDouble(SecondOperand)).ToString();
                    break;
            }
        }
    }
}
