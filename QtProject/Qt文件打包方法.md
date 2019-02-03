[参考文档](https://blog.csdn.net/windsnow1/article/details/78004265)

# 主要过程

- 创建Release
- 将Release下的exe文件复制出来，存在目录下的某一个新建的文件夹下
- 打开Qt5.12.0 for Desktop(MinGW 7.3.0 64bit)
- 在控制台中转到复制出的exe文件所在的窗口下
- 输入命令windeployqt [StopWatch.exe] 方括号中内容根据实际情况更改
- 打开运行Enigma Virtual Box
- 选择输入文件和输出文件路径
- 在Files Option中选择文件是否压缩
- 点击Process开始打包