# -*- coding: utf-8 -*-
"""
Created on Fri Jun  9 14:44:32 2023

@author: trong
"""



import pandas as pd

# Đọc dữ liệu từ file CSV
data = pd.read_csv('bank-full.csv', delimiter=';')

# A. Tìm hiểu về dữ liệu
# a. Liệt kê thông tin đầy đủ của các kiểu dữ liệu của các field
data.info()

# b. Kiểm tra những dữ liệu null
null_values = data.isnull().sum()
print(null_values)

# c. Kiểm tra những dữ liệu trùng, xóa dữ liệu trùng
duplicate_data = data.duplicated()
print("Số dữ liệu trùng:", duplicate_data.sum())
data = data.drop_duplicates()

# B. Thống kê dữ liệu
# a. Tạo bảng thống kê (max, min, avg, sum, median) theo tháng của các balance
balance_stats = data.groupby('month')['balance'].agg(['max', 'min', 'mean', 'sum', 'median'])
print(balance_stats)

# b. Số lượng khách hàng đăng ký tiền gửi có kỳ hạn phân theo nghề nghiệp
deposit_by_job = data[data['y'] == 'yes'].groupby('job').size()
print(deposit_by_job)

# c. Tỷ lệ khách hàng đăng ký tiền gửi có kỳ hạn phân theo nghề nghiệp
deposit_ratio_by_job = (data[data['y'] == 'yes'].groupby('job').size() / data.groupby('job').size()).fillna(0)
print(deposit_ratio_by_job)

# d. Số lượng khách hàng đăng ký tiền gửi có kỳ hạn phân theo tình trạng hôn nhân
deposit_by_marital = data[data['y'] == 'yes'].groupby('marital').size()
print(deposit_by_marital)

# e. Tỷ lệ khách hàng đăng ký tiền gửi có kỳ hạn phân theo tình trạng hôn nhân
deposit_ratio_by_marital = (data[data['y'] == 'yes'].groupby('marital').size() / data.groupby('marital').size()).fillna(0)
print(deposit_ratio_by_marital)

# f. Phân loại theo độ tuổi của khách hàng: {20, 40, 60, 80} và tính tổng tiền gửi (balance) của nhóm khách hàng này
age_groups = pd.cut(data['age'], bins=[20, 40, 60, 80])
balance_by_age_group = data[data['y'] == 'yes'].groupby(age_groups)['balance'].sum()
print(balance_by_age_group)

# g. Thống kê từng loại công việc khách hàng theo tình trạng học vấn
job_by_education = data.groupby('education')['job'].value_counts()
print(job_by_education)

# h. Thống kê tình trạng có nhà ở theo các loại công việc
housing_by_job = data.groupby('job')['housing'].value_counts()
print(housing_by_job)
