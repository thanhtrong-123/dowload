# -*- coding: utf-8 -*-
"""
Created on Sat Apr  8 14:52:16 2023

@author: trong
"""

import numpy as np

matrix = np.random.randint(10, size=(5, 5))

print(matrix)
diag_sum = np.trace(matrix)

# In tổng
print("Tổng đường chéo chính:", diag_sum)

# Tính tổng đường chéo phụ
flip_diag_sum = np.trace(np.fliplr(matrix))

# In tổng
print("Tổng đường chéo phụ:", flip_diag_sum)

# Tìm giá trị lớn nhất trên đường chéo chính
diag_max = np.max(np.diag(matrix))

# Tìm giá trị lớn nhất trên đường chéo phụ
flip_diag_max = np.max(np.diag(np.fliplr(matrix)))

# In kết quả
print("Giá trị lớn nhất trên đường chéo chính:", diag_max)
print("Giá trị lớn nhất trên đường chéo phụ:", flip_diag_max)

# Tìm giá trị nhỏ nhất trên đường chéo chính
diag_min = np.min(np.diag(matrix))

# Tìm giá trị nhỏ nhất trên đường chéo phụ
flip_diag_min = np.min(np.diag(np.fliplr(matrix)))

# In kết quả
print("Giá trị nhỏ nhất trên đường chéo chính:", diag_min)
print("Giá trị nhỏ nhất trên đường chéo phụ:", flip_diag_min)