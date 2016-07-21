using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Threading.Tasks;

namespace MyShop
{
    public partial class ModifyProduct : PhoneApplicationPage
    {
        public ModifyProduct()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            var ResrouceStream = Application.GetResourceStream(new Uri(@"Assets\Test.txt", UriKind.Relative));
            if (ResrouceStream != null)
            {
                Stream myFileStream = ResrouceStream.Stream;
                if (myFileStream.CanRead)
                {
                    StreamReader myStreamReader = new StreamReader(myFileStream);
                    MessageBox.Show(myStreamReader.ReadToEnd().ToString());

                }
            }

          //  var contents = this.ReadFileContentsAsync("Test.txt");

        }

        public async Task<string> ReadFileContentsAsync(string fileName)
        {
            var folder = Windows.Storage.ApplicationData.Current.LocalFolder;

            try
            {
                var file = await folder.OpenStreamForReadAsync(fileName);

                using (var streamReader = new StreamReader(file))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
           /* string productCode = this.txtProductCode.Text;
          
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"Test.txt", true))
            {

                file.WriteLine(productCode);
            }*/
           

        }

      
    }
}