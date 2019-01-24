 ####################################################################
#程序说明：山西古交屯兰选煤厂皮带机监控系统跑偏项目——图像处理与辨识
#程序描述：霍夫变换——寻找图像中的直线，对直线进行定位，坐标超出阈值报警，led红灯闪烁
#开发测试所用操作系统： Windows 7 64bit
#开发测试所用IDE版本：OpenMV IDE 2.6.0
#开发测试所用语言：Python
#2018年01月 Created by @文武之道
#2018年02月 Revised by @文武之道
#2018年12月 Revised by @JZS
#####################################################################
enable_lens_corr = False # 使图像中弯曲矫正失效

import sensor, image, time, pyb
from pyb import UART
import json
led = pyb.LED(1) # Red LED = 1, Green LED = 2, Blue LED = 3, IR LEDs = 4.
sensor.reset()                      # 相机重置
sensor.set_pixformat(sensor.RGB565) # 设置图像颜色格式
sensor.set_framesize(sensor.QVGA)   # 设置图像分辨率格式
sensor.skip_frames(time = 2000)     # 等待一段时间使得相机完成初始设置
clock = time.clock()                # 返回一个时钟对象

# 详细用法见下文链接
# http://book.openmv.cc/example/09-Feature-Detection/find-lines.html


# 所有的线对象都有一个theta()方法来获取它们的旋转角度。
# 您可以根据旋转角度来过滤线条。
# 下面两个参数设置的是绘制直线
min_degree = 0
max_degree = 179


# 串口通信设置波特率
uart = UART(3, 115200)
while(True):
    clock.tick()
    img = sensor.snapshot()
    if enable_lens_corr:
        img.lens_corr(1.8)

    # `threshold` controls how many lines in the image are found. Only lines with
    # edge difference magnitude sums greater than `threshold` are detected...

    # More about `threshold` - each pixel in the image contributes a magnitude value
    # to a line. The sum of all contributions is the magintude for that line. Then
    # when lines are merged their magnitudes are added togheter. Note that `threshold`
    # filters out lines with low magnitudes before merging. To see the magnitude of
    # un-merged lines set `theta_margin` and `rho_margin` to 0...

    # `theta_margin` and `rho_margin` control merging similar lines. If two lines
    # theta and rho value differences are less than the margins then they are merged.

    for l in img.find_lines(threshold = 1000, theta_margin = 25, rho_margin = 25):
        if (min_degree <= l.theta()) and (l.theta() <= max_degree):
            img.draw_line(l.line(), color = (255, 0, 0))
            # print(l)
        output_str = json.dumps(l.x1())
        #print("output_str=", output_str)
        print("l.x1()=", l.x1())
        # print("l.y1()=", l.y1())

    #output_str = json.dumps(l)
    #uart.write(output_str+'\n')
        if l.x1()>250:
       # output_str2=print('1级报警：708皮带已严重跑偏！！！'+'\n')
       # output_str2=('Alarm!!!'+'\n')
            led.on()
            time.sleep(100)
            led.off()
            time.sleep(100)
            led.on()
            time.sleep(150)
            led.off()
            time.sleep(600)
            #img = sensor.snapshot()
            #uart.write(img)
            uart.write(output_str+'\t'+'Alarm!!!'+'\n')
        if 700>l.x1()>500:
        #output_str3=print('2级报警：708皮带已跑偏！！！'+'\n')
        #output_str3=('Warning!!!'+'\n')
            led.on()
            time.sleep(150)
            led.off()
            time.sleep(150)
            led.on()
            time.sleep(200)
            led.off()
            time.sleep(600)
            #img = sensor.snapshot()
            #uart.write(img)
            uart.write(output_str+'\t'+'Warning!!!'+'\n')
            #uart.write('Warning!!!'+'\n')
