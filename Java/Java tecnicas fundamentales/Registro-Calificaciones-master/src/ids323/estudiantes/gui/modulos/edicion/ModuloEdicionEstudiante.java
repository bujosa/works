package ids323.estudiantes.gui.modulos.edicion;

import ids323.estudiantes.data.Estudiante;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.modulos.edicion.logica.ValorEdicion;

import java.util.Arrays;
import java.util.Calendar;

public class ModuloEdicionEstudiante extends ModuloEdicion {

    private Estudiante estudiante;

    public ModuloEdicionEstudiante(Tab tab, Estudiante estudiante) {
        super(tab, "Editando estudiante " + estudiante.getId());
        this.estudiante = estudiante;

        String[] nacionalidades = {"Dominicano/a", "Extranjero/a"};

        valores.add(new ValorEdicion<>("Nombre", estudiante.getNombre(), (v) -> v.length() > 0 ? null : "Este campo es requerido", (v) -> estudiante.setNombre(v)));
        valores.add(new ValorEdicion<>("Apellido", estudiante.getApellido(), (v) -> v.length() > 0 ? null : "Este campo es requerido", (v) -> estudiante.setApellido(v)));
        valores.add(new ValorEdicion<>("Condición Académica", estudiante.getEstado(), (v) -> null, (v) -> estudiante.setEstado(v)));
        valores.add(new ValorEdicion<>("Carrera", estudiante.getCarrera(), (v) -> null, (v) -> estudiante.setCarrera(v)));
        valores.add(new ValorEdicion<>("Nacionalidad", estudiante.isExtranjero() ? nacionalidades[1] : nacionalidades[0], (v) -> null, (v) -> estudiante.setExtranjero(v.equals(nacionalidades[1])), Arrays.asList(nacionalidades)));
        valores.add(new ValorEdicion<>("Fecha de Nacimiento", estudiante.getFechaNacimiento(), (v) -> v.getTimeInMillis() < Calendar.getInstance().getTimeInMillis() ? null : "Fecha debe estar en el pasado", (v) -> estudiante.setFechaNacimiento(v)));

        construir();
    }

    @Override
    protected void endEditing() {
        estudiante.setEditando(false);
        TabManager.openTab(estudiante);
    }
}
