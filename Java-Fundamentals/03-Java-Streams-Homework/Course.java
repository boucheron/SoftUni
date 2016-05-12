package com.company;

import java.io.Serializable;

public class Course implements Serializable {

    private String name;
    private int studentNumber;

    public Course(String name, int studentNumber) {
        this.name = name;
        this.studentNumber = studentNumber;
    }

    public String getName(){
        return name;
    }

    public int getStudentNumber(){
        return studentNumber;
    }

    public void setName(String newName){
        name = newName;
    }

    public void setStudentNumber(int newStudentNumber){
        studentNumber = newStudentNumber;
    }

    @Override
    public String toString() {
        return "The course \"" + getName() + "\" has " + getStudentNumber() + " students!";
    }
}