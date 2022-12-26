using System.Configuration;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private TextBox Display() => this.Display1;
        private const string DisplayText = "0";
        private bool CheckStage = false;
        private double sum = 0;
        private string Op = "+";
        public Calculator()
        {
            InitializeComponent();
            Display().Text = DisplayText;
        }

        private void btnNumberController(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                Dot();
            }
            else
            {
                Number(((Button)sender).Text);
            }
        }

        public void Dot()
        {
            if (CheckStage)
            {
                CheckStage = false;
                Display().Text = DisplayText;
            }
            if (Display().Text.Contains("."))
            {
                return;
            }
            else
            {
                Display().AppendText(".");
            }
        }

        public void Number(string num)
        {
            if (CheckStage)
            {
                CheckStage = false;
                Display().Text = DisplayText;
            }
            Display().AppendText(num);
            if (Display().Text.Contains("."))
            {
                return;
            }
            else
            {
                Display().Text = Double.Parse(Display().Text).ToString("#,##0");
            }
        }

        public void Execute(string op)
        {
            Display().Text.TrimEnd('.');
            Display2.AppendText($" {Display().Text} {op}");
            double DisplayOP = Double.Parse(Display().Text);
            CheckStage = true;
            if (Op == "/" && Display().Text == "0")
            {
                Display().Text = double.Parse(DisplayText).ToString("#,##0");
                return;
            }
            switch (Op)
            {
                case "+":
                    sum += DisplayOP;
                    break;
                case "-":
                    sum -= DisplayOP;
                    break;
                case "*":
                    sum *= DisplayOP;
                    break;
                case "/":
                    sum /= DisplayOP;
                    break;
                default:
                    break;
            }
            Op = op;
            Display().Text = sum.ToString("#,##0");
        }

        public void Clear()
        {
            sum = 0;
            Display2.Clear();
            Display().Text = DisplayText;
            CheckStage = false;
        }

        public void ClearCE()
        {
            Display().Text = double.Parse(DisplayText).ToString("#,##0");
            CheckStage = false;
        }
        private void OperationContoller(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    Execute("+");
                    break;
                case "-":
                    Execute("-");
                    break;
                case "*":
                    Execute("*");
                    break;
                case "/":
                    Execute("/");
                    break;
                case "=":
                    Execute("+");
                    string result = Display().Text;
                    Clear();
                    CheckStage = true;
                    Display().Text = double.Parse(result).ToString("#,##0");
                    break;
                default:
                    break;
            }
        }
        private void ClearController(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text == "C")
            {
                Clear();
            }
            else
            {
                ClearCE();
            }
        }
    }
}