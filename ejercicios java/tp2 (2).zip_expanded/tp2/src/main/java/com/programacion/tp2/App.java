package com.programacion.tp2;

public class App 
{
	static CsvToArray csv;
	static ListToXls xls;
	
    public static void main( String[] args ) throws Exception
    {
        System.out.println( "ALUMNO: Nombre y Apellido: Illescas Michael Jonathan" );
        System.out.println("===================================================================");
        csv=new CsvToArray();
        csv.leerCsv();
        System.out.println("Total de peliculas premiadas: "+ csv.totalPeliculasPremiadas());
       System.out.println("===================================================================");
        System.out.println("== Lista de peliculas ==");
        csv.listaConFiltro("Comedy", "1990");
        System.out.println("===================================================================");
        xls=new ListToXls();
        xls.crearExcel();
      
    }
}
