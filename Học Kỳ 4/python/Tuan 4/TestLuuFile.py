# -*- coding: utf-8 -*-
"""
Created on Fri Mar 24 16:11:23 2023

@author: trong
"""

from XuLyFile import *
maSP = input("Nhap Ma SP: ")
tenSP = input("Nhap Ten sp: ")
donGia = float(input("Nhap Gia: "))
line = maSP+";"+tenSP+";"+str(donGia)
LuuFile("database.txt", line)