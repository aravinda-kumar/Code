####################################################################
#程序说明：山西古交屯兰选煤厂皮带机监控系统裂缝项目——图像处理与辨识
#程序描述：边缘检测和识别处理后图像中的矩形，将矩形面积显示，超出阈值红灯闪烁报警
#开发测试所用操作系统： Windows 7 64bit
#开发测试所用IDE版本：OpenMV IDE 2.6.0
#开发测试所用语言：Python
#2018年01月 Created by @文武之道
#2018年02月 Revised by @文武之道
#2018年12月 Revised by @JZS
#####################################################################
enable_lens_corr = False # turn on for straighter lines
import sensor, image, time, pyb
from pyb import UART
import json
led = pyb.LED(1) # Red LED = 1, Green LED = 2, Blue LED = 3, IR LEDs = 4.

# 设置核函数滤波，核内每个数值值域为[-128,127],核需为列表或元组、
# 卷积核
# 这个一个高通滤波器。见这里有更多的kernel
# http://www.fmwconcepts.com/imagemagick/digital_image_filtering.pdf
# kernel width = (size*2)+1, kernel height = (size*2)+1
kernel_size = 1
kernel = [-1, -1, -1,\
          -1, +8, -1,\
          -1, -1, -1]

# 像素值在100和255之间的设置为亮色
thresholds = [(100, 255)]               # 二值化的阈值

sensor.reset()                          # 初始化 sensor.
sensor.set_pixformat(sensor.GRAYSCALE)  # or sensor.RGB565
sensor.set_framesize(sensor.QQVGA)      # or sensor.QVGA (or others)
sensor.skip_frames(10)                  # 让新的设置生效
clock = time.clock()                    # 追踪FPS

# 在OV7725 sensor上, 边缘检测可以通过设置sharpness/edge寄存器来增强。
# 注意：这个会edge detection can be enhanced
if (sensor.get_id() == sensor.OV7725):
    sensor.__write_reg(0xAC, 0xDF)
    sensor.__write_reg(0x8F, 0xFF)

uart = UART(3, 115200)                  # 设置串口波特率

while(True):
    clock.tick()
    img = sensor.snapshot()
    # 利用卷积就是一个边界提取
    img.morph(kernel_size, kernel)
    # morph(size, kernel, mul=Auto, add=0)
    # morph变换，mul根据图像对比度进行调整，mul使图像每个像素乘mul；
    # add根据明暗度调整，使得每个像素值加上add值。
    # 如果不设置则不对morph变换后的图像进行处理。

    # 利用binary函数对图像进行二值化分割
    # 将边界高亮显示
    img.binary(thresholds)

    # Erode pixels with less than 2 neighbors using a 3x3 image kernel
    img.erode(1, threshold = 2)
    # 侵蚀函数erode(size, threshold=Auto)，去除边缘相邻处多余的点。threshold
    # 用来设置去除相邻点的个数，threshold数值越大，被侵蚀掉的边缘点越多，边缘旁边
    # 白色杂点少；数值越小，被侵蚀掉的边缘点越少，边缘旁边的白色杂点越多。

    for r in img.find_rects(threshold = 10000):
        img.draw_rectangle(r.rect(), color = (255, 0, 0))
        # 返回一个由矩形对象的四个角组成的四个元组(x,y)的列表。
        # 四个角通常是按照从左上角开始沿顺时针顺序返回的。
        for p in r.corners():
            img.draw_circle(p[0], p[1], 5, color = (0, 255, 0))
        # print(r)
        output_str = json.dumps(r.magnitude())
        print("r.magnitude()=", r.magnitude())
        # uart.write(output_str+'\n')
        # magnitude矩形的大小
        if r.magnitude()>50000:
            led.on()
            time.sleep(100)
            led.off()
            time.sleep(100)
            led.on()
            time.sleep(150)
            led.off()
            time.sleep(600)
            #uart.write(output_str+'\t'+'Alarm!!!'+'\n')

        if 50000>r.magnitude()>20000:
            led.on()
            time.sleep(150)
            led.off()
            time.sleep(150)
            led.on()
            time.sleep(200)
            led.off()
            time.sleep(600)
            #uart.write(output_str+'\t'+'Warning!!!'+'\n')
