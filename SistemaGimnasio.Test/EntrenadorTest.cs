using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public class EntrenadorTest
    {
        [Fact]
        public void AsignarUsuario_DebeAgregarUsuarioALista()
        {
            // Arrange
            Entrenador entrenador = new Entrenador("Luis", "Resistencia");
            Usuario usuario = new Usuario("Ana", 20, "Resistencia");
            // Act
            entrenador.AsignarUsuario(usuario);
            // Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
