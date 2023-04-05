using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace TVSGM.Classes
{
    class clsImage
    {
        public Image GetImageFromByteArray(string sByteImage)
        {
            try
            {
                if (sByteImage.Trim() == "") return null;
                byte[] picData = Convert.FromBase64String(sByteImage);
                int bmData = (picData[0] == 0x15 && picData[1] == 0x1c) ? 78 : 0;
                Image img = null;
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(picData, bmData, picData.Length - bmData);
                    img = Image.FromStream(ms);
                }
                catch { }
                return img;
            }
            catch { return null; }
        }

        public string UpLoad_StringImage(string strFile)
        {
            byte[] bImageFile;
            string strImageFile = "";
            bImageFile = File.ReadAllBytes(strFile);
            strImageFile = Convert.ToBase64String(bImageFile);
            return strImageFile;
        }
    }
}
