using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgramGrade
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        ///กำหนดตัวแปร
        static String Display;
        static String Text_1 = "ยังไม่ได้ป้อนคะเเนน";
        static String Text_2 = "ป้อนคะเเนนเกิน";

        static double Grade_1;
        static double Grade_2;
        static double Grade_3;
        static double Grade_4;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //// เช็คค่าว่าง
            if ((txt1.Text == "" || txt1.Text == "ป้อนคะแนน") && (txt2.Text == "" || txt2.Text == "ป้อนคะแนน") && (txt3.Text == "" || txt3.Text == "ป้อนคะแนน") && (txt4.Text == "" || txt4.Text == "ป้อนคะแนน"))
            {

                txtb1.Text = "กรุณาป้อนคะเเนน";
                return;

            }
            else if (txt1.Text == "" || txt1.Text == "ป้อนคะแนน")
            {
                txtb1.Text = "ช่องที่ 1" + " " + Text_1;
                return;
            }

            else if (txt2.Text == "" || txt2.Text == "ป้อนคะแนน")
            {
                txtb1.Text = "ช่องที่ 2" + " " + Text_1;
                return;
            }
            else if (txt3.Text == "" || txt3.Text == "ป้อนคะแนน")
            {
                txtb1.Text = "ช่องที่ 3" + " " + Text_1;
                return;
            }
            else if (txt4.Text == "" || txt4.Text == "ป้อนคะแนน")
            {
                txtb1.Text = "ช่องที่ 4" + " " + Text_1;
                return;
            }

            ////แปรงค่า
            Grade_1 = Convert.ToDouble(txt1.Text);
            Grade_2 = Convert.ToDouble(txt2.Text);
            Grade_3 = Convert.ToDouble(txt3.Text);
            Grade_4 = Convert.ToDouble(txt4.Text);

            double resoul = Grade_1 + Grade_2 + Grade_3 + Grade_4;

            ///เช็คคะแนนเกิน
            if (Grade_1 > 30)
            {
                txtb1.Text = "ช่องที่ 1" + " " + Text_2;
            }
            else if (Grade_2 > 20)
            {
                txtb1.Text = "ช่องที่ 2" + " " + Text_2;
            }
            else if (Grade_3 > 30)
            {
                txtb1.Text = "ช่องที่ 3" + " " + Text_2;
            }
            else if (Grade_4 > 20)
            {
                txtb1.Text = "ช่องที่ 4" + " " + Text_2;
            }

            /// คำนวนเกรด
            else
            {
                if (resoul <= 100 && resoul >= 80)
                {
                    Display = "4";
                }
                else if (resoul <= 79 && resoul >= 75)
                {
                    Display = "3.5";
                }
                else if (resoul <= 74 && resoul >= 70)
                {
                    Display = "3";
                }
                else if (resoul <= 69 && resoul >= 65)
                {
                    Display = "2.5";
                }
                else if (resoul <= 64 && resoul >= 60)
                {
                    Display = "2";
                }
                else if (resoul <= 59 && resoul >= 55)
                {
                    Display = "1.5";
                }
                else if (resoul <= 54 && resoul >= 50)
                {
                    Display = "1";
                }
                else if (resoul <= 49 && resoul >= 0)
                {
                    Display = "0";
                }
                else
                {
                    txtb1.Text = "กรุณาป้อนคะเเนน";
                    return;
                }

                txtb1.Text = "Grade" + " " + Display;
            }



        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txtb1.Text = "";

                txt1.Focus();
        }

       
    }
}
