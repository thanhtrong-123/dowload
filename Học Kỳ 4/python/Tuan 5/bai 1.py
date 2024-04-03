# -*- coding: utf-8 -*-
"""
Created on Fri Mar 31 13:06:08 2023

@author: trong
"""
import pandas as pd
sample_data = {'Animal': ['Tiger', 'Lion', 'Cat', 'Whale'],
               'Weight': [258.5, 320.2, 3.3, 41000],
               'Average': [16, 15, 12, 33]}
data = pd.DataFrame(sample_data)
data  = data.rename(index={0: 'data 1', 1: 'data 2', 2: 'data 3', 3: 'data 4'})
print("Câu a:")
print(data)

print("Câu b:")
max_mean_name = data['Animal'][data['Weight'].idxmax()]
min_mean_name = data['Animal'][data['Weight'].idxmin()]
print("Tên động vật có trọng lượng trung bình lớn nhất: ", max_mean_name)
print("Tên động vật có trọng lượng trung bình nhỏ nhất: ", min_mean_name)
print("\n")

print("Câu c:")
max_mean_average_name = data['Animal'][data['Average'].idxmax()]
min_mean_average_name = data['Animal'][data['Average'].idxmin()]
print("Tên động vật có trọng lượng trung bình lớn nhất: ", max_mean_average_name)
print("Tên động vật có trọng lượng trung bình nhỏ nhất: ", min_mean_average_name)
print("\n")

print("Câu d:")
data_new = data.loc[['data 1', 'data 4'],['Animal','Weight']]
print("Dòng data 1, 4 và cột Animal, Weight:")
print(data_new)
print("\n")

print("Câu e:")
print("Động vật có trọng lượng lớn nhất:", data['Weight'].max())
print("Động vật có trọng lượng  nhất: ", data['Weight'].min())
print("\n")

print("Câu f:")
print("Động vật có tuổi thọ lớn nhất:", data['Average'].max())
print("Động vật có tuổi thọ nhỏ nhất:", data['Average'].min())
print("\n")

print('Câu g:')
row_two_head = data.head(2)
row_two_tail = data.tail(2)
print("2 dòng đầu tiên: ")
print(row_two_head)
print("\n")
print("2 dòng cuối cùng: ")
print(row_two_tail)
print("\n")

print("Câu h:")
mean_average = data[data['Average'] > 15]
print(mean_average)
print("\n")


print("Câu i:")
mean_weight = data[data['Weight'] < 300]
print(mean_weight)
















