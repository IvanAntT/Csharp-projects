using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Exeption
{
    public class zad4
    {
        public static void DownloadFromInternet()
        {
            WebClient download = new WebClient();
            download.DownloadFile("http://tattoospedia.com/tatuaje/Wolf%20Tattoo%20Meaning/Wolf%20Tattoo%20Meaning_13.jpg", @"../../wolf.jpg");
        }
    }
}
