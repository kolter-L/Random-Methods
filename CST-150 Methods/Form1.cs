namespace CST_150_Methods
{
    public partial class FrmMain : Form
    {

        private void DisplayResults(string descText, bool clearLabel)
        {
            if (clearLabel)
            {
                lblResults.Text = "";
            }

            lblResults.Text += string.Format("{0}\n", descText);
        }
        private void SumInts(int num1, int num2)
        {
            int sum = num1 + num2;

            DisplayResults("Method 1: The sum of " + num1 + ", " + num2 + " = " + sum, true);   
        }

        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
        {
            double divisor = 5.0D;
            double AvgNum = (num1 + num2 + num3 + num4 + num5) / divisor;

            return AvgNum;
        }

        private int RandomInt()
        {
            int num1 = 0, num2 = 0, sum = 0;

            Random Rand = new Random();

            num1 = Rand.Next(1, 101);
            num2 = Rand.Next(1, 101);

            sum = num1 + num2;

            return sum;
        }

        private bool DivByTwo(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;

            if(sum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FewestChars(string string1, string string2)
        {
            int countChar1 = 0, countChar2 = 0, pointer = 0;

            do
            {
                try
                {

                    if (char.IsLetter(string1[pointer]))
                    {
                        countChar1++;
                    }
                }
                catch(Exception e)
                {
                    // do nothing since string 1 has come to an end :(
                }

                try
                {

                    if (char.IsLetter(string2[pointer]))
                    {
                        countChar2++;
                    }
                }
                catch (Exception e)
                {
                    // do nothing since string 2 has come to an end :(
                }

                pointer++;


            }
            while ((pointer < string1.Length) || (pointer < string2.Length));

            if(countChar1 < countChar2)
            {
                DisplayResults("Method 5: string 1 has fewer letters", false);
            }
            else if(countChar2 < countChar1)
            {
                DisplayResults("Method 5: string 2 has fewer letters", false);
            }
            else
            {
                DisplayResults("Method 5: both strings have the same number of letters.", false);
            }
        }

        private double LargestDouble(double[] arrDoubles)
        {
            int arrPointer = 0;
            double valueAtIndex = 0D;
            double biggestDouble = 0D;

            while(arrPointer < arrDoubles.Length)
            {
                valueAtIndex = arrDoubles[arrPointer];  
                
                if(valueAtIndex > biggestDouble)
                {
                    biggestDouble = valueAtIndex;   
                }

                arrPointer++;
            }

            return biggestDouble;
        }

        // Kolter's Methods:


        // #7 array builder thingy
        private int[] RandomArray()
        {
            int[] randomArray = new int[10];

            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                randomArray[i] = random.Next(1, 10); 
            }

            return randomArray; 
        }

        // #8 Two boolean checking method 

        private bool TooTrue(bool bool1, bool bool2)
        {
            if(bool1 == bool2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // #9 Product of int and double

        private double DoubleProduct(int num1, double dub1)
        {
            double output = 0D;

            double numDub = (double)num1;

            output = numDub * dub1;

            return output;
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool mybool1 = false, mybool2 = false;

            int num1 = 2, num2 = 3, num3 = 4;

            double dub1 = 5.9D, dub2 = 2.3D, dub3 = 4.5D, dub4 = 5.1D, dub5 = 8.2D;

            int randomSum = 0;

            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.5D, 45.3D };

            string firstString = "this is the test number 82.";
            string secondString = "the sky is blue today";

            SumInts(num1, num2);

            DisplayResults("Method 2: Avg of 5 doubles is: " + AvgValue(dub1, dub2, dub3, dub4, dub5), false);

            randomSum = RandomInt();
            DisplayResults(string.Format("Method 3: Sum of random ints: {0}", randomSum.ToString()), false);

            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults("Method 4: Is sum of 3 ints div by 2: " + isDivisibleByTwo.ToString(), false);



            FewestChars(firstString, secondString);

            double maxDouble = LargestDouble(doubles);  
            DisplayResults(string.Format("Method 6: The Largest Double is: {0}", maxDouble.ToString()), false);

            // random array method implemented

            int[] randomArray = new int[10];
            randomArray = RandomArray();

            DisplayResults("Method 7: Here is a randomly-generated array with 10 characters: ", false);

            for(int i = 0; i < 10; i++)
            {
                DisplayResults(randomArray[i].ToString(), false); 
            }

            // Two booleans method implemented

            bool bothTrue = TooTrue(mybool1, mybool2);

            DisplayResults("Method 8: The booleans have the same value: " +  bothTrue.ToString(), false);

            // Product of Integer and Double Implemented

            double myDouble = DoubleProduct(num1, dub1);

            DisplayResults("Method 9: the prodcut of " + num1.ToString() + " and " + dub1.ToString() + " is " + myDouble.ToString(), false);   

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
