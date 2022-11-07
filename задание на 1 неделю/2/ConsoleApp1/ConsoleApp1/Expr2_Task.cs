namespace ConsoleApp1
{
    class Expr2_Task
    {
        /* Задается натуральное трехзначное число (гарантируется, 
         * что трехзначное). Развернуть его, т.е. получить трехзначное число,
         * записанное теми же цифрами в обратном порядке. */
        internal static int Reverse(int a)
        {
            // ваш код
            var userNumber = a;
            var units = userNumber % 10;
            var tens = (userNumber / 10) % 10;
            var hundreads = userNumber / 100;

            return units * 100 + tens * 10 + hundreads;
            
        }
    }
}
