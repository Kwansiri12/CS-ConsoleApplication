using System;                     
using System.Windows.Forms;        

namespace work1
{
    public partial class HOME : Form   // ประกาศคลาส HOME ซึ่งเป็นฟอร์มหนึ่งในโปรเจค
    {
        // สร้างตัวแปร Timer สำหรับทำเอฟเฟกต์การค่อยๆ ปรากฏ (Fade-in)
        System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();

        // สร้าง Timer อีกตัวสำหรับจับเวลาเพื่อปิดฟอร์มอัตโนมัติ
        System.Windows.Forms.Timer closeTimer = new System.Windows.Forms.Timer();

        public HOME()
        {
            InitializeComponent();   // โหลดส่วนของหน้าตา (UI) จาก Designer

            this.Opacity = 0;  // ตั้งค่าเริ่มต้นของความโปร่งใสของฟอร์มเป็น 0 = มองไม่เห็น
            this.FormBorderStyle = FormBorderStyle.None;  // ซ่อนขอบหน้าต่าง (ดูเหมือน Splash Screen)
            this.StartPosition = FormStartPosition.CenterScreen; // ให้ฟอร์มอยู่กลางจอเมื่อเปิด

            fadeTimer.Interval = 30;     // ตั้งเวลาให้ Timer ทำงานทุก 30 ms (เร็ว = ลื่น)
            fadeTimer.Tick += FadeIn;    // เมื่อ Timer ทำงาน ให้เรียกฟังก์ชัน FadeIn

            closeTimer.Interval = 2500;  // ให้ฟอร์มเปิดค้างไว้ 2.5 วินาที (2500 ms)
            closeTimer.Tick += CloseSplash; // เมื่อครบเวลา เรียก CloseSplash เพื่อปิดฟอร์ม
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            fadeTimer.Start();    // เริ่มการทำงานของ Fade-in
            closeTimer.Start();   // เริ่มจับเวลาปิดฟอร์ม
        }

        void FadeIn(object sender, EventArgs e)
        {
            // ถ้าความโปร่งใสยังไม่ถึง 1 (1 = ชัดเต็มที่)
            if (this.Opacity < 1)
                this.Opacity += 0.05; // เพิ่มความชัดทีละนิด → ทำให้เกิดเอฟเฟกต์ Fade-in
            else
                fadeTimer.Stop();  // ถ้าชัดเต็มแล้ว หยุด Timer นี้
        }

        void CloseSplash(object sender, EventArgs e)
        {
            closeTimer.Stop();  // หยุด Timer
            this.Close();       // ปิดฟอร์ม HOME → จะเปิดหน้า BMI ต่อ
        }
    }
}
