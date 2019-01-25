####################################################################
#程序说明：山西古交屯兰选煤厂皮带机监控系统裂缝项目——图像处理与辨识
#程序描述：边缘检测和识别处理后图像中的矩形，将矩形面积显示，超出阈值红灯闪烁报警
#开发测试所用操作系统： Windows 7 64bit xubuntu x64
#开发测试所用IDE版本：OpenMV IDE 2.6.0
#开发测试所用语言：Python
#2018年01月 Created by @文武之道
#2018年02月 Revised by @文武之道
#2018年12月 Revised by @JZS
#####################################################################

import sensor, image, time, pyb
from pyb import UART

sensor.reset()
sensor.set_pixformat(sensor.RGB565)
sensor.set_framesize(sensor.QVGA)
sensor.skip_frames(time = 2000)

#波特率460800
uart = UART(3, 460800)
#对图像进行矫正
enable_lens_corr = True
led1 = pyb.LED(1) # Red LED = 1, Green LED = 2, Blue LED = 3, IR LEDs = 4.
led2 = pyb.LED(2)

#阈值1：两个像素点的颜色差值，根据现场环境更改
#阈值2：第一级撕裂值。
#阈值3：第二季撕裂值。
DIFFERENT_VALYE = 0
AREA_LEVEL_1 = 160
AREA_LEVEL_2 = 260


def linear_threshold(imageTmp, height, width, thresholdValue):
    for row in range(0, height):
        for col in range(0, width):
            pixel_value = imageTmp.get_pixel(col, row)
            if pixel_value > thresholdValue:
                imageTmp.set_pixel(col, row, 0)
            else:
                imageTmp.set_pixel(col, row, 255)
    return imageTmp

while(True):
    img = sensor.snapshot()
    img = img.to_grayscale()
    #for row in range(0, img.height()):
        #for col in range(0, img.width()):
            #print(img.get_pixel(col, row))
    img = linear_threshold(img, img.height(), img.width(), 155)
    #imgtmp = sensor.snapshot()

    #img=img.to_grayscale()
    #img.bilateral(3, color_sigma=0.1, space_sigma=1)
    #img.mean(2, threshold=True, offset=5, invert=True)
    #img.erode(1, threshold = 2)
    #img.find_edges(image.EDGE_CANNY)

    #col_left_tmp=0;
    #col_right_tmp=0;
    #first_Row = -1;
    #last_Row = -1
    #col_left = -1
    #col_right = -1
    #list_Distance = []
    #list_Column =[]
    #flag = 0

    #for row in range(0, img.height()):
        #count =0
        #for col in range(0, img.width()-1):
            #count = count + 1
            #pixel_D_value_1 = img.get_pixel(col,row)-img.get_pixel(col+1,row)
            #if abs(pixel_D_value_1) > DIFFERENT_VALYE:
                #col_left_tmp = col
                #for reverse in range(img.width(), col,-1):
                    #pixel_D_value_2 = img.get_pixel(col,row)-img.get_pixel(col+1,row)
                    #if abs(pixel_D_value_2) > DIFFERENT_VALYE:
                        #col_right_tmp = reverse
                        #break
                #diatance = col_right_tmp-col_left_tmp
                #if diatance>10:
                    #if first_Row == -1:
                        #first_Row = row
                        #flag = 1
                    #list_Distance.append(diatance)
                    #list_Column.append(col_left_tmp)
                    #break
        #if count == img.width()-1 and flag == 1:
            #flag ==0
            #last_Row = row
            #break
    #start_col =  min(list_Column)
    #length = max(list_Distance)
    #img.draw_rectangle(start_col, first_Row, length, last_Row-first_Row)















