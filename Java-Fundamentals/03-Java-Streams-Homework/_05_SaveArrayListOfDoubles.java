package com.company;

import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;

public class _05_SaveArrayListOfDoubles {

    public static void main(String[] args) {

        ArrayList<Double> doublesList = new ArrayList<>(Arrays.asList(23.1, 23.4, 53.23, 3.00));
        File doublesFile = new File("resources/doubles.list");

        saveData(doublesFile, doublesList);
        loadData(doublesFile);

    }

    private static void loadData(File file) {
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

    private static void saveData(File file, ArrayList numbers) {
        try (ObjectOutputStream oos = new ObjectOutputStream(new BufferedOutputStream(new FileOutputStream(file)))) {
            oos.writeObject(numbers);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

}