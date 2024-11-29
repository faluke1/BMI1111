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
            // ตรวจสอบค่าข้อมูลก่อนแปลง
            //if (!int.TryParse(txtAge.Text, out int age))
            //{
              //  MessageBox.Show("กรุณากรอกอายุเป็นตัวเลข", "ข้อผิดพลาด");
               // return;
            //}
            //if (!double.TryParse(txtHeight.Text, out double height) || height <= 0)
           // {
                //MessageBox.Show("กรุณากรอกส่วนสูงที่เป็นตัวเลขและมากกว่า 0", "ข้อผิดพลาด");
              //  return;
            //}
            //if (!double.TryParse(txtWeight.Text, out double weight) || weight <= 0)
            //{
              //  MessageBox.Show("กรุณากรอกน้ำหนักที่เป็นตัวเลขและมากกว่า 0", "ข้อผิดพลาด");
               // return;
            //}
            // string name = txtName.Text;
           // int age = Convert.ToInt32(txtAge.Text);
            //double height = 0;
            // if (double.TryParse(txtHeight.Text, out height)==false)
            //{
            //     MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //     return; // ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            // }
            // double weight = 0;
            // if (double.TryParse(txtWeight.Text, out weight) == false)
            //  {
            //     MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //      return ;
            //  }
            //double height = Convert.ToDouble(txtHeight.Text);
            //double weight = Convert.ToDouble(txtWeight.Text);
            // คำนวณ BMI
            /// double bmi = BMI(height, weight);
            // lblResult.Text = bmi.ToString();
            // แสดงผล BMI
            //MessageBox.Show($"ชื่อ: {name}\nอายุ: {age} ปี\nBMI: {bmi:F2}", "ผลลัพธ์");
            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight, txtHeight)) //เรียกใช้ Method แบบคืนค่าเป็น true//false
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

            txtName.TextAlign = HorizontalAlignment.Left; // จัดชิดซ้าย
            txtAge.TextAlign = HorizontalAlignment.Right; // จัดชิดขวา
            txtHeight.TextAlign = HorizontalAlignment.Right; // จัดชิดขวา
            txtWeight.TextAlign = HorizontalAlignment.Right; // จัดชิดขวา
            txtName.Focus(); // โฟกัสที่ชื่อ
        }

        private void inputData(TextBox name, TextBox age, TextBox height, TextBox weight)
        {
            // ตรวจสอบค่าชื่อ
            name.ForeColor = name.Text.Length > 0 ? Color.Green : Color.Black;

            // ตรวจสอบค่าอายุ
            if (int.TryParse(age.Text, out int ageValue) && ageValue > 0)
            {
                age.ForeColor = Color.DarkBlue;
            }
            else
            {
                age.ForeColor = Color.Black;
            }

            // ตรวจสอบค่าความสูง
            if (double.TryParse(height.Text, out double heightValue) && heightValue > 0)
            {
                height.ForeColor = Color.Purple;
            }
            else
            {
                height.ForeColor = Color.Black;
            }

            // ตรวจสอบค่าน้ำหนัก
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
            MessageBox.Show("ยินดีต้อนรับ", "โปรแกรมทดสอบความอ้วนผอม");
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

        private double BMI(double h, double w)//คำนวณ bmi ส่งค่าเข้ามา 2 ค่าคือน้ำหนักและส่วนสูง
        {
            double bmi = w/Math.Pow(h/100, 2);
            return bmi; 
        }
        private bool CheckDouble(TextBox txtW, TextBox txtH) //ตรวจสอบข้อมูลว่าเป็น double หรือไม่
        {
            double w = 0;
            double h = 0;
            if(double.TryParse(txtW.Text, out w)==false || double.TryParse(txtW.Text,out h) == false)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }
    }
}
