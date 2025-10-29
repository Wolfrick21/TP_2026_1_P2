using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Servicios
{
    public class AsignadorRutinas
    {
        public void AsignarRutinaAUsuario(Usuario usuario, Rutina Rutina)
        {
            usuario.RutinaAsignada = Rutina;
        }

        public void AsignarUsuarioAEntrenador(Usuario usuario, Entrenador entrenador)
        {
            entrenador.AsignarUsuario(usuario);
        }
    }
}
