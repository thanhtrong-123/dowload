# -*- coding: utf-8 -*-
"""
Created on Fri Jun  9 14:37:05 2023

@author: trong
"""

class Person:
    def __init__(self, name, address):
        self.name = name
        self.address = address

    def toString(self):
        return f"Name: {self.name}\nAddress: {self.address}"


class Student(Person):
    def __init__(self, name, address, subject1, subject2):
        super().__init__(name, address)
        self.subject1 = subject1
        self.subject2 = subject2

    def calculate_average(self):
        return (self.subject1 + self.subject2) / 2

    def evaluate(self):
        average = self.calculate_average()
        if average >= 9.0:
            return "Xuất sắc"
        elif average >= 8.0:
            return "Giỏi"
        elif average >= 7.0:
            return "Khá"
        elif average >= 5.0:
            return "Trung bình"
        else:
            return "Yếu"

    def toString(self):
        average = self.calculate_average()
        return f"{super().toString()}\nSubject 1: {self.subject1}\nSubject 2: {self.subject2}\nAverage: {average}\nEvaluation: {self.evaluate()}"


class Employee(Person):
    def __init__(self, name, address, salary_coefficient):
        super().__init__(name, address)
        self.salary_coefficient = salary_coefficient

    def calculate_salary(self):
        base_salary = 1000  # Assuming a base salary of $1000
        return self.salary_coefficient * base_salary

    def evaluate(self):
        salary = self.calculate_salary()
        if salary >= 2000:
            return "High"
        elif salary >= 1500:
            return "Medium"
        else:
            return "Low"

    def toString(self):
        salary = self.calculate_salary()
        return f"{super().toString()}\nSalary Coefficient: {self.salary_coefficient}\nSalary: {salary}\nEvaluation: {self.evaluate()}"


class Customer(Person):
    def __init__(self, name, address, company_name, bill_value):
        super().__init__(name, address)
        self.company_name = company_name
        self.bill_value = bill_value

    def evaluate(self):
        if self.bill_value >= 1000:
            return "High"
        elif self.bill_value >= 500:
            return "Medium"
        else:
            return "Low"

    def toString(self):
        return f"{super().toString()}\nCompany Name: {self.company_name}\nBill Value: {self.bill_value}\nEvaluation: {self.evaluate()}"


class Management:
    def __init__(self, n):
        self.persons = []
        self.total_count = 0
        self.n = n

    def add_person(self, person):
        if self.total_count < self.n:
            self.persons.append(person)
            self.total_count += 1
        else:
            print("Cannot add more persons. Maximum limit reached.")

    def remove_person(self, name):
        for person in self.persons:
            if person.name == name:
                self.persons.remove(person)
                self.total_count -= 1
                print(f"Removed person: {name}")
                return
        print(f"Person with name {name} not found.")

    def sort_by_name(self):
        self.persons.sort(key=lambda x: x.name)

    def display_list(self):
        if self.total_count == 0:
            print("No persons in the list.")
        else:
            for person in self.persons:
                print(person.toString())
                print("---------------")

# Test class
class Test:
    @staticmethod
    def display_menu():
        print("1. Add a person")
        print("2. Remove a person")
        print("3. Sort the list by name")
        print("4. Display the list")
        print("5. Exit")

    @staticmethod
    def main():
        management = Management(5)  # Maximum limit of 5 persons

        while True:
            Test.display_menu()
            choice = input("Enter your choice: ")

            if choice == "1":
                person_type = input("Enter the person type (student/employee/customer): ")

                if person_type == "student":
                    name = input("Enter name: ")
                    address = input("Enter address: ")
                    subject1 = float(input("Enter subject 1 score: "))
                    subject2 = float(input("Enter subject 2 score: "))
                    student = Student(name, address, subject1, subject2)
                    management.add_person(student)
                elif person_type == "employee":
                    name = input("Enter name: ")
                    address = input("Enter address: ")
                    salary_coefficient = float(input("Enter salary coefficient: "))
                    employee = Employee(name, address, salary_coefficient)
                    management.add_person(employee)
                elif person_type == "customer":
                    name = input("Enter name: ")
                    address = input("Enter address: ")
                    company_name = input("Enter company name: ")
                    bill_value = float(input("Enter bill value: "))
                    customer = Customer(name, address, company_name, bill_value)
                    management.add_person(customer)
                else:
                    print("Invalid person type.")
            elif choice == "2":
                name = input("Enter the name of the person to remove: ")
                management.remove_person(name)
            elif choice == "3":
                management.sort_by_name()
            elif choice == "4":
                management.display_list()
            elif choice == "5":
                print("Exiting program.")
                break
            else:
                print("Invalid choice. Please try again.")


# Run the program
Test.main()
