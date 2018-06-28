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

namespace fitness
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        //設定相關變數
        int sex = 1;
        int str = 1;



        public MainWindow()
        {
            InitializeComponent();
            //設定性別ComboBox01的值
            ComboBox01.Items.Add("女");

            //設定類型ComboBox02的值
            ComboBox02.Items.Add("中度減脂");
            ComboBox02.Items.Add("重度減脂");



        }

        private void weight_KeyDown(object sender, KeyEventArgs e)
        {
            //限定TextBox只能輸入數字
            bool shiftKey = (Keyboard.Modifiers & ModifierKeys.Shift) != 0;//判斷shift键是否按下
            if (shiftKey == true)                  //當按下shift時
            {
                e.Handled = true;//不可輸入
            }
            else                           //當未按下shift時
            {
                if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Delete || e.Key == Key.Back || e.Key == Key.Tab || e.Key == Key.Enter))
                {
                    e.Handled = true;//不可輸入
                }
            }
        }

        private void height_KeyDown(object sender, KeyEventArgs e)
        {
            //限定TextBox只能輸入數字
            bool shiftKey = (Keyboard.Modifiers & ModifierKeys.Shift) != 0;//判斷shift键是否按下
            if (shiftKey == true)                  //當按下shift時
            {
                e.Handled = true;//不可輸入
            }
            else                           //當未按下shift時
            {
                if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Delete || e.Key == Key.Back || e.Key == Key.Tab || e.Key == Key.Enter))
                {
                    e.Handled = true;//不可輸入
                }
            }
        }

        private void age_KeyDown(object sender, KeyEventArgs e)
        {
            //限定TextBox只能輸入數字
            bool shiftKey = (Keyboard.Modifiers & ModifierKeys.Shift) != 0;//判斷shift键是否按下
            if (shiftKey == true)                  //當按下shift時
            {
                e.Handled = true;//不可輸入
            }
            else                           //當未按下shift時
            {
                if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Delete || e.Key == Key.Back || e.Key == Key.Tab || e.Key == Key.Enter))
                {
                    e.Handled = true;//不可輸入
                }
            }
        }

        public void age_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void height_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void weight_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void culButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(age.Text);
                double h = double.Parse(height.Text);
                double w = double.Parse(weight.Text);
                //男生或女生
                if (ComboBox01.SelectedIndex == 1)
                {
                    sex = 2;
                }
                else
                    sex = 1;

                //程度類型
                if (ComboBox02.SelectedIndex == 2)
                {
                    str = 3;
                }
                else if (ComboBox02.SelectedIndex == 1)
                {
                    str = 2;
                }
                else
                    str = 1;

                //計算基礎代謝率
                //性別為男
                if (sex == 1)
                {
                    switch (str)
                    {
                        case 1:
                            {
                                //營養公克數計算欄
                                cal.Text = (10 * w + 6.25 * h - 5 * a + 5 - 200).ToString("#0.");
                                pro.Text = ((double.Parse(cal.Text) * 0.4) / 4).ToString("#0.0");
                                car.Text = ((double.Parse(cal.Text) * 0.35) / 4).ToString("#0.0");
                                fat.Text = ((double.Parse(cal.Text) * 0.25) / 9).ToString("#0.0");
                                result.Text = (double.Parse(pro.Text) + double.Parse(car.Text) + double.Parse(fat.Text)).ToString();
                                //百分比呈現欄
                                propercent.Text = "40";
                                carpercent.Text = "35";
                                fatpercent.Text = "25";
                                //漸層渲染
                                LinearGradientBrush background = new LinearGradientBrush();
                                background.StartPoint = new Point(0.5, 0);
                                background.EndPoint = new Point(0.5, 1);
                                background.GradientStops.Add(
                                    new GradientStop(Colors.Yellow, 0.0));
                                background.GradientStops.Add(
                                    new GradientStop(Colors.LimeGreen, 1.0));
                                Main.Background = background;
                                break;
                            }
                        case 2:
                            {
                                //營養公克數計算欄
                                cal.Text = (10 * w + 6.25 * h - 5 * a + 5 - 350).ToString("#0.");
                                pro.Text = ((double.Parse(cal.Text) * 0.45) / 4).ToString("#0.0");
                                car.Text = ((double.Parse(cal.Text) * 0.35) / 4).ToString("#0.0");
                                fat.Text = ((double.Parse(cal.Text) * 0.2) / 9).ToString("#0.0");
                                result.Text = (double.Parse(pro.Text) + double.Parse(car.Text) + double.Parse(fat.Text)).ToString();
                                //百分比呈現欄
                                propercent.Text = "45";
                                carpercent.Text = "35";
                                fatpercent.Text = "20";
                                //漸層渲染
                                LinearGradientBrush background = new LinearGradientBrush();
                                background.StartPoint = new Point(0.5, 0);
                                background.EndPoint = new Point(0.5, 1);
                                background.GradientStops.Add(
                                    new GradientStop(Colors.Aqua, 0.0));
                                background.GradientStops.Add(
                                    new GradientStop(Colors.BlueViolet, 1.0));
                                Main.Background = background;
                                break;
                            }
                        case 3:
                            {
                                //營養公克數計算欄
                                cal.Text = (10 * w + 6.25 * h - 5 * a + 5 - 500).ToString("#0.");
                                pro.Text = ((double.Parse(cal.Text) * 0.5) / 4).ToString("#0.0");
                                car.Text = ((double.Parse(cal.Text) * 0.3) / 4).ToString("#0.0");
                                fat.Text = ((double.Parse(cal.Text) * 0.2) / 9).ToString("#0.0");
                                result.Text = (double.Parse(pro.Text) + double.Parse(car.Text) + double.Parse(fat.Text)).ToString();
                                //百分比呈現欄
                                propercent.Text = "50";
                                carpercent.Text = "30";
                                fatpercent.Text = "20";
                                //漸層渲染
                                LinearGradientBrush background = new LinearGradientBrush();
                                background.StartPoint = new Point(0.5, 0);
                                background.EndPoint = new Point(0.5, 1);
                                background.GradientStops.Add(
                                    new GradientStop(Colors.IndianRed, 0.0));
                                background.GradientStops.Add(
                                    new GradientStop(Colors.DarkRed, 1.0));
                                Main.Background = background;
                                break;
                            }
                    }
                }

                //性別為女
                if (sex == 2)
                {
                    switch (str)
                    {
                        case 1:
                            {
                                //營養公克數計算欄
                                cal.Text = (10 * w + 6.25 * h - 5 * a - 161 - 200).ToString("#0.");
                                pro.Text = ((double.Parse(cal.Text) * 0.4) / 4).ToString("#0.0");
                                car.Text = ((double.Parse(cal.Text) * 0.35) / 4).ToString("#0.0");
                                fat.Text = ((double.Parse(cal.Text) * 0.25) / 9).ToString("#0.0");
                                result.Text = (double.Parse(pro.Text) + double.Parse(car.Text) + double.Parse(fat.Text)).ToString();
                                //百分比呈現欄
                                propercent.Text = "40";
                                carpercent.Text = "35";
                                fatpercent.Text = "25";
                                //漸層渲染
                                LinearGradientBrush background = new LinearGradientBrush();
                                background.StartPoint = new Point(0.5, 0);
                                background.EndPoint = new Point(0.5, 1);
                                background.GradientStops.Add(
                                    new GradientStop(Colors.Yellow, 0.0));
                                background.GradientStops.Add(
                                    new GradientStop(Colors.LimeGreen, 1.0));
                                Main.Background = background;
                                break;
                            }
                        case 2:
                            {
                                //營養公克數計算欄
                                cal.Text = (10 * w + 6.25 * h - 5 * a - 161 - 350).ToString("#0.");
                                pro.Text = ((double.Parse(cal.Text) * 0.45) / 4).ToString("#0.0");
                                car.Text = ((double.Parse(cal.Text) * 0.35) / 4).ToString("#0.0");
                                fat.Text = ((double.Parse(cal.Text) * 0.2) / 9).ToString("#0.0");
                                result.Text = (double.Parse(pro.Text) + double.Parse(car.Text) + double.Parse(fat.Text)).ToString();
                                //百分比呈現欄
                                propercent.Text = "45";
                                carpercent.Text = "35";
                                fatpercent.Text = "20";
                                //漸層渲染
                                LinearGradientBrush background = new LinearGradientBrush();
                                background.StartPoint = new Point(0.5, 0);
                                background.EndPoint = new Point(0.5, 1);
                                background.GradientStops.Add(
                                    new GradientStop(Colors.Aqua, 0.0));
                                background.GradientStops.Add(
                                    new GradientStop(Colors.BlueViolet, 1.0));
                                Main.Background = background;
                                break;
                            }
                        case 3:
                            {
                                //營養公克數計算欄
                                cal.Text = (10 * w + 6.25 * h - 5 * a - 161 - 500).ToString("#0.");
                                pro.Text = ((double.Parse(cal.Text) * 0.5) / 4).ToString("#0.0");
                                car.Text = ((double.Parse(cal.Text) * 0.3) / 4).ToString("#0.0");
                                fat.Text = ((double.Parse(cal.Text) * 0.2) / 9).ToString("#0.0");
                                result.Text = (double.Parse(pro.Text) + double.Parse(car.Text) + double.Parse(fat.Text)).ToString();
                                //百分比呈現欄
                                propercent.Text = "50";
                                carpercent.Text = "30";
                                fatpercent.Text = "20";
                                //漸層渲染
                                LinearGradientBrush background = new LinearGradientBrush();
                                background.StartPoint = new Point(0.5, 0);
                                background.EndPoint = new Point(0.5, 1);
                                background.GradientStops.Add(
                                    new GradientStop(Colors.IndianRed, 0.0));
                                background.GradientStops.Add(
                                    new GradientStop(Colors.DarkRed, 1.0));
                                Main.Background = background;
                                break;
                            }
                    }
                }
            }
            catch
            {
                MessageBox.Show("請輸入數值!");
            }
        }
    }
}
