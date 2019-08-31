using FictionScrawl._0_Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._2_BLL
{
    /// <summary>
    /// 配置文件操作类
    /// </summary>
    public class Cls_Oprt_Config
    {
        /// <summary>
        /// 配置文件保存目录
        /// </summary>
        static string Path_Config = Environment.CurrentDirectory+"\\Config.json";

        /// <summary>
        /// 写入配置文件
        /// </summary>
        /// <param name="_vc"></param>
        /// <returns>true：写入成功 false：写入失败</returns>
        public static bool Write_Sys_Config(tb_json_config _tjs)
        {
            try
            {
                ////书架小说封皮路径设置hi
                //if (_tjs._ltfdi_BookShelf != null)
                //{
                //    foreach (tb_fiction_detail_info _tfdi in _tjs._ltfdi_BookShelf)
                //    {
                //        if (_tfdi._s_Poster == null || _tfdi._s_Poster == "")
                //        {
                //            Directory.CreateDirectory(Environment.CurrentDirectory+ "\\CachePoster\\");//创建目录
                //            _tfdi._s_Poster =Environment.CurrentDirectory
                //                + "\\CachePoster\\" + DateTime.Now.ToString("yyyyMMddhhmmss-") + _tfdi._tfi_Fiction.col_fiction_name+".jpg";
                //            _tfdi._img_Poster.Save(_tfdi._s_Poster,System.Drawing.Imaging.ImageFormat.Jpeg);
                //            _tfdi._img_Poster = null;
                //        }
                //    }
                //}
                //序列化
                string str_json = "";
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(tb_json_config));
                using (MemoryStream msObj = new MemoryStream())
                {
                    //将序列化之后的Json格式数据写入流中
                    js.WriteObject(msObj, _tjs);
                    msObj.Position = 0;
                    //从0这个位置开始读取流中的数据
                    using (StreamReader sr = new StreamReader(msObj, Encoding.UTF8))
                    {
                        str_json = sr.ReadToEnd();
                    }
                }
                //写入文件流
                using (StreamWriter sw = new StreamWriter(Path_Config))
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
        public static tb_json_config Read_Sys_Config()
        {
            try
            {
                //如果不存在配置文件 则创建配置文件
                if (!File.Exists(Path_Config))
                {
                    Extract_Json_Sys_Config();
                }
                //反序列化
                string toDes = "";
                tb_json_config model;
                using (StreamReader sr = new StreamReader(Path_Config, Encoding.UTF8))
                {
                    toDes = sr.ReadToEnd();
                }
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(toDes)))
                {
                    DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(tb_json_config));
                    model = (tb_json_config)deseralizer.ReadObject(ms);// //反序列化ReadObject
                }
                return model;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 导出配置文件
        /// </summary>
        public static void Extract_Json_Sys_Config()
        {
            BufferedStream inStream = null;
            FileStream outStream = null;
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly(); //读取嵌入式资源
                inStream = new BufferedStream(asm.GetManifestResourceStream("FictionScrawl.Resources.tb_json_config.json"));
                outStream = new FileStream(Path_Config, FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[1024];
                int length;

                while ((length = inStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outStream.Write(buffer, 0, length);
                }
                outStream.Flush();
            }
            finally
            {
                if (outStream != null)
                {
                    outStream.Close();
                }
                if (inStream != null)
                {
                    inStream.Close();
                }
            }
        }

        /// <summary>
        /// 返回数据库连接字符串
        /// </summary>
        /// <returns></returns>
        public static string Str_Con()
        {
            return ConfigurationManager.ConnectionStrings["Str_Con"].ToString();
        }

    }
}
