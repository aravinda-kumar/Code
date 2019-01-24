# 保存图片 - By: SHUNCS - 周五 12月 28 2018

import sensor, image, time
import pyb

RED_LED_PIN = 1
BLUE_LED_PIN = 3

sensor.reset()
sensor.set_pixformat(sensor.RGB565)
sensor.set_framesize(sensor.QVGA)
sensor.skip_frames(time = 2000)

pyb.LED(RED_LED_PIN).on()
sensor.skip_frames(time = 2000)

pyb.LED(RED_LED_PIN).off()
pyb.LED(BLUE_LED_PIN).on()

print("You're on camera!")
img = sensor.snapshot()


img.save("/pic/example1.jpg")

pyb.LED(BLUE_LED_PIN).off()
print("Done! Reset the camera to see the saved image.")
