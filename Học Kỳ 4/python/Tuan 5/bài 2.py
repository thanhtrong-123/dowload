# -*- coding: utf-8 -*-
"""
Created on Fri Mar 31 16:37:58 2023

@author: trong
"""
import pandas as pd

a1 = "Long An"
a2 = "Ben Tre"
sample_data = {'name': ['Grapefruit', 'Coconut', 'Watermelon', 'Banana', 'Dragon fruit'],
               'Origin': [a1, a2, a1, a2, a1],
               'Price': [5.5, 10.2, 6.7, 2.5, 7.5]}
data = pd.DataFrame(sample_data)
data  = data.rename(index={0: 'data 1', 1: 'data 2', 2: 'data 3', 3: 'data 4', 4: 'data 5'})

print(data)
