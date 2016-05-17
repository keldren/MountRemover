using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using System.Text.RegularExpressions;
using System.IO;

namespace TemplateScrubber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        StringCollection fileNames = new StringCollection();
        string mountRemovalPattern = @"<spell id=""(\d*)""";
        public MainWindow()
        {
            InitializeComponent();
        }

        // Let's load the files we want to scrub.  Multi select so we can grab them all at once if we want.
        private void btnLoadTemplates_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog loadTemplateFileDialog = new OpenFileDialog();
            loadTemplateFileDialog.Filter = "Character Template XML|*.xml";
            loadTemplateFileDialog.Title = "Select Templates to Scrub";
            loadTemplateFileDialog.Multiselect = true;
            Nullable<bool> result = loadTemplateFileDialog.ShowDialog();
            // Did we pick something?
            if (result == true)
            {
                // It's not blank, right?
                if (loadTemplateFileDialog.FileNames[0] != "")
                { 
                    foreach (String file in loadTemplateFileDialog.FileNames)
                    {
                        // Well, I guess I better do something with them...
                        fileNames.Add(file);
                    }
                }

                lbLoadedTemplates.ItemsSource = fileNames;
            }
            
            
        }

        private void btnScrubTemplate_Click(object sender, RoutedEventArgs e)
        {
            Regex mountFinder = new Regex(mountRemovalPattern);
            string input = "";
            foreach (string file in fileNames)
            {

                StreamReader fileReader = new StreamReader(file);
                while (input != null)
                {
                    input = fileReader.ReadLine();

                    if (input != null)
                    {
                        if(!mountFinder.IsMatch(input))
                        {

                        }
                    }
                }
            }
        }
    }
}
