# -*- coding: utf-8 -*-
"""
Created on Fri Apr  7 14:11:07 2023

@author: trong
"""

import numpy as np
data = np.array([1,2,3,4,5,6,7,8,9,10])
print(data)

# Câu a
print("Câu a:")
print("Kiểu dữ liệu của mảng data:", data.dtype)
print("\n")

# Câu b
print("Câu b:")
print("Kích thước của mảng data:", data.shape)
print("\n")

# câu c
print("Câu c:")
x = np.array([0, np.pi/4, np.pi/2, 3*np.pi/4, np.pi])
y = np.pi/2 - x
print(y)

z = np.cos(x) - np.sin(x)
print(z)

# Câu d
chan = data[data % 2 == 0]
print("Số chẳn trong mảng:", chan)
print("\n")
le = data[data % 2 != 0]
print("Số lẻ trong mảng:", le)
print("\n")

#Hàm So Nguyen Tox
def SoNguyenTo(num):
    if num <= 1:
        return False
    for i in range(2, num):
        if num % i == 0:
            return False
    return True
for x in data:
    if(SoNguyenTo(x)):
        print(x)
print("\n")
# Câu e
print("Câu e:")
new_data = np.where(data % 2 == 0, -1, -2)
print("Thay Thế số chẳn trong mảng thành -1, Lẻ thành -2:",new_data)
print("\n")


