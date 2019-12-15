package ids323.estudiantes.data;

import ids323.estudiantes.Main;
import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.Ventana;
import ids323.estudiantes.gui.explorer.ProjectExplorerItem;
import ids323.estudiantes.gui.modulos.DisplayModule;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.modulos.edicion.ModuloEdicionProfesor;
import ids323.estudiantes.gui.modulos.vista.ModuloVistaProfesor;
import ids323.estudiantes.util.Commons;

import javax.swing.*;
import java.awt.*;
import java.util.Collection;
import java.util.Collections;

public class Profesor implements ModuleToken {

    public static final Image ICON = Commons.getIcon("profesor");
    public static final Image ICON_NUEVO = Commons.getIcon("profesor_nuevo");

    private String nombre;
    private String apellido;
    private int id;

    private boolean editando = false;

    public Profesor(int id) {
        this.id = id;
    }

    public Profesor(Registro registro, String nombre, String apellido) {
        id = registro.ID_PROFESOR++;
        this.nombre = nombre;
        this.apellido = apellido;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public int getId() {
        return id;
    }

    public boolean isEditando() {
        return editando;
    }

    public void setEditando(boolean editando) {
        this.editando = editando;
    }

    @Override
    public String toString() {
        return "Prof. " + nombre + " " + apellido;
    }

    @Override
    public String getLabel() {
        return "P" + id + " - " + apellido + ", " + nombre;
    }

    @Override
    public Image getIcon() {
        return ICON;
    }

    @Override
    public String getHint() {
        return "Prof. " + apellido;
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
        return editando ? new ModuloEdicionProfesor(tab, this) : new ModuloVistaProfesor(tab, this);
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

    public static Profesor crearNuevo() {
        Profesor prof = new Profesor(Main.registro, "Nombre", "Apellido");

        Main.registro.profesores.add(prof);
        Ventana.projectExplorer.refresh();
        prof.setEditando(true);
        TabManager.openTab(prof);

        return prof;
    }

    public void borrar() {
        int result = JOptionPane.showOptionDialog(Ventana.jframe, "¿Está seguro de que quiere borrar " + this + "?", "Confirmación de acción", JOptionPane.YES_NO_OPTION, JOptionPane.WARNING_MESSAGE, new ImageIcon(ICON), new String[] {"Si", "No"}, "Si");
        if(result != JOptionPane.YES_OPTION) return;

        for(Asignatura asig : Main.registro.asignaturas) {
            if(asig.getProfesor() == this) {
                JOptionPane.showMessageDialog(Ventana.jframe, "<html>No se puede borrar " + this + ":<br>La asignatura " + asig + " está registrada con su nombre</html>", "Error", JOptionPane.ERROR_MESSAGE, new ImageIcon(Asignatura.ICON));
                return;
            }
        }

        TabManager.closeTab(TabManager.getTabForToken(this));
        Main.registro.profesores.remove(this);
        Ventana.projectExplorer.refresh();
    }

    @Override
    public String getSearchInfo() {
        return "Prof. " + nombre + " " + apellido + "\n" +
                "P" + id;
    }
}
