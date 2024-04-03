# -*- coding: utf-8 -*-
"""
Created on Fri Apr  7 16:02:09 2023

@author: trong
"""

import numpy as np

# Tạo một mảng ngẫu nhiên với 10 phần tử
arr = np.random.randint(0, 100, 10)

# Tìm giá trị nhỏ nhất và lớn nhất của mảng
min_val = np.min(arr)
max_val = np.max(arr)

# Tìm chỉ số (index) của giá trị nhỏ nhất và lớn nhất trong mảng
argmin_val = np.argmin(arr)
argmax_val = np.argmax(arr)

# In kết quả
print("Mảng: ", arr)
print("Giá trị nhỏ nhất: ", min_val)
print("Giá trị lớn nhất: ", max_val)
print("Chỉ số của giá trị nhỏ nhất: ", argmin_val)
print("Chỉ số của giá trị lớn nhất: ", argmax_val)