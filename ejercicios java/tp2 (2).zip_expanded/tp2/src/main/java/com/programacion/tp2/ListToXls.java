package com.programacion.tp2;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import org.apache.commons.compress.harmony.pack200.NewAttributeBands.Call;
import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.sl.usermodel.ColorStyle;
import org.apache.poi.sl.usermodel.Sheet;
import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.CellStyle;
import org.apache.poi.ss.usermodel.Font;
import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.ss.usermodel.Workbook;
import org.apache.poi.ss.usermodel.WorkbookFactory;
import org.apache.poi.xssf.usermodel.XSSFCell;
import org.apache.poi.xssf.usermodel.XSSFRow;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

import com.opencsv.CSVParser;
import com.opencsv.CSVParserBuilder;
import com.opencsv.CSVReader;
import com.opencsv.CSVReaderBuilder;
import com.opencsv.exceptions.CsvException;

public class ListToXls {
    

     public static void main (String [] args) throws IOException, CsvException {
         crearExcel();
     } 
   
     public static void crearExcel() throws IOException, CsvException {
         
         Workbook libro= new HSSFWorkbook ();
         org.apache.poi.ss.usermodel.Sheet hoja=  libro.createSheet("Lista");
         
         
         
         try {
             String archivo="film.csv";
             FileReader lector= new FileReader(archivo);
             CSVParser separador=new CSVParserBuilder().withSeparator(';').build();
             CSVReader lectornuevo=new CSVReaderBuilder(lector).withCSVParser(separador).build(); 
             
             CellStyle style = (CellStyle) libro.createCellStyle();
             Font font = libro.createFont();
             font.setBold(true);
             ((CellStyle) style).setFont(font);

             List<String[]> datos= lectornuevo.readAll();
             

             int contador=0;
             
             Row fila1= hoja.createRow(0);
             fila1.setRowStyle((CellStyle) style);
             for (String[] one : datos){
                 Row fila11= hoja.createRow(contador);
                 
                 for(int a=0;a< 10;a++) {
                 fila11.createCell(a).setCellValue(one[a]);
                 fila11.setRowStyle(style);
                
             
                 }
                 contador++;
             }
        
            
             
         } catch (IOException e) {
             e.printStackTrace();
         }
       
         try {
         FileOutputStream nombreArchivo= new FileOutputStream("CreadoPorMi.xls"); 
         libro.write(nombreArchivo);
         System.out.print("Archivo creado con exito");
         libro.close();
         }catch (IOException e){
             System.out.print("no se pudo crear");
             
         }
         
     
     
     }
     
     
}
    