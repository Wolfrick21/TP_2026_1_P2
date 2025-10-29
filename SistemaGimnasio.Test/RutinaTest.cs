using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class RutinaTest
    {
        [Fact]
        public void AgregarEjercicio_DebeAgregarLista()
        {
            // Arrange
            Rutina rutina = new Rutina("Basica", 60);
            Ejercicio ejercicio1 = new Ejercicio("Sentadillas", 15, 3, 60);
            Ejercicio ejercicio2 = new Ejercicio("Largatijas", 10, 5, 30);

            // Act
            rutina.AgregarEjercicio(ejercicio1);
            rutina.AgregarEjercicio(ejercicio2);

            // Assert
            Assert.NotEmpty(rutina.ObtenerEjercicios());
        }
    }
}
