LinqQueries queries = new LinqQueries();


//Toda la Coleccion
//ImprimirValores(queries.TodaLaColeccion());

//Libros  despues del 2000
//ImprimirValores(queries.LibrosDespuesDel2000());

//Libros que tienen mas de 250 pag y tienen la palabra in action
//ImprimirValores(queries.LibrosComMasde250PagConPalabrasInAction());

//Todos los libros tienen Status
//Console.WriteLine($" Todos los libros tienen status? - {queries.TodosLosLibrosTienenStatus()}");

//Si algun libro fue publicado en 2005
//Console.WriteLine($"Libros publicados en 2005? - {queries.LibrosPublicadosEn2005()}");

//Libros de Phyton
//ImprimirValores(queries.LibrosDePhyton());

//Libros de Java por nombre ascendente
//mprimirValores(queries.LibrosDeJavaPorNombreAscendente());

//Libros con mas de 450 pag descendentes
//ImprimirValores(queries.LibrosComMasde250PagConPalabrasInAction());

//3 Primeros libros de Java 
//ImprimirValores(queries.TresPrimerosLibrosJavaOrdenadosPorFecha());

//Libros con mas de 400 pag
//ImprimirValores(queries.TercerYCuartoLibroDeMas400pag());

//tres primeros libros filtrados con select
//ImprimirValores(queries.TresPrimeroLibrosDeLaColeccion());

// Cantidad de libros entre 200 y 500 pag
//Console.WriteLine($"Cantidad de libros que tienen entre 200 y 500  pag {queries.CantidadDeLibrosEntre200y500pag()}");

//Fecha de publicacion menor de los libros
//Console.WriteLine($"Fecha de publicacion menor de los libros {queries.FechaDePublicacionMenor()}");

//Numero de Pag de libro con mayor num de pag
//Console.WriteLine($"Numero de Pag de libro con mayor num de pag {queries.NumeroDePagLibroMayor()}");

//libros con menor num de pag
//var libroMenorPag = queries.LibroConMenorNumeroDePag();
//Console.WriteLine($"libros con menor num de pag {libroMenorPag.Title} - {libroMenorPag.PageCount}");

//var libroFechaReciente = queries.LibroConFechaDePublMasReciente();
//Console.WriteLine($"libros con menor num de pag {libroFechaReciente.Title} - {libroFechaReciente.PublishedDate.ToShortDateString()}");

//suma de pag de libros entre 0 y 500
//Console.WriteLine($"suma de pag de libros entre 0 y 500: {queries.SumaDeTodasLasPagEntre0y500pag()}");

//Libros publicados despues del 2015
//Console.WriteLine(queries.LibrosDespuesDel2015Concatenados());

//promedio de caracteres del titulo de los libros
//Console.WriteLine($"Promedio de caracteres del titulo de los libros: {queries.PromedioCaracteresTitulo()}");

//Libros publicados despues del 2000
//ImprimirGrupo(queries.LibrosDespuesDel2000AgrupadosPorAno())
;

//diccionario de libros agrupados por primera letra del titulo
// var diccionarioLookup = queries.DiccionarioPorLetra();
//ImprimirDiccionario(diccionarioLookup, 'A');

//libros filtrados con la clausula join 
ImprimirValores(queries.LibrosDespuesDel2005ConMasDe500Pag());

void ImprimirValores(IEnumerable<Book> listdelibros)
{
    Console.WriteLine("{0,-70} {1,7} {2,11}\n", "Titulo", "Numero de Paginas", "Fecha de Publicacion"); // Corrección de punto y coma
    foreach (var item in listdelibros)
    {
        Console.WriteLine("{0,-70} {1,7} {2,11}", item.Title, item.PageCount, item.PublishedDate); // Sin comas dentro de las llaves
    }
}



void ImprimirGrupo(IEnumerable<IGrouping<int, Book>> listdelibros)
{
    foreach (var grupo in listdelibros)

    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: {grupo.Key}");
        Console.WriteLine("{0,-60} {1,15} {2,15},");
        foreach (var item in grupo)
        {
            Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.Author, item.PublishedDate);
        }
    }
}

void ImprimirDiccionario(ILookup<char, Book> listdelibros, char letra)
{
    Console.WriteLine("{0,-60} {1,15} {2,15}");
    foreach (var item in listdelibros[letra])
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.Author, item.PublishedDate);
    }

}