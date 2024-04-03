# -*- coding: utf-8 -*-
"""
Created on Fri Apr 21 14:26:26 2023

@author: trong
"""

import pandas as pd
df = pd.read_csv("titanic_disaster.csv")
print(df)
print(df.head(10))

print("cau 3")
# Tách cột name thành 2 cột firstName và secondName
df[['secondName', 'firstName']] = df['Name'].str.split(', ', expand=True)
# Xóa cột nameName
df = df.drop('Name', axis=1)
# hiển thị cột Sex
print(df[['secondName', 'firstName']])
print("\n")

print("cau 4")
# thay thế giá trị 'male' bằng 'M' và 'female' bằng 'F'
df['Sex'] = df['Sex'].replace({'male': 'M', 'female': 'F'})
# hiển thị cột Sex
print(df['Sex'])
print("\n");

print("cau 5")
# tính giá trị trung bình tuổi toàn bộ hành khách
mean_age = df['Age'].mean()
# thay thế các giá trị thiếu trong cột Age bằng giá trị trung bình tuổi toàn bộ hành khách
df['Age'].fillna(mean_age, inplace=True)
print(df['Age'].head(20))
print("\n")
# tính giá trị trung bình tuổi theo từng nhóm hạng vé
mean_age_by_class = df.groupby('Pclass')['Age'].mean()

# thay thế các giá trị thiếu trong cột Age theo từng nhóm hạng vé bằng giá trị trung bình tuổi của nhóm đó
df['Age'] = df.groupby('Pclass')['Age'].apply(lambda x: x.fillna(x.mean()))
print(df['Age'].head(20))
print("\n")

print("cau 6")
bins = [0, 12, 18, 60, 120]
labels = ['Kid', 'Teen', 'Adult', 'Older']
df['Agegroup'] = pd.cut(df['Age'], bins=bins, labels=labels)
print(df['Agegroup'].head(10))

print("cau 7")
