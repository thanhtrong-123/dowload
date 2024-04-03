# -*- coding: utf-8 -*-
"""
Created on Fri Apr 14 14:26:37 2023

@author: trong
"""

import pandas as pd
# câu 3:
print("câu 3")
corlum_names = ["id", "name", "Age", "weight", "m006", "m0612", "m1215", "f0006", "f0612", "f1215"]
df = pd.read_csv('patient_heart_rate.csv', names= corlum_names, delimiter=',' , error_bad_lines=False)
# Hiển thị dữ liệu
print(df.head())
print("\n")


#Cau 4
print("câu 4")
df[['Firstname','Lastname']] = df['name'].str.split(expand=True)
df = df.drop('name',axis=1)
print(df)
print("\n")


#Cau 5
print("câu 5")
weight = df['weight']

for i in range(0,len(weight)):
    x=str(weight[i])
    if "los" in x[-3:]:
        x = x[:-3:]
        float_x=float(x)
        y=int(float_x/2.2)
        y=str(y)+"kgs"
        weight[i]=y
    print(df)
    df.to_csv('patient_a.csv')
    
print("\n")


#Cau 6
print("câu 6")
df.dropna(how="all",inplace = True)
print(df)
print("\n")


#Cau 7
print("câu 7")
df = df.drop_duplicates(subset=['Firstname','Lastname','Age','weight'])
print(df)
print("\n")


#Cau 8
print("câu 8")
df.Firstname.replace({r'[''\x000\x7F]+':''},regex=True,inplace=True)
df.Lastname.replace({r'[^\x00-\x7F]+':''},regex=True,inplace=True)



