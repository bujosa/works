package ids323.estudiantes.data;

import ids323.estudiantes.Main;
import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.Ventana;
import ids323.estudiantes.gui.explorer.ProjectExplorerItem;
import ids323.estudiantes.gui.modulos.DisplayModule;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.modulos.edicion.ModuloEdicionEstudiante;
import ids323.estudiantes.gui.modulos.vista.ModuloVistaEstudiante;
import ids323.estudiantes.util.Commons;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collection;
import java.util.Collections;

/**
 * Representación de un estudiante como objeto.
 * */
public class Estudiante implements ModuleToken {

    public static final Image ICON = Commons.getIcon("estudiante");
    public static final Image ICON_NUEVO = Commons.getIcon("estudiante_nuevo");

    private String nombre;
    private String apellido;
    private Calendar fechaNacimiento;
    private Estado estado;
    private int id;
    private Carrera carrera;
    private boolean esExtranjero = false;

    private boolean editando = false;

    public Estudiante(int id) {
        this.id = id;
    }

    public Estudiante(Registro registro, String nombre, String apellido, Calendar fechaNacimiento, Estado estado, Carrera carrera, boolean esExtranjero) {
        id = registro.ID_ESTUDIANTE++;
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.estado = estado;
        this.carrera = carrera;
        this.esExtranjero = esExtranjero;
    }

    public Collection<Calificaciones> getAllCalificaciones() {
        ArrayList<Calificaciones> lista = new ArrayList<>();
        for(Calificaciones calif : Main.registro.calificaciones) {
            if(calif.getEstudiante() == this) lista.add(calif);
        }
        return lista;
    }

    public double getIndiceGeneral() {
        Collection<Calificaciones> califs = getAllCalificaciones();
        if(califs.isEmpty()) return -1;
        double puntos = 0;
        double creditos = 0;
        for(Calificaciones calif : califs) {
            puntos += calif.getPuntosDeHonor();
            creditos += calif.getCreditos();
        }
        return creditos != 0 ? puntos / creditos : -1;
    }

    public String getHonores() {
        double indice = getIndiceGeneral();
        if(indice == -1) return "-";
        if(indice >= 3.8) return "Summa Cum Laude";
        if(indice >= 3.5) return "Magna Cum Laude";
        return indice >= 3.2 ? "Cum Laude" : "Sin honor";
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

    public Calendar getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(Calendar fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }

    public Estado getEstado() {
        return estado;
    }

    public void setEstado(Estado estado) {
        this.estado = estado;
    }

    public int getId() {
        return id;
    }

    public Carrera getCarrera() {
        return carrera;
    }

    public void setCarrera(Carrera carrera) {
        this.carrera = carrera;
    }

    public boolean isExtranjero() {
        return esExtranjero;
    }

    public void setExtranjero(boolean esExtranjero) {
        this.esExtranjero = esExtranjero;
    }

    public boolean isEditando() {
        return editando;
    }

    public void setEditando(boolean editando) {
        this.editando = editando;
    }

    @Override
    public String toString() {
        return nombre + " " + apellido;
    }

    @Override
    public String getLabel() {
        return id + " - " + apellido + ", " + nombre;
    }

    @Override
    public Image getIcon() {
        return ICON;
    }

    @Override
    public String getHint() {
        return carrera.getCodigo();
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
        return (editando) ? new ModuloEdicionEstudiante(tab, this) : new ModuloVistaEstudiante(tab, this);
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

    public static Estudiante crearNuevo() {
        Calendar fechaNacimiento = Calendar.getInstance();
        fechaNacimiento.set(Calendar.YEAR, fechaNacimiento.get(Calendar.YEAR)-18);

        Estudiante est = new Estudiante(Main.registro, "Nombre", "Apellido", fechaNacimiento, Estado.EN_PROCESO, Carrera.AGN, false);
        Main.registro.estudiantes.add(est);
        Ventana.projectExplorer.refresh();
        est.setEditando(true);
        TabManager.openTab(est);

        return est;
    }

    public void borrar() {
        int result = JOptionPane.showOptionDialog(Ventana.jframe, "¿Está seguro de que quiere borrar " + this + "?", "Confirmación de acción", JOptionPane.YES_NO_OPTION, JOptionPane.WARNING_MESSAGE, new ImageIcon(ICON), new String[] {"Si", "No"}, "Si");
        if(result != JOptionPane.YES_OPTION) return;

        TabManager.closeTab(TabManager.getTabForToken(this));
        Main.registro.estudiantes.remove(this);
        Ventana.projectExplorer.refresh();
    }

    @Override
    public String getSearchInfo() {
        return nombre + " " + apellido + "\n" +
                id + "\n" +
                estado + "\n" +
                carrera.getCodigo() + "\n" +
                carrera.getNombre() + "\n" +
                ((esExtranjero) ? "Extranjero\nExtranjera" : "Dominicano\nDominicana") +
                (getHonores().length()>1 ? "\n" + getHonores() : "");
    }
}
