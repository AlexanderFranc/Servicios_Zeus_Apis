using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Dtos.Public;
using Core.Entidades.Public;
using Core.Interfaces.Public;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

namespace Infraestructure.Repository.Public
{
    public class MenuReposiory : GenericPublicRepository<MenuDto>, IMenuRepository
    {
        public MenuReposiory(Configuration.Zeus.Public.ZeusPublicContext context) : base(context)
        {

        }


        public async Task<ICollection<MenuDto>> menuUsername(string username,string nameaplication)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Menu, MenuDto>();
                cfg.CreateMap<MenuPerfil, MenuPerfilDto>();
                cfg.CreateMap<UsuarioPerfil, UsuarioPerfilDto2>();
                 
            });


            var mapper = new Mapper(config);

            var query = from c in _context.Menus.AsQueryable()
                        join d in _context.MenuPerfils.AsQueryable() on c.IdMenu equals d.IdMenu
                        join e in _context.UsuarioPerfils.AsQueryable() on d.IdPerfil equals e.IdPerfil
                        join f in _context.Aplicacions on d.IdAplicacion equals f.IdAplicacion
                        where e.NombreUsuario == username && f.NombreAplicacion== nameaplication && e.ActivoPerfilUsuario==true
                        select mapper.Map<MenuDto>(c);
            return await query.ToListAsync();

        }

        public async Task<ICollection<MenuDto>> menuPadreByUser(string username,string nameaplication)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Menu, MenuDto>();
                cfg.CreateMap<MenuPerfil, MenuPerfilDto>();
                cfg.CreateMap<UsuarioPerfil, UsuarioPerfilDto2>();
            });

            var idAplicacion = _context.Aplicacions.Where(x => x.NombreAplicacion == nameaplication).Select(x => x.IdAplicacion).FirstOrDefault();


            var mapper = new Mapper(config);

            var query = (from c in _context.Menus.AsQueryable()
                         join d in _context.MenuPerfils.AsQueryable() on c.IdMenu equals d.IdMenu
                         join e in _context.UsuarioPerfils.AsQueryable() on d.IdPerfil equals e.IdPerfil
                         join f in _context.Aplicacions on d.IdAplicacion equals f.IdAplicacion
                         where e.NombreUsuario == username
                               && c.IdMenuPadre == null
                               && c.ActivoMenu == true
                               && f.NombreAplicacion == nameaplication
                               && e.ActivoPerfilUsuario == true
                               && e.IdAplicacion == idAplicacion
                         orderby c.OrdenMenu ascending
                         select mapper.Map<MenuDto>(c))
                        .Distinct();


            return await query.ToListAsync();
        }

        public async Task<ICollection<MenuDto>> menuHijoByUser(int? idmenupadre,string username, string nameaplication)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Menu, MenuDto>();
                cfg.CreateMap<Autorizacion, AutorizacionDto>();
                cfg.CreateMap<UsuarioPerfil, UsuarioPerfilDto2>();
            });
            var idAplicacion = _context.Aplicacions.Where(x => x.NombreAplicacion == nameaplication).Select(x => x.IdAplicacion).FirstOrDefault();


            var mapper = new Mapper(config);

            var query = (from c in _context.Menus.AsQueryable()
                        join d in _context.MenuPerfils.AsQueryable() on c.IdMenu equals d.IdMenu
                        join e in _context.UsuarioPerfils.AsQueryable() on d.IdPerfil equals e.IdPerfil
                        join f in _context.Aplicacions on d.IdAplicacion equals f.IdAplicacion
                        where e.NombreUsuario == username && c.IdMenuPadre == idmenupadre && c.ActivoMenu == true 
                        && f.NombreAplicacion == nameaplication && e.ActivoPerfilUsuario == true && e.IdAplicacion == idAplicacion
                        orderby c.OrdenMenu ascending
                        
            select mapper.Map<MenuDto>(c))
            .Distinct();


            return await query.ToListAsync();
        }




        //public async Task<ICollection<ItemMenuDto>> findMenuItems(string username, string nameaplication)
        //{

        //    ICollection<MenuDto> lspadre=await menuPadreByUser(username,nameaplication);
        //    ICollection<ItemMenuDto> lst = new List<ItemMenuDto>();
        //    foreach (MenuDto obj in lspadre)
        //    {
        //        ItemMenuDto menu = new ItemMenuDto();
        //        ItemDto item = new ItemDto();
        //        item.label=obj.NombreMenu;
        //        item.icon=obj.IconoMenu;
        //        item.url=obj.UrlMenu;

        //        ICollection<MenuDto> lstHijo =await menuHijoByUser(obj.IdMenu, username,nameaplication);
        //        List<ItemDto> listItemHijo = new List<ItemDto>();
        //        foreach (MenuDto objHijo in lstHijo)
        //        {
        //            ItemDto itemHijo = new ItemDto();
        //            itemHijo.label=objHijo.NombreMenu;
        //            itemHijo.icon=objHijo.IconoMenu;
        //            itemHijo.routerLink=objHijo.UrlMenu;
        //            listItemHijo.Add(itemHijo);
        //        }

        //        menu.ItemDTO=item;
        //        if (lstHijo.Count > 0)
        //            menu.ItemsDTO=listItemHijo;
        //        lst.Add(menu);
        //    }
        //    return lst;
        //}
        public async Task<ICollection<ItemMenuDto>> findMenuItems(string username, string nameaplication)
        {
            ICollection<MenuDto> lspadre = await menuPadreByUser(username, nameaplication);
            ICollection<ItemMenuDto> lst = new List<ItemMenuDto>();

            HashSet<string> existingMenus = new HashSet<string>();

            foreach (MenuDto obj in lspadre)
            {
                if (existingMenus.Contains(obj.NombreMenu))
                    continue; 

                ItemMenuDto menu = new ItemMenuDto();
                ItemDto item = new ItemDto();
                item.label = obj.NombreMenu;
                item.icon = obj.IconoMenu;
                item.url = obj.UrlMenu;

                ICollection<MenuDto> lstHijo = await menuHijoByUser(obj.IdMenu, username, nameaplication);
                List<ItemDto> listItemHijo = new List<ItemDto>();

                foreach (MenuDto objHijo in lstHijo)
                {
                    ItemDto itemHijo = new ItemDto();
                    itemHijo.label = objHijo.NombreMenu;
                    itemHijo.icon = objHijo.IconoMenu;
                    itemHijo.routerLink = objHijo.UrlMenu;
                    listItemHijo.Add(itemHijo);
                }

                menu.ItemDTO = item;
                if (lstHijo.Count > 0)
                    menu.ItemsDTO = listItemHijo;

                lst.Add(menu);
                existingMenus.Add(obj.NombreMenu); 
            }

            return lst;
        }

    }
}
