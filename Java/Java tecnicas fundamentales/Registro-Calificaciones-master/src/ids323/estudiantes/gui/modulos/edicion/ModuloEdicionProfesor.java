package ids323.estudiantes.gui.modulos.edicion;

import ids323.estudiantes.data.Profesor;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.modulos.edicion.logica.ValorEdicion;

public class ModuloEdicionProfesor extends ModuloEdicion {

    private Profesor profesor;

    public ModuloEdicionProfesor(Tab tab, Profesor profesor) {
        super(tab, "Editando Profesor " + profesor.getId());
        this.profesor = profesor;

        valores.add(new ValorEdicion<>("Nombre", profesor.getNombre(), (v) -> v.length() > 0 ? null : "Este campo es requerido", (v) -> profesor.setNombre(v)));
        valores.add(new ValorEdicion<>("Apellido", profesor.getApellido(), (v) -> v.length() > 0 ? null : "Este campo es requerido", (v) -> profesor.setApellido(v)));

        construir();
    }

    @Override
    protected void endEditing() {
        profesor.setEditando(false);
        TabManager.openTab(profesor);
    }
}
