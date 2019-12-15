package ids323.estudiantes.gui.modulos.edicion;

import ids323.estudiantes.Main;
import ids323.estudiantes.data.Asignatura;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.modulos.edicion.logica.ValorEdicion;

public class ModuloEdicionAsignatura extends ModuloEdicion {

    private Asignatura asignatura;

    public ModuloEdicionAsignatura(Tab tab, Asignatura asignatura) {
        super(tab, "Editando asignatura " + asignatura.getCodigo());
        this.asignatura = asignatura;

        valores.add(new ValorEdicion<>("Nombre", asignatura.getNombre(), (v) -> v.length() > 0 ? null : "Este campo es requerido", asignatura::setNombre));
        valores.add(new ValorEdicion<>("Código", asignatura.getCodigo(), (v) -> v.length() > 0 ? null : "Este campo es requerido", asignatura::setCodigo));
        valores.add(new ValorEdicion<>("Área Académica", asignatura.getArea(), (v) -> null, asignatura::setArea));
        valores.add(new ValorEdicion<>("Créditos", asignatura.getCreditos(), (v) -> v >= 0 ? null : "No se admiten créditos negativos", asignatura::setCreditos));
        valores.add(new ValorEdicion<>("Profesor", asignatura.getProfesor(), (v) -> v != null ? null : "Este campo es requerido", asignatura::setProfesor, Main.registro.profesores));

        construir();
    }

    @Override
    protected void endEditing() {
        asignatura.setEditando(false);
        TabManager.openTab(asignatura);
    }
}
