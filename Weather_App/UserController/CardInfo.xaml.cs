﻿using System;
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

namespace Weather_App.UserController
{
    /// <summary>
    /// Interaction logic for CardInfo.xaml
    /// </summary>
    public partial class CardInfo : UserControl
    {
        public CardInfo()
        {
            InitializeComponent();
        }
        public string Day
        {
            get 
            { 
                return (string)GetValue(DayProperty); 
            }
            set 
            { 
                SetValue(DayProperty, value); 
            }
        }
        public static readonly DependencyProperty DayProperty = DependencyProperty.Register("Day", typeof(string), typeof(CardInfo));
        public string InfoWeather
        {
            get
            {
                return (string)GetValue(InfoWeatherProperty);
            }
            set
            {
                SetValue(InfoWeatherProperty, value);
            }
        }
        public static readonly DependencyProperty InfoWeatherProperty = DependencyProperty.Register("InfoWeather", typeof(string), typeof(CardInfo));


        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(CardInfo));


        public string MaxNum
        {
            get 
            { 
                return (string)GetValue(MaxNumProperty); 
            }
            set 
            { 
                SetValue(MaxNumProperty, value); 
            }
        }

        public static readonly DependencyProperty MaxNumProperty = DependencyProperty.Register("MaxNum", typeof(string), typeof(CardInfo));


        public string MinNum
        {
            get { 
                return (string)GetValue(MinNumProperty);
            }
            set 
            { 
                SetValue(MinNumProperty, value); 
            }
        }

        public static readonly DependencyProperty MinNumProperty = DependencyProperty.Register("MinNum", typeof(string), typeof(CardInfo));

    }
}
