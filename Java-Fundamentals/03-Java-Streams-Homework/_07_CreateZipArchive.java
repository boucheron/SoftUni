package com.company;

import java.io.*;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class _07_CreateZipArchive {

    public static void main(String[] args) {

        String zipArchive = "resources/text-files.zip";
        String[] files = new String[]{"resources/words.txt", "resources/count-chars.txt", "resources/lines.txt"};

        try (ZipOutputStream zos = new ZipOutputStream(new BufferedOutputStream(new FileOutputStream(zipArchive)))) {

            for (String file : files) {

                try (BufferedInputStream bis = new BufferedInputStream(new FileInputStream(file))) {

                    ZipEntry zipEntry = new ZipEntry(new File(file).getName());
                    zos.putNextEntry(zipEntry);

                    byte[] data = new byte[1024];
                    int dataLength = 0;

                    while ((dataLength = bis.read(data)) != -1) {
                        zos.write(data, 0, dataLength);
                    }
                }
            }
        } catch (FileNotFoundException fnf) {
            System.out.println("Can't find the file!" + fnf);
        } catch (IOException ioe) {
            System.out.println("Error creating zip file!" + ioe);
        }

    }
}