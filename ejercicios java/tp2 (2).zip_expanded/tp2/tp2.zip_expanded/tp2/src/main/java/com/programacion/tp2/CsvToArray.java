package com.programacion.tp2;

import java.io.FileReader;
import java.io.IOException;
import java.util.List;

import com.opencsv.CSVParser;
import com.opencsv.CSVParserBuilder;
import com.opencsv.CSVReader;
import com.opencsv.CSVReaderBuilder;

public class CsvToArray {

	List<String[]> datos;

	public void leerCsv() throws Exception {
		try {

			String archivo = "film.csv";
			FileReader fileReader = new FileReader(archivo);

			CSVReader csvReader = new CSVReader(fileReader);
			List<String[]> datos = csvReader.readAll();
			
			for (String[] fila : datos){
				System.out.println(fila[0] + " | " + fila[1] + " |  " + fila[2]+ " |  " + fila[3]);
			}csvReader.close();


		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public int totalPeliculasPremiadas() { // Columna 8 >> Awards
		int total = 0;

		//AGREGAR LOGICA

		return total;
	}

	public void listaConFiltro(String subject, String year) { // Columna 0 >> Year -- Columns 3 >> Subject

		//AGREGAR LOGICA
		
	}

	public List<String[]> getDatos() {
		return datos;
	}
}
