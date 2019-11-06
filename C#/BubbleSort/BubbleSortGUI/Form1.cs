using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BubbleSortGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array = new int[5];//Declared an array with lenght of 5



        //Genertes Random Values and assign it to the array that is declared
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            arrayLbl.Text = string.Empty;//clears the lable
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random(Guid.NewGuid().GetHashCode()).Next(1, 31);//Random number with random seed
                arrayLbl.Text += array[i] + " ";//Displays the Generated numbers in a label
            }
        }

        //swap function
        void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        //showing the bubble sort algorithm
        private void SortBtn_Click(object sender, EventArgs e)
        {
            int lastUnsorted = array.Length - 1;//setting the value to less than the length of the array
            bool isSorted = false;//showing the array is sorted or not        
            while (!isSorted)//loop based on isSorted flag to sort the array
            {
                isSorted = true;
                for (int i = 0; i < lastUnsorted; i++)//scrolling the whole array with this
                {

                    if (array[i] > array[i + 1])//comparing values two by two
                    {
                        isSorted = false;//setting flag to false just in case to make sure we got the loop running
                        swap(array, i, i + 1);//swaping numbers
                    }
                }
                lastUnsorted--;//decresing the last unsorted in order to make the algorithem faster!
            }
            //displays the sorted array
            arrayLbl.Text = string.Empty;
            foreach (int i in array)
                arrayLbl.Text += i + " ";
        }
    }
}
