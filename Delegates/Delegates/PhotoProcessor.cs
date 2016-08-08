using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class PhotoProcessor
    {

        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilter();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }


    }
}
