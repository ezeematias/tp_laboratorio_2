using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Library
{
    public delegate void LogoProgress();
    public static class Logo
    {
        public static event LogoProgress Progress;
        public static ELogo logo;
        public static object panelLogo;

        public static void Animation()
        {
            /*
            Logo.Progress.Invoke();
            logo = ELogo.Degrees0;
            do
            {
                Thread.Sleep(1000);
                Logo.Progress.Invoke();
                switch (logo)
                {
                    case ELogo.Degrees0:
                        logo++;                       
                        
                        break;
                    case ELogo.Degrees30:
                        logo++;

                        break;
                    case ELogo.Degrees60:
                        logo++;

                        break;
                    case ELogo.Degrees90:
                        logo++;

                        break;
                    case ELogo.Degrees120:
                        logo++;

                        break;
                    case ELogo.Degrees150:
                        logo++;

                        break;
                    case ELogo.Degrees180:
                        logo++;

                        break;
                    case ELogo.Degrees210:
                        logo++;

                        break;
                    case ELogo.Degrees240:
                        logo++;

                        break;
                    case ELogo.Degrees270:
                        logo++;

                        break;
                    case ELogo.Degrees300:
                        logo++;

                        break;
                    case ELogo.Degrees330:
                        logo = ELogo.Degrees0;                      

                        break;
                }


            } while (true);


            //TODO: Switch para cambiar las IMG del logo para usar en los hilos.            
            
            switch (index)
            {
                case 0:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_01;
                    index++;
                    break;
                case 1:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_02;
                    index++;
                    break;
                case 2:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_03;
                    index++;
                    break;
                case 3:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_04;
                    index++;
                    break;
                case 4:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_05;
                    index++;
                    break;
                case 5:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_06;
                    index++;
                    break;
                case 6:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_07;
                    index++;
                    break;
                case 7:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_08;
                    index++;
                    break;
                case 8:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_09;
                    index++;
                    break;
                case 9:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_10;
                    index++;
                    break;
                case 10:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_11;
                    index++;
                    break;
                case 11:
                    this.pictureBox1.BackgroundImage = Properties.Resources.TP4_LOGO_Hilos_12;
                    index = 0;
                    break;
            }
            */            
        }
    }
}
