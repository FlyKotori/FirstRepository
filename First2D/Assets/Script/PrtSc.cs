using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrtSc : MonoBehaviour
{
    // 捕获帧作为截屏序列。图像
    // 作为 PNG 文件存储在文件夹中 - 这些文件可通过
    //图像实用程序软件（例如，QuickTime Pro）组合成电影。
    //该文件夹将包含我们的截屏。
    //如果该文件夹存在，我们将附加数字来创建一个空文件夹。
    string folder = "ScreenshotFolder";
    int frameRate = 25;

    void Start() {
        //// 设置回放帧率（实时时间将与此后的游戏时间不相关）。
        //Time.captureFramerate = frameRate;

        ////创建文件夹
        //System.IO.Directory.CreateDirectory(folder);
    }

    void Update() {
        //// 将文件名附加到文件夹名（格式为"0005 shot.png""）
        //string name = string.Format("{0}/{1:D04} shot.png", folder, Time.frameCount);

        //// 将截屏捕获到指定的文件。
        //ScreenCapture.CaptureScreenshot(name);
    }
}