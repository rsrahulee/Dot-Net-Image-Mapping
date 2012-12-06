using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tryImgMap
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

        private void image1_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var mousePos = Mouse.GetPosition(image1);
            MessageBox.Show(mousePos.ToString());
        }

        private void image1_TouchMove(object sender, TouchEventArgs e)
        {
           
        }

        private void image1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                String[] arr = new String[2];
                var mousePos = Mouse.GetPosition(image1);
                arr = mousePos.ToString().Split(',');
                int x = int.Parse(arr[0].ToString());
                int y = int.Parse(arr[1].ToString());
                textBox1.Text = mousePos.ToString();
                //DRHE
                if (x >= 231 && y >= 160 && x <= 262 && y <=184)
                {
                  Mouse.OverrideCursor = Cursors.Hand;
                 
                }
                else if (x >= 265 && y >= 160 && x <= 288 && y <= 184)
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 292 && y >= 160 && x <= 316 && y <= 184)
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 321 && y >= 160 && x <= 348 && y <= 184)
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 118 && y >= 110 && x <= 150 && y <= 133)//MTRA
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 153 && y >= 114 && x <= 186 && y <= 129)//MTRA
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 128 && y >= 169 && x <= 151 && y <= 184)//MTSC
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 161 && y >= 169 && x <= 186 && y <= 184)//MTSC
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 402 && y >= 118 && x <= 414 && y <= 131)//MVSE 150G
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 419 && y >= 118 && x <= 429 && y <= 128)//MVSE 150G
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 389 && y >= 141 && x <= 415 && y <= 185)//HGCZ
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 415 && y >= 141 && x <= 444 && y <= 185)//HGCZ
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 458 && y >= 153 && x <= 488 && y <= 185)//DRGA
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 490 && y >= 154 && x <= 521 && y <= 185)//DRGA
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 543 && y >= 145 && x <= 602 && y <= 185)//DRWA
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 630 && y >= 147 && x <= 686 && y <= 185)//DRWA
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 709 && y >= 149 && x <= 765 && y <= 185)//DRWA
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 787 && y >= 142 && x <= 814 && y <= 185)//DRGA 3D
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 817 && y >= 139 && x <= 843 && y <= 185)//DRGA 3D
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }

                else if (x >= 564 && y >= 69 && x <= 578 && y <= 75)//MMUA 50
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 652 && y >= 69 && x <= 665 && y <= 75)//MMUA 50
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 731 && y >= 69 && x <= 744 && y <= 75)//MMUA 50
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 864 && y >= 70 && x <= 878 && y <= 75)//MMUA 50
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 926 && y >= 68 && x <= 939 && y <= 75)//MMUA 50
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 855 && y >= 161 && x <= 875 && y <= 185)//DRPG
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 882 && y >= 165 && x <= 901 && y <= 185)//DRPG
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 915 && y >= 163 && x <= 936 && y <= 186)//DRPG
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 943 && y >= 165 && x <= 963 && y <= 186)//DRPG
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 797 && y >= 117 && x <= 807 && y <= 129)//MVSE 100G
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 811 && y >= 117 && x <= 821 && y <= 129)//MVSE 100G
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 436 && y >= 496 && x <= 469 && y <= 520)//SORTEX
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 493 && y >= 495 && x <= 521 && y <= 522)//SORTEX
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 72 && y >= 508 && x <= 102 && y <= 521)//MTRA 100/200
                {
                    Mouse.OverrideCursor = Cursors.Hand;

                }
                else if (x >= 102 && y >= 507 && x <= 132 && y <= 521)//MTRA 100/200
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else if (x >= 246 && y >= 384 && x <= 260 && y <= 409)//MSDL
                {
                    Mouse.OverrideCursor = Cursors.Hand;
                }
                else
                {
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
               

              
                
              

            }
            catch (Exception)
            { 
            
            }
        }
    }
}
