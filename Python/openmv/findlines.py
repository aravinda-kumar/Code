####################################################################
#程序说明：山西古交屯兰选煤厂皮带机监控系统跑偏项目——图像处理与辨识
#程序描述：对像素点的灰度值进行计算，设定一定的阈值。
#开发测试所用操作系统： xubuntu x64, windows 10 x64
#开发测试所用IDE版本：OpenMV IDE 3.2.0
#开发测试所用语言：Python
#2018年01月 Created by @文武之道
#2018年02月 Revised by @文武之道
#2018年12月 Revised by @JZS
#####################################################################
import sensor, image, time,pyb
from pyb import UART

led1 = pyb.LED(1) # Red LED = 1, Green LED = 2, Blue LED = 3, IR LEDs = 4.
led2 = pyb.LED(2)
sensor.reset()
#颜色格式，每个像素占两个字节，高五位是红色，中间六位是绿色，低五位是蓝色
sensor.set_pixformat(sensor.RGB565)
#图像分辨率320*240
sensor.set_framesize(sensor.QVGA)
sensor.skip_frames(time = 2000)
#波特率460800
uart = UART(3, 460800)
#对图像进行矫正
enable_lens_corr = True

#阈值1：两个像素点的颜色差值，根据现场环境更改
#阈值2：第一级跑偏值。
#阈值3：第二季跑偏值。
DIFFERENT_VALYE = 50
DEVIATION_LEVEL_1 = 100
DEVIATION_LEVEL_2 = 260


while(True):
    #获取灰度图像
    time1 = time.ticks()
    imgtmp = sensor.snapshot()
    imgtmp = imgtmp.to_grayscale()

    #定义用来存储像素索引的列表
    pos = []
    #对整个图像进行遍历，将每一行的两个像素值差高于设定阈值的存入列表
    for row in range(0, imgtmp.height()):
        for col in range(0, imgtmp.width()-1):
            pixel_D_value = imgtmp.get_pixel(col,row)-imgtmp.get_pixel(col+1,row)
            if abs(pixel_D_value) > DIFFERENT_VALYE:
                pos.append(col)
                break
    #print("stop a run")

    #开始计算皮带边缘的估计位置
    pos_sum = 0;
    len_of_pos = len(pos)
    #判断pos列表长度是否为0
    #求取位置索引平均值，并在图像中绘制估计直线（调试使用）
    if len_of_pos != 0:
        for index in range(0, len(pos)):
            pos_sum = pos_sum + pos[index]
        aver_pos = int(pos_sum/len(pos))
        imgtmp.draw_line(aver_pos,0, aver_pos, imgtmp.height(), color=(0,0,0), thickness=2)
        #print("pos:",aver_pos)

        #跑偏位置高于阈值2，但是小于阈值3，一级跑偏，传递图像
        if DEVIATION_LEVEL_2>=aver_pos > DEVIATION_LEVEL_1:
            uart.write("0000")
            uart.write("1111")
            print(time.ticks()-time1)
            img = sensor.snapshot()
            uart.write(str(img.size()))
            print(str(img.size()))
            time.sleep(1000)
            uart.write(img)
            time.sleep(2000)
            #led1.on()
            #time.sleep(500)
            #led1.off()
            #time.sleep(500)
            #led1.on()
            #time.sleep(500)
            #led1.off()
            #time.sleep(500)
            #led1.on()
            #time.sleep(500)
            #led1.off()
        #跑偏位置高于阈值3，二级跑偏，传递图像
        if aver_pos > DEVIATION_LEVEL_2:
            uart.write("0000")
            uart.write("2222")
            img = sensor.snapshot()
            uart.write(str(img.size()))
            print(str(img.size()))
            time.sleep(1000)
            uart.write(img)
            time.sleep(2000)
            #led2.on()
            #time.sleep(500)
            #led2.off()
            #time.sleep(500)
            #led2.on()
            #time.sleep(500)
            #led2.off()
            #time.sleep(500)
            #led2.on()
            #time.sleep(500)
            #led2.off()
        #便于下次计算，清零累加值
        pos_sum = 0
    #清空列表
    pos.clear()
