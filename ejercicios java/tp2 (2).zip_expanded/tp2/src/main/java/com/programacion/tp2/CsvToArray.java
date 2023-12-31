package com.programacion.tp2;

import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import com.opencsv.CSVParser;
import com.opencsv.CSVParserBuilder;
import com.opencsv.CSVReader;
import com.opencsv.CSVReaderBuilder;
import com.opencsv.exceptions.CsvException;

public class CsvToArray {

	List<String[]> datos=new ArrayList();

	public void leerCsv() throws Exception {

	     try {
             String archivo="film.csv";
             FileReader lector= new FileReader(archivo);
             CSVParser separador=new CSVParserBuilder().withSeparator(';').build();
             CSVReader lectornuevo=new CSVReaderBuilder(lector).withCSVParser(separador).build(); 
             
            

             List<String[]> datos= lectornuevo.readAll();
             
             for (String[] fila : datos){
                 System.out.println(fila[0] + " | "+fila[1] + " | "+fila[2] +" | "+fila[3] +" | "+fila[4] +" | "+fila[5] +" | "+fila[6] +" | "+fila[7] + " | "+fila[8] + " | "+fila[9]  );
             }
            lectornuevo.close();
            
            
             
         } catch (IOException e) {
             e.printStackTrace();
         }
     }

	public int totalPeliculasPremiadas() throws CsvException { // Columna 8 >> Awards
		int total = 0;
		
		try {
		    String archivo="film.csv";
            FileReader lector= new FileReader(archivo);
            CSVParser separador=new CSVParserBuilder().withSeparator(';').build();
            CSVReader lectornuevo=new CSVReaderBuilder(lector).withCSVParser(separador).build(); 

            CSVReader csvReader = new CSVReader(lector);
            List<String[]> datos=new ArrayList();
            datos= lectornuevo.readAll();
            
            for (String[] fila : datos){
                if (fila[8].equalsIgnoreCase("yes") ) {
                    total=total+1;
                };

            }
            csvReader.close();

            

        } catch (IOException e) {
            e.printStackTrace();
        }
		
		
	

		return total;
	}

	public void listaConFiltro(String subject, String year) throws CsvException { // Columna 0 >> Year -- Columns 3 >> Subject
	    try {
            String archivo="film.csv";
            FileReader lector= new FileReader(archivo);
            CSVParser separador=new CSVParserBuilder().withSeparator(';').build();
            CSVReader lectornuevo=new CSVReaderBuilder(lector).withCSVParser(separador).build(); 

            CSVReader csvReader = new CSVReader(lector);
            List<String[]> datos=new ArrayList();
            datos= lectornuevo.readAll();
            
            for (String[] fila : datos){
                if (fila[0].equalsIgnoreCase(year) && fila[3].equalsIgnoreCase(subject)) {
                    System.out.println(fila[0] + " | "+fila[1] + " | "+fila[2] +" | "+fila[3] +" | "+fila[4] +" | "+fila[5] +" | "+fila[6] +" | "+fila[7] + " | "+fila[8] + " | "+fila[9]  );
                }
                

            }
            csvReader.close();

            

        } catch (IOException e) {
            e.printStackTrace();
        }
	    
	    
	    
	    
           }
	
	public List<String[]> getDatos() {
		return datos;
	}
}
