# 串口通信 - By: SHUNCS - 周二 12月 11 2018
# CREATED BY: JZS 2018年12月11日10:04:11

import sensor, image, time, pyb, os
from pyb import UART


sensor.reset()
sensor.set_pixformat(sensor.RGB565)
sensor.set_framesize(sensor.QVGA)
sensor.skip_frames(time = 2000)

clock = time.clock()
led = pyb.LED(1)    # Red LED = 1, Green LED = 2, Blue LED = 3, IR LEDs = 4.
# 第一个参数3是默认值，不用改
# 第二个参数是波特率
uart = UART(3, 115200)

Path = "/123.bmp"
img = image.Image(Path, copy_to_fb=True)
uart.write(str(img.size()))
time.sleep(1000)
uart.write(img)
time.sleep(1000)

#while True:
    #img = sensor.snapshot()
    #img.save("/image.jpg", quality=100)

