using Company.ClassLibrary1;
 using var context = new AppDbContext();
 var servicio = new ProductoService(context);

 servicio.Agregar("Mouse", 13000);
 servicio.Agregar("Teclado", 90234092);
 servicio.Agregar("Auris", 34534);

console.WriteLine("-------Lista de producto de pepito-------\n");

foreach(var p in servicio.ObtenerTodos())
{
    console.WriteLine($"{p.Id} - {p.nombre} - ${p.Precio}");
}
