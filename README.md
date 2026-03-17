# Lab_6
สุปรีญา รัตนมูล 683450195-5

classDiagram

class Person{
    <<abstrct>>
    +Name
    +Display()
}
class Student{
    +StudentID
    +Score
    +GetGrade()
}
class Course{
    +courseID
    +CourseName
    +AddStudent()
    +ShowStudent()
    +ShowMaxMin()
    +ShowAverage()
}
Person <|-- Student
Course "1" --> "+" Student
