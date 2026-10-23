using System;

namespace Company.ClassLibrary1;

public class ProductoService
{
    private readonly ProductoService _context
    {
        _context = context;
    }
    public void Agregar (string nombre,  decimal precio)
    {
        Nombre = nombre,
        Precio = precio
    };

    _context.Productos.Add(producto);
    _context.SaveChanges();
}
public List<Producto>ObtenerTodos()
{
    return _context.Productos.ToList();
}

