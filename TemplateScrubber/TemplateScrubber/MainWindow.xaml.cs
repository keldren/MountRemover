using Microsoft.Win32;
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

namespace TemplateScrubber
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

        // Let's load the files we want to scrub.  Multi select so we can grab them all at once if we want.
        private void btnLoadTemplates_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog loadTemplateFileDialog = new OpenFileDialog();
            string fileName = "";
            loadTemplateFileDialog.Filter = "Character Template XML|*.xml";
            loadTemplateFileDialog.Title = "Select Templates to Scrub";
            loadTemplateFileDialog.Multiselect = true;
            Nullable<bool> result = loadTemplateFileDialog.ShowDialog();
            if (result == true)
            {
                fileName = loadTemplateFileDialog.FileNames[0];
            }

            if (fileName != "")
            {
                foreach (String file in loadTemplateFileDialog.FileNames)
                {
                    // Well, I guess I better do something with them...
                }
            }
        }
    }
}
