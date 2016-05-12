package com.company;

import java.io.*;

public class _04_CopyJPG_File {

    public static void main(String[] args) {

        try (InputStream fis = new BufferedInputStream(new FileInputStream("resources/picture.jpg"));
             FileOutputStream fos = new FileOutputStream("resources/my-copied-picture.jpg")) {

            byte[] buffer = new byte[1024];
            int bytesRead;
            while ((bytesRead = fis.read(buffer)) != -1) {
                fos.write(buffer, 0, bytesRead);
            }
        } catch (FileNotFoundException ex) {
            System.err.println("The file is missing!");
        } catch (IOException ex) {
            ex.printStackTrace();
        }
    }
}