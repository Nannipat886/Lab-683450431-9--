# Lab-683450431-9-การเขียนโปรแกรมเชิงวัตถุ
#นายนันท์นิพัทธ์ อ่วมอินทร์

#683450431-9

The system consists of three main classes:

1. Person (Abstract Class)
   - Base class for all people
   - Contains name and ID
   - Defines abstract method ShowInfo()

2. Student (Subclass of Person)
   - Stores score
   - Calculates grade from score
   - Overrides ShowInfo()

3. Course
   - Stores course name and ID
   - Maintains a list of students
   - Provides functions to add students and display statistics
