# -*- coding: utf-8 -*-
"""
Created on Fri Mar 24 16:27:36 2023

@author: trong
"""


def LuuFile(path, data):
    file=open(path,'a', encoding='utf-8')
    file.writelines(data)
    file.writelines("\n")
    file.close()
def DocFile(path):
    arrSo=[]
    file = open(path,'r', encoding='utf-8')
    for line in file:
        data = line.strip()
        arr = data.split(',')
        arrSo.append(arr)
    file.close()
    return arrSo