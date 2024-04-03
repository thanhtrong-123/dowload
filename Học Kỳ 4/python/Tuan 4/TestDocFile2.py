# -*- coding: utf-8 -*-
"""
Created on Fri Mar 24 16:31:50 2023

@author: trong
"""

from XuLyFile2 import *
arrSo = DocFile("csdl_so.txt")
print(arrSo)
def XuatSoAmTrenMoiDong(arrSo):
    for row in arrSo:
        for element in row:
            number=int(element)
            if number<0:
                print(number,end='\t')
        print()
print("Cac so am tren moi dong: ")
XuatSoAmTrenMoiDong(arrSo)