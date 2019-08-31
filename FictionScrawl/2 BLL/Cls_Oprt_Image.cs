using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._2_BLL
{
    public class Cls_Oprt_Image
    {
        /// <summary>
        /// 非占用式打开图片
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>
        public static Image Load_Image(string _path)
        {
            if (!File.Exists(_path)) return null;//文件不存在  返回null
            //读取文件流
            FileStream fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
            int byteLength = (int)fileStream.Length;
            byte[] fileBytes = new byte[byteLength];
            fileStream.Read(fileBytes, 0, byteLength);

            //文件流关閉,文件解除锁定
            fileStream.Close();

            return Image.FromStream(new MemoryStream(fileBytes));
        }
    }
}
