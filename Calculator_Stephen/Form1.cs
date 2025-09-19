namespace Calculator_Stephen
{
    public partial class Form1 : Form
    {

        double firstNumber = 0;
        string operation = "";
        bool isSecondNumber = false;
        int closeWarningCount = 0;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNumber = double.Parse(textBox1.Text);
            operation = btn.Text; // Stores the operations (+,-,*,/)
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNumber = double.Parse(textBox1.Text);
            operation = btn.Text; // Stores the operations (+,-,*,/)
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNumber = double.Parse(textBox1.Text);
            operation = btn.Text; // Stores the operations (+,-,*,/)
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNumber = double.Parse(textBox1.Text);
            operation = btn.Text; // Stores the operations (+,-,*,/)
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox1.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Cannot divide by zero!");
                    break;
            }

            textBox1.Text = result.ToString();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isSecondNumber)
            {
                textBox1.Clear();
                isSecondNumber = false;
            }

            textBox1.Text += btn.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNumber = double.Parse(textBox1.Text);
            operation = btn.Text;
            isSecondNumber = true;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox1.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Last time I checked, you can't divide that number by zero!", "It hurts me when you act like a troglodyte.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
            }

            textBox1.Text = result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstNumber = 0;
            operation = "";
            isSecondNumber = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeWarningCount++;

            if (closeWarningCount == 1)
            {
                MessageBox.Show("You didn't mean to press the exit button, right?", "Warning 1",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // prevent closing
            }
            else if (closeWarningCount == 2)
            {
                MessageBox.Show("Oh... You, uh, really did want to close?", "Warning 2",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // prevent closing
            }
            else if (closeWarningCount == 3)
            {
                MessageBox.Show("Come on! I know you have more calculations to do, y'know...", "Warning 3",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // prevent closing
            }
            else
            {
                // After enough warnings, let the program close
                MessageBox.Show("OKAY FINE, get outta here already!", "Goodbye",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = false; // allow closing
            }
        }
    }
}
