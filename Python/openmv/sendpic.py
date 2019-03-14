# 传输图片 - By: SHUNCS - 周四 3月 14 2019

import sensor, image, time,pyb
from pyb import UART

led1 = pyb.LED(1) # Red LED = 1, Green LED = 2, Blue LED = 3, IR LEDs = 4.
led2 = pyb.LED(2)

sensor.reset()
sensor.set_pixformat(sensor.RGB565)
sensor.set_framesize(sensor.QVGA)
sensor.skip_frames(time = 2000)

#波特率460800
uart = UART(3, 460800)
#对图像进行矫正
enable_lens_corr = True

while(True):
    uart.write("0000")
    uart.write("1111")
    img = sensor.snapshot()
    uart.write(str(img.size()))
    time.sleep(1000)
    uart.write(img)
    time.sleep(2000)
