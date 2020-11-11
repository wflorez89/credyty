using Catalog.Persistence.Database;
using Credyty.CustomTypes;
using Credyty.Entidades;
using Credyty.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Credyty.Repository.Implementacion
{
    public class ClienteRepository: IClienteRepository
    {
        private readonly ApplicationDbContext _context;
        public ClienteRepository(
            ApplicationDbContext context)
            {
                _context = context;
            }


        public List<ClienteModel> GetAll()         
        {
            var collection = _context.Clientes.Select(c => new ClienteModel
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Identificacion = c.Identificacion
            }).ToList();

            return collection;
        }


        public ClienteModel Get(int id)
        {
            var collection = _context.Clientes.Where(c => c.Id == id).Select(c => new ClienteModel
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Identificacion = c.Identificacion
            }).FirstOrDefault();

            return collection;
        }


        public void Add(ClienteModel c)
        {
            var entity = new Cliente
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Identificacion = c.Identificacion
            };


            _context.Clientes.Add(entity);
            _context.SaveChanges();
        }


        public void Update(ClienteModel c)
        {

            var entity  = _context.Clientes.Find(c.Id);

            entity.Id = c.Id ;
            entity.Nombre = c.Nombre;
            entity.Apellido = c.Apellido;
            entity.Identificacion = c.Identificacion;
            _context.SaveChanges();
        }



        public void Delete(int id)
        {
            var entity = _context.Clientes.Find(id);
            _context.Remove(entity);
            _context.SaveChanges();
        }



    }
}
