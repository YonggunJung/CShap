using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace 파일쓰기
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File(*.txt)|*.txt|XML File(*.xml)|*xml|JSON File (*.json)|*.json";
            if(saveFileDialog.ShowDialog() == true)
            {
                using(StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    TextRange textRange = new TextRange(richTxt.Document.ContentStart, richTxt.Document.ContentEnd);
                    sw.WriteLine(textRange.Text);
                }
            }
            MessageBox.Show("파일 저장");
        }
    }
}
