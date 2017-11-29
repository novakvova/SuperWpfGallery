using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimpleGalleryWpfApp
{
    public class Photo
    {
        private string _path;
        private Uri _source;
        private BitmapFrame _image;
        public Photo(string path)
        {
            _path = path;
            _source = new Uri(path);
            _image = BitmapFrame.Create(_source);
        }

        public override string ToString()
        {
            return _source.ToString();
        }

        public string Source { get { return _path; } }
        public BitmapFrame Image { get { return _image; } set { _image = value; } }


        
    }
}
