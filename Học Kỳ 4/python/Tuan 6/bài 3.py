# -*- coding: utf-8 -*-
"""
Created on Fri Apr  7 16:08:28 2023

@author: trong
"""

import numpy as np

data = np.random.randint(low=0, high=20, size=(3, 5))
print(data)
print("\n")

# Cau a
print("Câu a")
current_sums = data.sum(axis=1)
print("Tổng mỗi dòng:",current_sums)
column_sums = data.sum(axis=0)
print("Tổng mỗi cột:",column_sums)
print("\n")

# Cau b
print("Câu b:")
# Tìm giá trị lớn nhất và nhỏ nhất mỗi dòng
row_max = np.max(data, axis=1)
row_min = np.min(data, axis=1)
print("Giá trị lớn nhất mỗi dòng:", row_max)
print("Giá trị nhỏ nhất mỗi dòng:", row_min)

# Tìm giá trị lớn nhất và nhỏ nhất mỗi cột
col_max = np.max(data, axis=0)
col_min = np.min(data, axis=0)
print("Giá trị lớn nhất mỗi cột:", col_max)
print("Giá trị nhỏ nhất mỗi cột:", col_min)
print("\n")

# Cau c
print("Câu c:")
soChan = data[data % 2 == 0]
soLe = data[data % 2 != 0]

print("Số chẳn: ", soChan)
print("Số lẻ: ", soLe)
print("\n")

# Cau d 
print("Câu d:")
# matrix[:, ::2] chọn tất cả các dòng (:) của ma trận và các cột
#  có chỉ số chẵn (::2). Khi kết hợp với axis=0 trong hàm np.mean(),
#  trung bình cộng được tính trên các cột được chọn.
even_cols_mean = np.mean(data[:, ::2], axis=0)
print("trung bình cộng được tính trên các cột: ", even_cols_mean)
print("\n")
print("câu e:")
even_sum = 0
for i in range(0, data.shape[0], 2):
    for j in range(0, data.shape[1], 2):
        even_sum += data[i,j]

print("Tổng các phần tử có hai chỉ số đều là số chẵn: ", even_sum)

print("\n")
print("câu f:")
row_ranges = np.ptp(data, axis=1)

print("Row ranges: ", row_ranges)

