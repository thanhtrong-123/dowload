# -*- coding: utf-8 -*-
"""
Created on Fri May  5 14:05:26 2023

@author: trong
"""

import pandas as pd
df = pd.read_csv("earthquakes.csv")
dc = pd.read_csv('faang.csv')
dc['date'] = pd.to_datetime(dc['date'])
print(df)
print("cau 1: ")
# lọc ra các dòng có magType là 'md' và mag từ 4.9 trở lên
filtered_df = df[(df['magType'] == 'mb') & (df['mag'] >= 4.9 )]
print(filtered_df[['magType', 'mag']])
print("\n")

print("câu 2: ")
# Tạo các ngăn và đếm số lượng giá trị trong mỗi ngăn
mag_counts = pd.cut(df.loc[df['magType'] == 'ml', 'mag'], bins=range(0, 10), include_lowest=True).value_counts(sort=False)
# In ra số lượng giá trị trong mỗi ngăn
for mag_range, count in mag_counts.items():
    print(f"{mag_range.left}-{mag_range.right}: {count}")
print("\n")

print("câu 3:")
df_monthly = dc.groupby(['ticker', pd.Grouper(key='date', freq='M')]).agg({'open': 'mean', 'high': 'max', 'low': 'min', 'close': 'mean', 'volume': 'sum'})
print(df_monthly)
print("\n")

print("cau 4: ")
# Tạo bảng chéo giữa cột tsunami và cột magType và tính giá trị cường độ tối đa
table = pd.pivot_table(df, values='mag', index='tsunami', columns='magType', aggfunc=max)

# Hiển thị bảng chéo
print(table)