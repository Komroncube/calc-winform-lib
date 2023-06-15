namespace ClassLibrary1
{
    public class Calc
    {
        public Calc() { }
        private double result;

        public double hisobla(double son1, double son2, string operation)
        {
            switch (operation)
            {
                case "+":
                    result = son1 + son2; break;
                case "-":
                    result = son1 - son2; break;
                case "*":
                    result = son1 * son2; break;
                case "/":
                    result = son1 / son2; break;
                case "%":
                    result = son1 % son2; break;
            }
            return result;
        }
    }
}
