package com.company;

import java.io.*;

public class _06_SaveCustomObjectInFile {

    public static void main(String[] args) {

        File course = new File("resources/course.save");
        Course javaFund = new Course("Java Fundamentals", 100);

        saveObjectData(course, javaFund);
        loadObjectData(course);
    }

    private static void saveObjectData(File file, Course course) {
        try (ObjectOutputStream oos = new ObjectOutputStream(new BufferedOutputStream(new FileOutputStream(file)))) {
            oos.writeObject(course);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void loadObjectData(File file) {
        try (ObjectInputStream ois = new ObjectInputStream(new BufferedInputStream(new FileInputStream(file)))) {
            System.out.println(ois.readObject());
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }

}