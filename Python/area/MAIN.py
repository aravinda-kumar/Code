import tkinter
import numpy as np
import cv2 as cv


if __name__ == '__main__':
    img = cv.imread("./tear1.jpg")

    gray_img = cv.cvtColor(img, cv.COLOR_BGR2GRAY)
    kernel_open = cv.getStructuringElement(cv.MORPH_RECT, (3, 3))

    open_img = cv.morphologyEx(gray_img, cv.MORPH_OPEN, kernel_open)
    cv.imshow("open", open_img)

    kernel = np.ones((5, 5), np.uint8)
    erode_img = cv.erode(open_img, kernel, iterations=1)

    canny_img = cv.Canny(open_img, 150, 300)
    cv.imshow("canny", canny_img)

    white_pixel = 0
    for row in range(0, canny_img.shape[0]):
        for col in range(0, canny_img.shape[1]):
            if canny_img[row, col] == 255:
                white_pixel = white_pixel + 1
    print("白色像素点的个数是：", white_pixel)

    white_pixel = 0

    # kernel = np.ones((3, 3), np.uint8)
    # erode_img = cv.erode(gray_img, kernel, iterations=1)
    # ret, threshold = cv.threshold(gray_img, 127, 255, cv.THRESH_BINARY_INV + cv.THRESH_OTSU)
    # print(ret)
    # cv.imshow("OTSU", threshold)

    cv.waitKey(0)

