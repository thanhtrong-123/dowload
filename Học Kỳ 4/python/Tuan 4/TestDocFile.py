# -*- coding: utf-8 -*-
"""
Created on Fri Mar 24 16:12:09 2023

@author: trong
"""

from XuLyFile import *
dssp = DocFile("database.txt")
def XuatSanPham(dssp):
    for row in dssp:
        for element in row:
            print(element, end='\t')
        print()
    print()
XuatSanPham(dssp)
def SortSP(dssp):
    for i in range(len(dssp)):
        for j in range(len(dssp)):
            a=dssp[i]
            b=dssp[j]
            if a[2]>b[2]:
                dssp[i] = b
                dssp[j] = a
SortSP(dssp)
print("San pham sau khi sap xep gia:")
XuatSanPham(dssp)