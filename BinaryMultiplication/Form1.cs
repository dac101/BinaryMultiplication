using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryMultiplication
{
    public partial class Form1 : Form
    {
         TuringFunctions _turingFunctions = new TuringFunctions();
        BitConversion bitConversion = new BitConversion();

        public Form1()
        {
            InitializeComponent();
        }

        private void DecimalInput_Click(object sender, EventArgs e)
        {
            resultTextbox.Clear();
            decimal x = userInput.Value;
            int y = decimal.ToInt32(x);
            var userResult = bitConversion.Conversion(y);

            userResult.RemoveAt(0);
            bitConversion.BinaryToUnary(userResult);
            resultTextbox.AppendText(bitConversion.TxtToDisPlay);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextbox.Clear();
            decimal x = userInput.Value;
            int y=   decimal.ToInt32(x);
            bitConversion.Conversion(y);
            resultTextbox.AppendText(bitConversion.TxtToDisPlay);
        }

        private void multiplicationBinary_Click(object sender, EventArgs e)
        {
            resultTextbox.Clear();
            decimal x = userInput.Value;
            int y = decimal.ToInt32(x);
          
            var userResult =   bitConversion.Conversion(y);
            userResult.RemoveAt(0);

            var unaryConversationValue = bitConversion.BinaryToUnary(userResult);
            var reserveString = bitConversion.ReverseListRegisterFunctionList(userResult);

            var getlastTwoString = _turingFunctions.GetLastTwoValue(reserveString);
            var getlastTwoStringUnary = bitConversion.BinaryToUnary(getlastTwoString);

            _turingFunctions.BinaryMultipication(unaryConversationValue, getlastTwoStringUnary);
            resultTextbox.AppendText(_turingFunctions.TxtToDisPlay);
        }

        private void unary_Click(object sender, EventArgs e)
        {
            resultTextbox.Clear();
            decimal x = userInput.Value;
            int y = decimal.ToInt32(x);
            var userResult = bitConversion.Conversion(y);

            userResult.RemoveAt(0);
            bitConversion.BinaryToUnary(userResult);
            resultTextbox.AppendText(bitConversion.TxtToDisPlay);
        }

     
    }
}
