using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace work1
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
            SetupUI();    // เรียกใช้หน้าตา UI สีชมพูฟ้า
        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }

        private void SetupUI()
        {
            // พื้นหลังฟ้าอ่อน
            this.BackColor = Color.FromArgb(230, 245, 255);

            // ตั้งค่าของ Label ให้เป็นสีฟ้าเข้มหวาน
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    c.ForeColor = Color.FromArgb(70, 80, 120);
                }

                if (c is TextBox)
                {
                    c.BackColor = Color.White;
                    c.Font = new Font("Segoe UI", 11);
                }
            }

            // ปุ่มคำนวณ — ฟ้า
            btnCalc.BackColor = Color.FromArgb(110, 193, 255);
            btnCalc.ForeColor = Color.White;
            btnCalc.FlatStyle = FlatStyle.Flat;
            btnCalc.FlatAppearance.BorderSize = 0;
            btnCalc.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // ปุ่มล้าง — ชมพู
            btnClear.BackColor = Color.FromArgb(255, 140, 207);
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // กล่องผลลัพธ์สีชมพู
            txtEval.BackColor = Color.FromArgb(255, 230, 245);
            txtBMI.BackColor = Color.FromArgb(255, 230, 245);
        }


        // ปุ่มคำนวณ BMI
        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtWeight.Text) ||
                    string.IsNullOrWhiteSpace(txtHeight.Text))
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                    return;
                }

                double weight = double.Parse(txtWeight.Text);
                double height = double.Parse(txtHeight.Text) / 100;

                if (weight <= 0 || height <= 0)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง");
                    return;
                }

                double bmi = weight / (height * height);

                txtBMI.Text = bmi.ToString("0.00");

                string result = "";

                if (bmi < 18.5) result = "น้ำหนักน้อย";
                else if (bmi < 23) result = "ปกติ";
                else if (bmi < 25) result = "น้ำหนักเกิน";
                else if (bmi < 30) result = "อ้วนระดับ 1";
                else result = "อ้วนระดับ 2";

                txtEval.Text = result;
            }
            catch
            {
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลขเท่านั้น");
            }
        }
            //ปุ่มล้าง
            private void btnClear_Click_1(object sender, EventArgs e)
            {
                txtWeight.Text = "";
                txtHeight.Text = "";
                txtBMI.Text = "";
                txtEval.Text = "";

                txtWeight.Focus();  // เอาเคอร์เซอร์กลับมาที่ช่องแรก
            }

        //ป้องกันไม่ให้พิมพ์ตัวอักษร
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

       
    }
}
