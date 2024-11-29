namespace BMI1111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            // ��Ǩ�ͺ��Ң����š�͹�ŧ
            //if (!int.TryParse(txtAge.Text, out int age))
            //{
              //  MessageBox.Show("��سҡ�͡�����繵���Ţ", "��ͼԴ��Ҵ");
               // return;
            //}
            //if (!double.TryParse(txtHeight.Text, out double height) || height <= 0)
           // {
                //MessageBox.Show("��سҡ�͡��ǹ�٧����繵���Ţ����ҡ���� 0", "��ͼԴ��Ҵ");
              //  return;
            //}
            //if (!double.TryParse(txtWeight.Text, out double weight) || weight <= 0)
            //{
              //  MessageBox.Show("��سҡ�͡���˹ѡ����繵���Ţ����ҡ���� 0", "��ͼԴ��Ҵ");
               // return;
            //}
            // string name = txtName.Text;
           // int age = Convert.ToInt32(txtAge.Text);
            //double height = 0;
            // if (double.TryParse(txtHeight.Text, out height)==false)
            //{
            //     MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //     return; // ��Ҥ��� if �繨�ԧ ��騺��÷ӧҹ
            // }
            // double weight = 0;
            // if (double.TryParse(txtWeight.Text, out weight) == false)
            //  {
            //     MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //      return ;
            //  }
            //double height = Convert.ToDouble(txtHeight.Text);
            //double weight = Convert.ToDouble(txtWeight.Text);
            // �ӹǳ BMI
            /// double bmi = BMI(height, weight);
            // lblResult.Text = bmi.ToString();
            // �ʴ��� BMI
            //MessageBox.Show($"����: {name}\n����: {age} ��\nBMI: {bmi:F2}", "���Ѿ��");
            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight, txtHeight)) //���¡�� Method Ẻ�׹����� true//false
            {
                height = Convert.ToDouble(txtWeight);
                weight = Convert.ToDouble(txtWeight);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";

            txtName.TextAlign = HorizontalAlignment.Left; // �Ѵ�Դ����
            txtAge.TextAlign = HorizontalAlignment.Right; // �Ѵ�Դ���
            txtHeight.TextAlign = HorizontalAlignment.Right; // �Ѵ�Դ���
            txtWeight.TextAlign = HorizontalAlignment.Right; // �Ѵ�Դ���
            txtName.Focus(); // ⿡�ʷ�����
        }

        private void inputData(TextBox name, TextBox age, TextBox height, TextBox weight)
        {
            // ��Ǩ�ͺ��Ҫ���
            name.ForeColor = name.Text.Length > 0 ? Color.Green : Color.Black;

            // ��Ǩ�ͺ�������
            if (int.TryParse(age.Text, out int ageValue) && ageValue > 0)
            {
                age.ForeColor = Color.DarkBlue;
            }
            else
            {
                age.ForeColor = Color.Black;
            }

            // ��Ǩ�ͺ��Ҥ����٧
            if (double.TryParse(height.Text, out double heightValue) && heightValue > 0)
            {
                height.ForeColor = Color.Purple;
            }
            else
            {
                height.ForeColor = Color.Black;
            }

            // ��Ǩ�ͺ��ҹ��˹ѡ
            if (double.TryParse(weight.Text, out double weightValue) && weightValue > 0)
            {
                weight.ForeColor = Color.Orange;
            }
            else
            {
                weight.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ�͹�Ѻ", "��������ͺ������ǹ���");
            clearForm();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            inputData(txtName, txtAge, txtHeight, txtWeight);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            inputData(txtName, txtAge, txtHeight, txtWeight);
        }

        private double BMI(double h, double w)//�ӹǳ bmi �觤������� 2 ��Ҥ�͹��˹ѡ�����ǹ�٧
        {
            double bmi = w/Math.Pow(h/100, 2);
            return bmi; 
        }
        private bool CheckDouble(TextBox txtW, TextBox txtH) //��Ǩ�ͺ����������� double �������
        {
            double w = 0;
            double h = 0;
            if(double.TryParse(txtW.Text, out w)==false || double.TryParse(txtW.Text,out h) == false)
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return false;
            }
            return true;
        }
    }
}
