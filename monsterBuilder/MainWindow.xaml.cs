
using System.Collections.Generic;
using System.Windows;


namespace monsterBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Action> actions = new List<Action>();
            dgActions.ItemsSource = actions;

            
        }
    }

    public class Action
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public string Type { get; set; }
    }
}
