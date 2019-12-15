package ids323.estudiantes.gui.modulos.vista;

import ids323.estudiantes.data.Asignatura;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;

public class ModuloVistaAsignatura extends ModuloVista {

    private Asignatura asignatura;

    public ModuloVistaAsignatura(Tab tab, Asignatura asignatura) {
        super(tab, asignatura.getNombre(), asignatura.getCodigo());
        this.asignatura = asignatura;

        infoPanel.put("PROFESOR", "" + asignatura.getProfesor());
        infoPanel.put("CRÉDITOS", asignatura.getCreditos() + " crédito" + ((asignatura.getCreditos() == 1) ? "" : "s"));
        infoPanel.put("AREA ACADÉMICA", asignatura.getArea().getNombre());

        construir();
    }

    @Override
    protected void startEditing() {
        asignatura.setEditando(true);
        TabManager.closeTab(TabManager.getTabForToken(asignatura));
        TabManager.openTab(asignatura);
    }

    @Override
    public Object getValue() {
        return null;
    }

    @Override
    public boolean canSave() {
        return false;
    }

    @Override
    public Object save() {
        return null;
    }

    @Override
    public void focus() {

    }
}
