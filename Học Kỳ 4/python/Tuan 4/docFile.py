# -*- coding: utf-8 -*-
"""
Created on Fri Mar 24 13:41:41 2023

@author: trong
"""

def luuFile():
    file = open("docFile.txt", "w", encoding='utf-8')
    file.writelines("Hello!\n")
    file.writelines("world!\n")
    file.writelines("Hello, world!")

    file.close()
luuFile()
def docFile():
    file = open("docFile.txt", "r", encoding='utf-8')
    content = file.read()
    print(content)
    file.close()
docFile()        

