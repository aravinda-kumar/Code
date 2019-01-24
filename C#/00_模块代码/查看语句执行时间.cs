//引用命名空间
using System.Diagnostics;
 
Stopwatch swatch = new Stopwatch();    //创建Stopwatch 实例
swatch.Start();    //开始计时




//code....           //需要计时的代码



swatch.Stop();     //结束计时
string time=swatch.Elapsed.ToString()  //获取执行时间。以00:00:00(时:分:秒)格式返回。