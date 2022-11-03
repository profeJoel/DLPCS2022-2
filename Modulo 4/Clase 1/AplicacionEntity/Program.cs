// See https://aka.ms/new-console-template for more information
using AplicacionEntity.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Nos conectamos a la Base de datos");

using (var context = new BlogContext())
{
    // Parte de Lectura del CRUD
    foreach (var post in context.Posts.ToList())
    {
        Console.WriteLine(post.Titulo);
    }

    //var p = context.Posts.Find(3);
    var p = context.Posts.Where(x => x.Titulo == "Post 4").FirstOrDefault();
    Console.WriteLine("Post encontrado:");
    Console.WriteLine(p.Descripcion);

    // Parte de Inserción creación en el CRUD
    var nuevo = new Post();
    nuevo.Titulo = "Post adicional";
    nuevo.Descripcion = "Este post se agrega desde código";
    context.Posts.Add(nuevo);
    context.SaveChanges();

    // Parte de Modificación en la Base de datos
    var porModificar = context.Posts.Find(2);
    porModificar.Titulo = "Post Modificado";
    porModificar.Descripcion = "Se modifica desde el programa";
    context.Entry(porModificar).State = EntityState.Modified;
    context.SaveChanges();

    // Parte de Eliminación de CRUD
    /*var porEliminar = context.Posts.Find(5);
    context.Remove(porEliminar);
    context.SaveChanges();

    foreach (var post in context.Posts.ToList())
    {
        Console.WriteLine(post.Titulo);
    }*/
}