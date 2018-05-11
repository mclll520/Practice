using System.IO;
using UnityEngine;

/// <summary>
/// 使用文件流来实现多媒体文件复制
/// </summary>
public class Text03 : MonoBehaviour {

	void Start () {
        //原来路径
        string source = @"C:\Users\Administrator.PC-201709211725\Desktop\A01、复习.avi";
        //现在路径
        string target = @"C:\Users\Administrator.PC-201709211725\Desktop\A02、复习.avi";
        CopyFile(source, target);
    }
    /// <summary>
    /// 多媒体文件复制
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    public static void CopyFile(string source, string target)
    {
        //创建负责读取的流
        using (FileStream FeRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        {
            //创建一个负责写入的流
            using (FileStream FsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                //因为文件过大需要循环去读
                while (true)
                {
                    //返回本次读取到的字节数
                    int r = FeRead.Read(buffer, 0, buffer.Length);
                    //返回为0  就意味读完了
                    if (r == 0)
                    {
                        break;
                    }
                    //最后写入新的文件中
                    FsWrite.Write(buffer, 0, r);
                }
            }
        }
        print("复制成功");
    }

}
