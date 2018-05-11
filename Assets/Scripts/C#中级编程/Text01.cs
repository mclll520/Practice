using System.IO;
using System.Text;
using UnityEngine;
/// <summary>
/// File 一次性控制 （小文件）
/// FileStream 文件流控制（大数据文件）
/// </summary>
public class Text01 : MonoBehaviour {

    void Start() {
        //AddWriteText();
        //ReadAllLinesText();
        //ReadAllText();
        //WriteAllLines();
        //WriteAllText();
        //AppendAllText();
        //WriteText1();
    }
    /// <summary>
    /// 全部字符串写入文本(未覆盖源文档)
    /// </summary>
    public void AppendAllText() {
        File.AppendAllText(@"C:\Users\Administrator.PC-201709211725\Desktop\王宇晨11.txt", "看我有没有把你覆盖");
        print("写入完成");
    }
    /// <summary>
    /// 全部字符串写入文本(覆盖源文档)
    /// </summary>
    public void WriteAllText()
    {
        File.WriteAllText(@"C:\Users\Administrator.PC-201709211725\Desktop\王宇晨.txt","abcabc" );
        print("写入完成");
    }

    /// <summary>
    /// 以数组字符串写入文本(覆盖源文档)
    /// </summary>
    public void WriteAllLines() {
        File.WriteAllLines(@"C:\Users\Administrator.PC-201709211725\Desktop\王宇晨.txt", new string[] { "abc", "abc" });
        print("写入完成");
    }

    /// <summary>
    /// 读取全部字符串
    /// </summary>
    public void ReadAllText()
    {
        string str = File.ReadAllText(@"C:\Users\Administrator.PC-201709211725\Desktop\王宇晨.txt", Encoding.Default);
        print(str);
    }

    /// <summary>
    /// 读取每行字符串
    /// </summary>
    public void ReadAllLinesText() {
        string[] str = File.ReadAllLines(@"C:\Users\Administrator.PC-201709211725\Desktop\王宇晨.txt", Encoding.Default);
        //以行的形式读取
        foreach (string item in str)
        {
            print(item);
        }
    }

    /// <summary>
    /// 追加 文本格式
    /// </summary>
    public void AddWriteText()
    {
        FileStream fileStream = new FileStream("C:/Users/Administrator.PC-201709211725/Desktop/王宇晨02.txt", FileMode.Append, FileAccess.Write);
        string str = "刘洁真帅！！！！！";
        byte[] buffer = Encoding.Default.GetBytes(str);
        fileStream.Write(buffer, 0, buffer.Length);
        //关闭流
        fileStream.Close();
        //释放所占资源
        fileStream.Dispose();
    }
    /// <summary>
    /// 写入 文本格式(覆盖源文档)
    /// </summary>
    public void WriteText() {
        FileStream fileStream = new FileStream("C:/Users/Administrator.PC-201709211725/Desktop/王宇晨01.txt", FileMode.OpenOrCreate, FileAccess.Write);
        string str = "刘洁真帅！！！！！";
        byte[] buffer = Encoding.UTF8.GetBytes(str);
        fileStream.Write(buffer, 0, buffer.Length);
        //关闭流
        fileStream.Close();
        //释放所占资源
        fileStream.Dispose();
    }

    /// <summary>
    /// 读取文本格式
    /// </summary>
    public void ReadText() {
        FileStream fsRead = new FileStream("C:/Users/Administrator.PC-201709211725/Desktop/王宇晨.txt", FileMode.OpenOrCreate, FileAccess.Read);
        byte[] buffer = new byte[1024 * 1024 * 5];
        //本次实际读取的字符串
        int r = fsRead.Read(buffer, 0, buffer.Length);
        //将字节流解析我们想要的字符串
        string str = Encoding.Default.GetString(buffer, 0, r);
        print(str);
        //关闭流
        fsRead.Close();
        //释放所占资源
        fsRead.Dispose();
    }
    /// <summary>
    /// 用using 封装 自动解放内存
    /// </summary>
    public void WriteText1() {
        using (FileStream fsWrite = new FileStream(@"C:\Users\Administrator.PC-201709211725\Desktop\王宇晨.txt", FileMode.OpenOrCreate, FileAccess.Write)) {
            string str = "看我有没有把你覆盖";
            byte[] buffer = Encoding.Default.GetBytes(str);
            fsWrite.Write(buffer, 0, buffer.Length);
            print("写入成功");
        }
    }
	
}
