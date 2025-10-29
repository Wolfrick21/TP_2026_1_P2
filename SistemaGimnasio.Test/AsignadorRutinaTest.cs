﻿using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

namespace SistemaGimnasio.Test
{
    public class AsignadorRutinaTest
    {
        [Fact]
        public void AsignarRutinaAUsuario_DebeAsignarRutinaCorrectamente()
        {
            // Arrange
            Usuario usuario = new Usuario("Juan", 15, "Fuerza");
            Rutina rutina = new Rutina("Rutina#!", 90);
            AsignadorRutinas asignador = new AsignadorRutinas();
            // Act
            asignador.AsignarRutinaAUsuario(usuario, rutina);
            // Assert
            Assert.Equal(rutina, usuario.RutinaAsignada);
        }

        [Fact]
        public void AsignarUsuarioAEntrenador_DebeIncluirUsuario()
        {
            // Arrange
            Usuario usuario = new Usuario("Juan", 15, "Fuerza");
            Entrenador entrenador = new Entrenador("Luis", "Resistencia");
            AsignadorRutinas asignador = new AsignadorRutinas();
            // Act
            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);
            // Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
