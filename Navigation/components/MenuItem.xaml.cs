using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Navigation.components
{
    /// <summary>
    /// Логика взаимодействия для MenuItem.xaml
    /// </summary>
    public partial class MenuItem : UserControl
    {
        [Category("MenuItem Properties")]
        public Geometry MenuIconPathImage
        {
            get
            {
                return icon.Data;
            }
            set
            {
                icon.Data = value;
            }
        }

        [Category("MenuItem Properties")]
        public bool MenuIconPathIsFilled
        {
            get
            {
                return icon.ReadLocalValue(Shape.FillProperty) != DependencyProperty.UnsetValue ? true : false;
            }
            set
            {
                var bind = new Binding();
                bind.Source = this;
                bind.Path = new PropertyPath("Foreground");
                if (value)
                    icon.SetBinding(Shape.FillProperty, bind);
                else
                    icon.ClearValue(Shape.FillProperty);
            }
        }

        [Category("MenuItem Properties")]
        public double MenuIconPathStrokeThickness
        {
            get
            {
                return icon.StrokeThickness;
            }
            set
            {
                icon.StrokeThickness = value;
            }
        }

        [Category("MenuItem Properties")]
        public string MenuText
        {
            get
            {
                return label.Text;
            }
            set
            {
                label.Text = value;
            }
        }

        public MenuItem()
        {
            InitializeComponent();
        }
    }
}
