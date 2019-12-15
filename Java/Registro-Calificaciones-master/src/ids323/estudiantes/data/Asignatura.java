package ids323.estudiantes.data;

import ids323.estudiantes.Main;
import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.Ventana;
import ids323.estudiantes.gui.explorer.ProjectExplorerItem;
import ids323.estudiantes.gui.modulos.DisplayModule;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.modulos.edicion.ModuloEdicionAsignatura;
import ids323.estudiantes.gui.modulos.vista.ModuloVistaAsignatura;
import ids323.estudiantes.util.Commons;

import javax.swing.*;
import java.awt.*;
import java.util.Collection;
import java.util.Collections;

/**
 * Representación de una asignatura como objeto.
 * */
public class Asignatura implements ModuleToken {

    public static final Image ICON = Commons.getIcon("asignatura");
    public static final Image ICON_NUEVO = Commons.getIcon("asignatura_nueva");

    private int id;
    private AreaAcademica area;
    private String codigo;
    private String nombre;
    private Profesor profesor;
    private int creditos;

    private boolean editando = false;

    public Asignatura(int id) {
        this.id = id;
    }

    public Asignatura(Registro registro, AreaAcademica area, String codigo, String nombre, Profesor profesor, int creditos) {
        this.id = registro.ID_ASIGNATURA++;
        this.area = area;
        this.codigo = codigo;
        this.nombre = nombre;
        this.profesor = profesor;
        this.creditos = creditos;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public AreaAcademica getArea() {
        return area;
    }

    public void setArea(AreaAcademica area) {
        this.area = area;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Profesor getProfesor() {
        return profesor;
    }

    public void setProfesor(Profesor profesor) {
        this.profesor = profesor;
    }

    public int getCreditos() {
        return creditos;
    }

    public void setCreditos(int creditos) {
        this.creditos = creditos;
    }

    public boolean isEditando() {
        return editando;
    }

    public void setEditando(boolean editando) {
        this.editando = editando;
    }

    @Override
    public String toString() {
        return codigo + " - " + nombre;
    }

    @Override
    public String getLabel() {
        return codigo + " - " + nombre;
    }

    @Override
    public Image getIcon() {
        return ICON;
    }

    @Override
    public String getHint() {
        return creditos + " crédito" + ((creditos == 1) ? "" : "s") + " - " + area.getNombre();
    }

    @Override
    public Collection<ModuleToken> getSubTokens() {
        return Collections.emptyList();
    }

    @Override
    public boolean isExpandable() {
        return false;
    }

    @Override
    public DisplayModule createModule(Tab tab) {
        return (editando) ? new ModuloEdicionAsignatura(tab, this) : new ModuloVistaAsignatura(tab, this);
    }

    @Override
    public void onInteract() {
        editando = editando && TabManager.getTabForToken(this) != null;
        TabManager.openTab(this);
    }

    @Override
    public JPopupMenu generatePopup(ProjectExplorerItem explorerItem) {
        JPopupMenu menu = new JPopupMenu();

        {
            JMenuItem item = new JMenuItem("Ver");

            item.addActionListener(e -> onInteract());

            menu.add(item);
        }
        {
            JMenuItem item = new JMenuItem("Editar");

            item.addActionListener(e -> {
                editando = true;
                TabManager.closeTab(TabManager.getTabForToken(this));
                TabManager.openTab(this);
            });

            menu.add(item);
        }
        menu.addSeparator();
        {
            JMenuItem item = new JMenuItem("Borrar");

            item.addActionListener(e -> borrar());

            menu.add(item);
        }
        return menu;
    }

    public static Asignatura crearNueva() {
        if(Main.registro.profesores.isEmpty()) {
            JOptionPane.showMessageDialog(Ventana.jframe, "No existen profesores registrados para la nueva asignatura", "Error", JOptionPane.ERROR_MESSAGE, new ImageIcon(Asignatura.ICON));
            return null;
        }
        Asignatura asig = new Asignatura(Main.registro, AreaAcademica.BASICAS, "Codigo", "Nombre", Main.registro.profesores.get(0), 1);
        Main.registro.asignaturas.add(asig);
        Ventana.projectExplorer.refresh();
        asig.setEditando(true);
        TabManager.openTab(asig);
        return asig;
    }

    public void borrar() {
        int result = JOptionPane.showOptionDialog(Ventana.jframe, "¿Está seguro de que quiere borrar " + this + "?", "Confirmación de acción", JOptionPane.YES_NO_OPTION, JOptionPane.WARNING_MESSAGE, new ImageIcon(ICON), new String[] {"Si", "No"}, "Si");
        if(result != JOptionPane.YES_OPTION) return;

        for(Calificaciones calif : Main.registro.calificaciones) {
            if(calif.getCalificaciones().containsKey(this)) {
                JOptionPane.showMessageDialog(Ventana.jframe, "<html>No se puede borrar " + this + ":<br>El reporte de calificaciones de " + calif.getEstudiante() + " para trimestre " + calif.getTrimestre() + " contiene esta asignatura</html>", "Error", JOptionPane.ERROR_MESSAGE, new ImageIcon(Calificaciones.ICON));
                return;
            }
        }

        TabManager.closeTab(TabManager.getTabForToken(this));
        Main.registro.asignaturas.remove(this);
        Ventana.projectExplorer.refresh();
    }

    @Override
    public String getSearchInfo() {
        return nombre + "\n" +
                codigo + "\n" +
                area.getNombre() + "\n" +
                creditos + " créditos" + "\n" +
                profesor.getSearchInfo();
    }
}
