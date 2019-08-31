using FictionScrawl._0_Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._2_BLL
{
    public class Cls_Oprt_Bookshelf
    {
        /// <summary>
        /// 文件保存目录
        /// </summary>
        static string Path_Bookshelf = Environment.CurrentDirectory + "\\Bookshelf.json";
        /// <summary>
        /// 写入配置文件
        /// </summary>
        /// <param name="_vc"></param>
        /// <returns>true：写入成功 false：写入失败</returns>
        public static bool Write_Bookshelf_Config(tb_json_bookshelf _tjb)
        {
            try
            {
                
                //序列化
                string str_json = "";
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(tb_json_bookshelf));
                using (MemoryStream msObj = new MemoryStream())
                {
                    //将序列化之后的Json格式数据写入流中
                    js.WriteObject(msObj, _tjb);
                    msObj.Position = 0;
                    //从0这个位置开始读取流中的数据
                    using (StreamReader sr = new StreamReader(msObj, Encoding.UTF8))
                    {
                        str_json = sr.ReadToEnd();
                    }
                }
                //写入文件流
                using (StreamWriter sw = new StreamWriter(Path_Bookshelf))
                {
                    sw.WriteLine(str_json);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <returns>配置文件实体</returns>
        public static tb_json_bookshelf Read_Bookshelf_Config()
        {
            try
            {
                //如果不存在文件 则返回空
                if (!File.Exists(Path_Bookshelf))
                {
                    return null;
                }
                //反序列化
                string toDes = "";
                tb_json_bookshelf model;
                using (StreamReader sr = new StreamReader(Path_Bookshelf, Encoding.UTF8))
                {
                    toDes = sr.ReadToEnd();
                }
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(toDes)))
                {
                    DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(tb_json_bookshelf));
                    model = (tb_json_bookshelf)deseralizer.ReadObject(ms);// //反序列化ReadObject
                }
                return model;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 写入小说信息文件
        /// </summary>
        /// <param name="_path">存放路径</param>
        /// <param name="_tfdi">信息</param>
        /// <returns>true：写入成功 false：写入失败</returns>
        public static bool Write_Bookshelf_Info(tb_fiction_detail_info _tfdi,string _path)
        {
            try
            {

                //序列化
                string str_json = "";
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(tb_fiction_detail_info));
                using (MemoryStream msObj = new MemoryStream())
                {
                    //将序列化之后的Json格式数据写入流中
                    js.WriteObject(msObj, _tfdi);
                    msObj.Position = 0;
                    //从0这个位置开始读取流中的数据
                    using (StreamReader sr = new StreamReader(msObj, Encoding.UTF8))
                    {
                        str_json = sr.ReadToEnd();
                    }
                }
                //写入文件流
                using (StreamWriter sw = new StreamWriter(_path))
                {
                    sw.WriteLine(str_json);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 读取小说信息文件
        /// </summary>
        /// <returns>小说信息文件</returns>
        public static tb_fiction_detail_info Read_Bookshelf_Info(string _path)
        {
            try
            {
                //如果不存在文件 则返回空
                if (!File.Exists(_path))
                {
                    return null;
                }
                //反序列化
                string toDes = "";
                tb_fiction_detail_info model;
                using (StreamReader sr = new StreamReader(_path, Encoding.UTF8))
                {
                    toDes = sr.ReadToEnd();
                }
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(toDes)))
                {
                    DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(tb_fiction_detail_info));
                    model = (tb_fiction_detail_info)deseralizer.ReadObject(ms);// //反序列化ReadObject
                }
                return model;
            }
            catch
            {
                return null;
            }
        }

    }
}
