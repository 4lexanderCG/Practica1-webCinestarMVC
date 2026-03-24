using webCinestarMVC.Models;

namespace webCinestarMVC.Controllers.dao
{
    public class daoPelicula
    {
        db.clsBD clsBD;
        public daoPelicula(IConfiguration config)
        {
            clsBD = new db.clsBD(config, "cnCinestar");
        }
        internal List<Pelicula> getVerPeliculas()
        {
            clsBD.Sentencia("sp_getPeliculas");
            return new Pelicula().getList(clsBD.getRegistros());
        }
        internal Cine getCine(int idCine)
        {
            clsBD.Sentencia("sp_getPelicula " + idPelicula);
            var registros = clsBD.getRegistro();
            if (registros != null && registros.Length > 0)
                return new Pelicula(registros);
            return new Pelicula;
        }
    }
}
